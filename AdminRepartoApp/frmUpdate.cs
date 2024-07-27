using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmUpdate : Form
    {
        private bool usuariosCargados = false; // Variable de estado
        private int idEmpleado; // ID del empleado que realiza la acción

        public frmUpdate(int idEmpleado)
        {
            InitializeComponent();
            btnCargarDatos.Enabled = false; // Deshabilitar btnCargarDatos inicialmente
            DeshabilitarCampos(); // Deshabilitar todos los campos al inicio
            this.idEmpleado = idEmpleado;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Configurar la cadena de conexión
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Correo_Personal FROM Datos_Personales";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbUsuarios.Items.Clear();
                    while (reader.Read())
                    {
                        cmbUsuarios.Items.Add(reader["Correo_Personal"].ToString());
                    }
                    reader.Close();

                    // Mostrar mensaje si no hay elementos
                    if (cmbUsuarios.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron usuarios en la base de datos.");
                    }
                    else
                    {
                        usuariosCargados = true; // Establecer la variable de estado a true
                        btnCargarDatos.Enabled = true; // Habilitar btnCargarDatos
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnCargarDatos_Click_1(object sender, EventArgs e)
        {
            if (!usuariosCargados)
            {
                MessageBox.Show("Primero debe cargar los usuarios presionando el botón 'Cargar Usuarios'.");
                return;
            }

            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario para cargar sus datos.");
                return;
            }

            // Obtener el correo seleccionado
            string correo = cmbUsuarios.SelectedItem.ToString();

            // Configurar la cadena de conexión
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.Nombres, dp.Apellidos, dp.Genero, dp.Direccion_Personal, dp.Correo_Personal, dp.DPI, dp.Contrasena, 
                               e.Tipo_Empleado, e.Horario, e.Permitir_Editar, e.Permitir_Eliminar, e.Permitir_Añadir_Usuario
                        FROM Datos_Personales dp
                        INNER JOIN Empleado e ON dp.ID_Empleado = e.ID_Empleado
                        WHERE dp.Correo_Personal = @correo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombres.Text = reader["Nombres"].ToString();
                        txtApellidos.Text = reader["Apellidos"].ToString();
                        cmbGenero.SelectedItem = reader["Genero"].ToString();
                        txtMail.Text = reader["Correo_Personal"].ToString();
                        txtDPI.Text = reader["DPI"].ToString();
                        txtPassword.Text = reader["Contrasena"].ToString();
                        cmbTipoUsuario.SelectedItem = reader["Tipo_Empleado"].ToString();
                        cmbHorarios.SelectedItem = reader["Horario"].ToString();

                        chkEditarPermiso.Checked = reader["Permitir_Editar"].ToString() == "V";
                        chkEliminar.Checked = reader["Permitir_Eliminar"].ToString() == "V";
                        chkAnadir.Checked = reader["Permitir_Añadir_Usuario"].ToString() == "V";

                        HabilitarCampos(); // Habilitar los campos después de cargar los datos
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnActualizarUsuario_Click_1(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario para actualizar.");
                return;
            }

            // Obtener el correo seleccionado
            string correo = cmbUsuarios.SelectedItem.ToString();

            // Determinar los valores de los permisos
            string permitirEditar = chkEditarPermiso.Checked ? "V" : "F";
            string permitirEliminar = chkEliminar.Checked ? "V" : "F";
            string permitirAnadir = chkAnadir.Checked ? "V" : "F";

            // Configurar la cadena de conexión
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        UPDATE Empleado e
                        INNER JOIN Datos_Personales dp ON e.ID_Empleado = dp.ID_Empleado
                        SET e.Permitir_Editar = @permitirEditar, e.Permitir_Eliminar = @permitirEliminar, e.Permitir_Añadir_Usuario = @permitirAnadir,
                            dp.Nombres = @nombres, dp.Apellidos = @apellidos, dp.Genero = @genero, dp.Direccion_Personal = @direccion,
                            dp.Correo_Personal = @correo, dp.DPI = @dpi, dp.Contrasena = @contrasena, e.Tipo_Empleado = @tipoEmpleado,
                            e.Horario = @horario
                        WHERE dp.Correo_Personal = @correo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@permitirEditar", permitirEditar);
                    cmd.Parameters.AddWithValue("@permitirEliminar", permitirEliminar);
                    cmd.Parameters.AddWithValue("@permitirAnadir", permitirAnadir);
                    cmd.Parameters.AddWithValue("@nombres", txtNombres.Text);
                    cmd.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                    cmd.Parameters.AddWithValue("@genero", cmbGenero.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@correo", txtMail.Text);
                    cmd.Parameters.AddWithValue("@dpi", txtDPI.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@tipoEmpleado", cmbTipoUsuario.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@horario", cmbHorarios.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    // Registrar la acción en la tabla de logs
                    string accion = $"{{\"accion\": \"Actualización de datos de usuario\", \"correo\": \"{correo}\"}}";
                    RegistrarLog(accion);

                    MessageBox.Show("Datos del usuario actualizados exitosamente.");
                    this.Close();  // Cerrar el formulario después del registro exitoso
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar los datos del usuario: " + ex.Message);
                }
            }
        }

        private void RegistrarLog(string accion)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO LogActividades (ID_Empleado, Accion, FechaHora) VALUES (@idEmpleado, @accion, @fechaHora)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@accion", accion);
                    cmd.Parameters.AddWithValue("@fechaHora", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al registrar la actividad en el log: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            // Obtener el correo seleccionado
            string correo = cmbUsuarios.SelectedItem.ToString();
            string nombre = txtNombres.Text;

            // Confirmar la eliminación
            DialogResult result = MessageBox.Show($"¿Está seguro que desea eliminar al usuario: {nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Configurar la cadena de conexión
                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Datos_Personales WHERE Correo_Personal = @correo";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@correo", correo);

                        cmd.ExecuteNonQuery();

                        // Registrar la acción en la tabla de logs
                        string accion = $"{{\"accion\": \"Eliminación de usuario\", \"correo\": \"{correo}\"}}";
                        RegistrarLog(accion);

                        MessageBox.Show("Usuario eliminado exitosamente.");

                        // Limpiar los campos después de eliminar
                        LimpiarCampos();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                    }
                }
            }
        }

        private void DeshabilitarCampos()
        {
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            cmbGenero.Enabled = false;
            txtDireccion.Enabled = false;
            txtMail.Enabled = false;
            txtDPI.Enabled = false;
            txtPassword.Enabled = false;
            cmbTipoUsuario.Enabled = false;
            cmbHorarios.Enabled = false;
            chkEditarPermiso.Enabled = false;
            chkEliminar.Enabled = false;
            chkAnadir.Enabled = false;
            btnActualizarUsuario.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            cmbGenero.Enabled = true;
            txtDireccion.Enabled = true;
            txtMail.Enabled = true;
            txtDPI.Enabled = true;
            txtPassword.Enabled = true;
            cmbTipoUsuario.Enabled = true;
            cmbHorarios.Enabled = true;
            chkEditarPermiso.Enabled = true;
            chkEliminar.Enabled = true;
            chkAnadir.Enabled = true;
            btnActualizarUsuario.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            cmbGenero.SelectedIndex = -1;
            txtDireccion.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtDPI.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbTipoUsuario.SelectedIndex = -1;
            cmbHorarios.SelectedIndex = -1;
            chkEditarPermiso.Checked = false;
            chkEliminar.Checked = false;
            chkAnadir.Checked = false;

            DeshabilitarCampos(); // Deshabilitar campos después de limpiar
        }
    }
}
