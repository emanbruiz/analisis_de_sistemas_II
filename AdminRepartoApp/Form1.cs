// Form Hecho por Kevin Daniel Santos Castro || 0901-17-2994
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Text.RegularExpressions;

namespace AdminRepartoApp
{
    public partial class frmLogin : Form
    {
        private int loginAttempts = 0;  // Contador de intentos de inicio de sesión

        public frmLogin()
        {
            InitializeComponent();

            // Agregar manejadores de eventos KeyPress para los TextBox
            txtCorreo.KeyPress += new KeyPressEventHandler(txt_KeyPress);
            txtContrasena.KeyPress += new KeyPressEventHandler(txt_KeyPress);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Mostrar mensaje de bienvenida basado en la hora del día
            string mensajeBienvenida = ObtenerMensajeBienvenida();
            MessageBox.Show(mensajeBienvenida, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evitar el sonido de beep
                btnLogin_Click_1(sender, e); // Ejecutar el evento de clic del botón
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // Validar campos
            if (!ValidarCampos())
            {
                return;
            }

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
                    string query = @"
                        SELECT dp.ID_Empleado, dp.Nombres, e.Permitir_Editar, e.Tipo_Empleado
                        FROM Datos_Personales dp
                        INNER JOIN Empleado e ON dp.ID_Empleado = e.ID_Empleado
                        WHERE dp.Correo_Personal = @correo AND dp.Contrasena = @contrasena";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int idEmpleado = reader.GetInt32("ID_Empleado");
                            string nombre = reader.GetString("Nombres");
                            bool permitirEditar = reader.GetString("Permitir_Editar") == "V";
                            bool esAdministrador = reader.GetString("Tipo_Empleado") == "Administrador";

                            MessageBox.Show("Bienvenido " + nombre);

                            // Registrar el inicio de sesión en el log
                            RegistrarLog(idEmpleado, "Inicio de Sesión");

                            // Ocultar el formulario de inicio de sesión y mostrar el formulario principal
                            this.Hide();
                            frmMain mainForm = new frmMain(correo, permitirEditar, esAdministrador, idEmpleado);
                            mainForm.Show();
                        }
                        else
                        {
                            loginAttempts++;  // Incrementar el contador de intentos fallidos
                            MessageBox.Show("Correo o contraseña incorrectos.");

                            // Si se alcanzan 3 intentos fallidos, registrar en el log
                            if (loginAttempts >= 3)
                            {
                                RegistrarIntentoFallido(correo);
                                loginAttempts = 0;  // Reiniciar el contador
                            }
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

        private void RegistrarIntentoFallido(string correo)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Obtener información del equipo
                    string nombreEquipo = Environment.MachineName;
                    string direccionIP = ObtenerDireccionIP();

                    string accion = $"{{\"accion\": \"Intento de inicio de sesión fallido\", \"correo\": \"{correo}\", \"Nombre del equipo\": \"{nombreEquipo}\", \"direccionIP\": \"{direccionIP}\"}}";
                    string query = "INSERT INTO LogActividades (ID_Empleado, Accion, FechaHora) VALUES (NULL, @accion, @fechaHora)"; // ID_Empleado es NULL porque no se puede identificar

                    MySqlCommand cmd = new MySqlCommand(query, connection);
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

        private string ObtenerDireccionIP()
        {
            string ip = "";
            foreach (IPAddress ipAddress in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = ipAddress.ToString();
                    break;
                }
            }
            return ip;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContrasena.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo no tiene un formato válido.");
                return false;
            }

            return true;
        }

        private string ObtenerMensajeBienvenida()
        {
            string mensaje = "Bienvenido a AdminRepartoApp";
            int hora = DateTime.Now.Hour;

            if (hora < 12)
            {
                mensaje = "¡Buenos días! " + mensaje;
            }
            else if (hora < 18)
            {
                mensaje = "¡Buenas tardes! " + mensaje;
            }
            else
            {
                mensaje = "¡Buenas noches! " + mensaje;
            }

            return mensaje;
        }
    }
}
