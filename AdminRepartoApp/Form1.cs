using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Puedes dejar esto vacío si no necesitas hacer nada al cargar el formulario
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Configurar la cadena de conexión
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";

            // Obtener los valores de los campos de texto
            string correo = txtCorreo.Text;
            string contrasena = txtContrasena.Text;

            // Intentar abrir la conexión y verificar los datos
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID_Empleado, Nombres FROM Datos_Personales WHERE Correo_Personal = @correo AND Contrasena = @contrasena";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idEmpleado = reader.GetInt32("ID_Empleado");
                            string nombre = reader.GetString("Nombres");

                            MessageBox.Show("Bienvenido " + nombre);

                            // Registrar el inicio de sesión en el log
                            RegistrarLog(idEmpleado, "Inicio de Sesión");

                            // Ocultar el formulario de inicio de sesión y mostrar el formulario principal
                            this.Hide();
                            frmMain mainForm = new frmMain(correo);
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Correo o contraseña incorrectos.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void RegistrarLog(int idEmpleado, string accion)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO LogActividades (ID_Empleado, Accion, FechaHora) VALUES (@idEmpleado, JSON_OBJECT('accion', @accion), @fechaHora)";
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
