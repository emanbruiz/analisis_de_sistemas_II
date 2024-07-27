using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmRoles : Form
    {
        private int idEmpleado; // ID del empleado que realiza la acción

        public frmRoles(int idEmpleado)
        {
            InitializeComponent();
            this.idEmpleado = idEmpleado;
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
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
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsuarios.SelectedItem == null)
                return;

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
                        SELECT e.Permitir_Editar, e.Permitir_Eliminar, e.Permitir_Añadir_Usuario
                        FROM Empleado e
                        INNER JOIN Datos_Personales dp ON e.ID_Empleado = dp.ID_Empleado
                        WHERE dp.Correo_Personal = @correo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        chkEditarPermiso.Checked = reader["Permitir_Editar"].ToString() == "V";
                        chkEliminar.Checked = reader["Permitir_Eliminar"].ToString() == "V";
                        chkAnadir.Checked = reader["Permitir_Añadir_Usuario"].ToString() == "V";
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
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
                        SET e.Permitir_Editar = @permitirEditar, e.Permitir_Eliminar = @permitirEliminar, e.Permitir_Añadir_Usuario = @permitirAnadir
                        WHERE dp.Correo_Personal = @correo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@permitirEditar", permitirEditar);
                    cmd.Parameters.AddWithValue("@permitirEliminar", permitirEliminar);
                    cmd.Parameters.AddWithValue("@permitirAnadir", permitirAnadir);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Roles actualizados exitosamente.");
                        // Registrar la acción en la tabla de logs
                        string accion = $"{{\"accion\": \"Actualización de roles\", \"correo\": \"{correo}\"}}";
                        RegistrarLog(accion);
                        this.Close();  // Cerrar el formulario después del registro exitoso
                    }
                    else
                    {
                        MessageBox.Show("No se realizaron cambios en los roles.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar los roles: " + ex.Message);
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
    }
}
