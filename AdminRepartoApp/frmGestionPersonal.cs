using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmGestionPersonal : Form
    {
        private int idEmpleado; // ID del empleado que realiza la acción

        public frmGestionPersonal(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
            HabilitarCampos(false); // Desactivar todos los campos al inicio
        }

        private void frmGestionPersonal_Load(object sender, EventArgs e)
        {
            // Configurar la cadena de conexión
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Cargar correos de usuarios
                    string queryCorreos = "SELECT Correo_Personal FROM Datos_Personales WHERE ID_Empleado IS NOT NULL";
                    MySqlCommand cmdCorreos = new MySqlCommand(queryCorreos, connection);
                    MySqlDataReader readerCorreos = cmdCorreos.ExecuteReader();

                    cmbBuscarPersonal.Items.Clear();
                    while (readerCorreos.Read())
                    {
                        cmbBuscarPersonal.Items.Add(readerCorreos["Correo_Personal"].ToString());
                    }
                    readerCorreos.Close();

                    // Mostrar mensaje si no hay elementos
                    if (cmbBuscarPersonal.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron usuarios en la base de datos.");
                    }

                    // Cargar tipos de personal en cmbTipoPersonal
                    string queryTiposPersonal = "SELECT DISTINCT Tipo_Empleado FROM Empleado";
                    MySqlCommand cmdTiposPersonal = new MySqlCommand(queryTiposPersonal, connection);
                    MySqlDataReader readerTiposPersonal = cmdTiposPersonal.ExecuteReader();

                    cmbTipoPersonal.Items.Clear();
                    while (readerTiposPersonal.Read())
                    {
                        cmbTipoPersonal.Items.Add(readerTiposPersonal["Tipo_Empleado"].ToString());
                    }
                    readerTiposPersonal.Close();

                    // Mostrar mensaje si no hay tipos de personal
                    if (cmbTipoPersonal.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron tipos de personal en la base de datos.");
                    }

                    // Cargar roles en cmbRol
                    string queryRoles = "SELECT DISTINCT Tipo_Empleado FROM Empleado";
                    MySqlCommand cmdRoles = new MySqlCommand(queryRoles, connection);
                    MySqlDataReader readerRoles = cmdRoles.ExecuteReader();

                    cmbRol.Items.Clear();
                    while (readerRoles.Read())
                    {
                        cmbRol.Items.Add(readerRoles["Tipo_Empleado"].ToString());
                    }
                    readerRoles.Close();

                    // Mostrar mensaje si no hay roles
                    if (cmbRol.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron roles en la base de datos.");
                    }

                    // Cargar estados en cmbEstado
                    cmbEstado.Items.Clear();
                    cmbEstado.Items.Add("Activo");
                    cmbEstado.Items.Add("Inactivo");
                    cmbEstado.Items.Add("Suspendido");

                    // Cargar géneros en cmbGenero
                    string queryGeneros = "SELECT DISTINCT Genero FROM Datos_Personales";
                    MySqlCommand cmdGeneros = new MySqlCommand(queryGeneros, connection);
                    MySqlDataReader readerGeneros = cmdGeneros.ExecuteReader();

                    cmbGenero.Items.Clear();
                    while (readerGeneros.Read())
                    {
                        cmbGenero.Items.Add(readerGeneros["Genero"].ToString());
                    }
                    readerGeneros.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void cmbBuscarPersonal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbBuscarPersonal.SelectedItem == null)
                return;

            // Obtener el correo seleccionado
            string correo = cmbBuscarPersonal.SelectedItem.ToString();

            // Configurar la cadena de conexión
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.Nombres, dp.Apellidos, dp.Genero, dp.Direccion_Personal, dp.Correo_Personal, dp.DPI, dp.Contrasena,
                               e.Tipo_Empleado, e.Horario, e.Permitir_Editar, e.Permitir_Eliminar, e.Permitir_Añadir_Usuario, e.Estado
                        FROM Datos_Personales dp
                        INNER JOIN Empleado e ON dp.ID_Empleado = e.ID_Empleado
                        WHERE dp.Correo_Personal = @correo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPersonal.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        txtNombre.Text = row["Nombres"].ToString();
                        txtApellido.Text = row["Apellidos"].ToString();
                        cmbGenero.SelectedItem = row["Genero"].ToString();
                        txtDireccion.Text = row["Direccion_Personal"].ToString();
                        txtCorreo.Text = row["Correo_Personal"].ToString();
                        txtDPI.Text = row["DPI"].ToString();
                        txtPassword.Text = row["Contrasena"].ToString();
                        cmbRol.SelectedItem = row["Tipo_Empleado"].ToString();
                        // Suponiendo que cmbEstado tiene los valores "Activo", "Inactivo", "Suspendido"
                        cmbEstado.SelectedItem = row["Estado"].ToString();
                        chkPermitirEditar.Checked = row["Permitir_Editar"].ToString() == "V";
                        chkPermitirEliminar.Checked = row["Permitir_Eliminar"].ToString() == "V";
                        chkPermitirAnadir.Checked = row["Permitir_Añadir_Usuario"].ToString() == "V";

                        HabilitarCampos(true); // Habilitar campos después de cargar datos
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el usuario seleccionado.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (cmbBuscarPersonal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario para actualizar.");
                return;
            }

            // Validar campos
            if (!ValidarCampos())
            {
                return;
            }

            // Obtener el correo seleccionado
            string correo = cmbBuscarPersonal.SelectedItem.ToString();

            // Determinar los valores de los permisos
            string permitirEditar = chkPermitirEditar.Checked ? "V" : "F";
            string permitirEliminar = chkPermitirEliminar.Checked ? "V" : "F";
            string permitirAnadir = chkPermitirAnadir.Checked ? "V" : "F";

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
                            dp.Correo_Personal = @correo, dp.DPI = @dpi, dp.Contrasena = @contrasena, dp.Telefono = @telefono,
                            e.Tipo_Empleado = @tipoEmpleado, e.Estado = @estado
                        WHERE dp.Correo_Personal = @correo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@permitirEditar", permitirEditar);
                    cmd.Parameters.AddWithValue("@permitirEliminar", permitirEliminar);
                    cmd.Parameters.AddWithValue("@permitirAnadir", permitirAnadir);
                    cmd.Parameters.AddWithValue("@nombres", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@apellidos", txtApellido.Text);
                    cmd.Parameters.AddWithValue("@genero", cmbGenero.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@dpi", txtDPI.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmd.Parameters.AddWithValue("@tipoEmpleado", cmbRol.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@estado", cmbEstado.SelectedItem.ToString());

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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (cmbBuscarPersonal.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            string correo = cmbBuscarPersonal.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar al usuario: " + txtNombre.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Empleado WHERE ID_Empleado = (SELECT ID_Empleado FROM Datos_Personales WHERE Correo_Personal = @correo)";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@correo", correo);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            string queryDP = "DELETE FROM Datos_Personales WHERE Correo_Personal = @correo";
                            MySqlCommand cmdDP = new MySqlCommand(queryDP, connection);
                            cmdDP.Parameters.AddWithValue("@correo", correo);

                            cmdDP.ExecuteNonQuery();

                            // Registrar la acción en la tabla de logs
                            string accion = $"{{\"accion\": \"Eliminación de usuario\", \"correo\": \"{correo}\"}}";
                            RegistrarLog(accion);

                            MessageBox.Show("Usuario eliminado exitosamente.");
                            cmbBuscarPersonal.Items.Remove(correo);
                            LimpiarCampos();
                            HabilitarCampos(false);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
                    }
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

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(txtDPI.Text) || string.IsNullOrEmpty(txtPassword.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) || cmbGenero.SelectedItem == null ||
                cmbRol.SelectedItem == null || cmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo no tiene un formato válido.");
                return false;
            }

            if (!Regex.IsMatch(txtTelefono.Text, @"^\d{8}$"))
            {
                MessageBox.Show("El teléfono debe tener 8 dígitos.");
                return false;
            }

            return true;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            cmbGenero.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            txtDPI.Enabled = habilitar;
            txtPassword.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            cmbRol.Enabled = habilitar;
            cmbEstado.Enabled = habilitar;
            chkPermitirEditar.Enabled = habilitar;
            chkPermitirEliminar.Enabled = habilitar;
            chkPermitirAnadir.Enabled = habilitar;
            btnActualizar.Enabled = habilitar;
            btnEliminar.Enabled = habilitar;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbGenero.SelectedIndex = -1;
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtDPI.Clear();
            txtPassword.Clear();
            txtTelefono.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
            chkPermitirEditar.Checked = false;
            chkPermitirEliminar.Checked = false;
            chkPermitirAnadir.Checked = false;
        }

        private void cmbTipoPersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoPersonal.SelectedItem == null)
                return;

            string tipoEmpleado = cmbTipoPersonal.SelectedItem.ToString();

            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.Correo_Personal, dp.Nombres, dp.Apellidos, dp.Genero, dp.Direccion_Personal, dp.DPI, dp.Telefono, e.Tipo_Empleado, e.Estado
                        FROM Datos_Personales dp
                        INNER JOIN Empleado e ON dp.ID_Empleado = e.ID_Empleado
                        WHERE dp.ID_Empleado IS NOT NULL AND e.Tipo_Empleado = @tipoEmpleado";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tipoEmpleado", tipoEmpleado);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPersonal.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        cmbBuscarPersonal.Items.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            cmbBuscarPersonal.Items.Add(row["Correo_Personal"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron empleados de este tipo en la base de datos.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }
    }
}
