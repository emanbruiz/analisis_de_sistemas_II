using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegisterCliente_Click(object sender, EventArgs e)
        {
            // Cadena de conexión
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Verificar que el correo y el DPI no existan en la tabla Datos_Personales
                    string verificarQuery = "SELECT COUNT(*) FROM Datos_Personales WHERE DPI = @dpi OR Correo_Personal = @correo";
                    MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, connection);
                    verificarCmd.Parameters.AddWithValue("@dpi", txtDPI.Text);
                    verificarCmd.Parameters.AddWithValue("@correo", txtMail.Text);

                    int count = Convert.ToInt32(verificarCmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("El correo o el DPI ya existen en el sistema.");
                        return;
                    }

                    // Insertar en la tabla Empleado
                    string insertEmpleadoQuery = "INSERT INTO Empleado (Tipo_Empleado, Horario, Permitir_Editar, Permitir_Eliminar, Permitir_Añadir_Usuario) " +
                                                 "VALUES (@tipoEmpleado, @horario, @permitirEditar, @permitirEliminar, @permitirAñadirUsuario)";
                    MySqlCommand insertEmpleadoCmd = new MySqlCommand(insertEmpleadoQuery, connection);
                    insertEmpleadoCmd.Parameters.AddWithValue("@tipoEmpleado", cmbTipoUsuario.SelectedItem.ToString());
                    insertEmpleadoCmd.Parameters.AddWithValue("@horario", cmbHorarios.SelectedItem.ToString());
                    insertEmpleadoCmd.Parameters.AddWithValue("@permitirEditar", chkEditarPermiso.Checked ? "V" : "F");
                    insertEmpleadoCmd.Parameters.AddWithValue("@permitirEliminar", chkEliminar.Checked ? "V" : "F");
                    insertEmpleadoCmd.Parameters.AddWithValue("@permitirAñadirUsuario", chkAnadir.Checked ? "V" : "F");

                    insertEmpleadoCmd.ExecuteNonQuery();

                    // Obtener el ID del Empleado insertado
                    long lastIdEmpleado = insertEmpleadoCmd.LastInsertedId;

                    // Insertar en la tabla Datos_Personales
                    string insertDatosPersonalesQuery = "INSERT INTO Datos_Personales (Genero, Nombres, Apellidos, Direccion_Personal, Correo_Personal, DPI, Contrasena, ID_Empleado) " +
                                                        "VALUES (@genero, @nombres, @apellidos, @direccionPersonal, @correoPersonal, @dpi, @contrasena, @idEmpleado)";
                    MySqlCommand insertDatosPersonalesCmd = new MySqlCommand(insertDatosPersonalesQuery, connection);
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@genero", cmbGenero.SelectedItem.ToString());
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@nombres", txtNombres.Text);
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@apellidos", txtApellidos.Text);
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@direccionPersonal", txtDireccion.Text);
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@correoPersonal", txtMail.Text);
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@dpi", txtDPI.Text);
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);
                    insertDatosPersonalesCmd.Parameters.AddWithValue("@idEmpleado", lastIdEmpleado);

                    insertDatosPersonalesCmd.ExecuteNonQuery();

                    // Registrar la acción en la tabla de logs
                    string accion = $"{{\"accion\": \"Registro de nuevo cliente\", \"idEmpleado\": \"{lastIdEmpleado}\"}}";
                    string insertLogQuery = "INSERT INTO LogActividades (ID_Empleado, Accion, FechaHora) " +
                                            "VALUES (@idEmpleado, @accion, @fechaHora)";
                    MySqlCommand insertLogCmd = new MySqlCommand(insertLogQuery, connection);
                    insertLogCmd.Parameters.AddWithValue("@idEmpleado", lastIdEmpleado);
                    insertLogCmd.Parameters.AddWithValue("@accion", accion);
                    insertLogCmd.Parameters.AddWithValue("@fechaHora", DateTime.Now);

                    insertLogCmd.ExecuteNonQuery();

                    MessageBox.Show("Registro exitoso.");
                    this.Close();  // Cerrar el formulario después del registro exitoso
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al registrar el cliente: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }
    }
}
