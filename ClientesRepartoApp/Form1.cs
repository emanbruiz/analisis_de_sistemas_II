// Form hecho por Kevin Daniel Santos Castro || 0901-17-2994
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientesRepartoApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // Agregar eventos KeyDown a los campos de texto
            txtCorreo.KeyDown += new KeyEventHandler(txt_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(txt_KeyDown);
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID_Persona, Correo_Personal FROM datos_personales WHERE Correo_Personal = @correo AND Contrasena = @contrasena AND ID_Cliente IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                    cmd.Parameters.AddWithValue("@contrasena", txtPassword.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        int idPersona = Convert.ToInt32(reader["ID_Persona"]);
                        string correoUsuario = reader["Correo_Personal"].ToString();
                        MessageBox.Show("Inicio de sesión exitoso.");
                        // Redirigir al menú principal y pasar el ID y correo del usuario
                        frmMenu menu = new frmMenu(idPersona, correoUsuario);
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos, o no es un cliente.");
                        RegistrarLogActividad("Intento fallido de inicio de sesión");
                    }

                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                    RegistrarLogActividad($"Error de conexión: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
                    RegistrarLogActividad($"Error inesperado: {ex.Message}");
                }
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnIniciarSesion_Click(sender, e);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form registroForm = Application.OpenForms.OfType<frmRegistro>().FirstOrDefault();
            if (registroForm != null)
            {
                registroForm.BringToFront();
            }
            else
            {
                frmRegistro registro = new frmRegistro();
                registro.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarLogActividad(string accion)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string equipo = Dns.GetHostName();
                    string ip = ObtenerIPv4();
                    string query = "INSERT INTO logactividades (ID_Empleado, Accion, FechaHora) VALUES (NULL, @accion, NOW())";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@accion", $"{{\"accion\":\"{accion}\", \"equipo\":\"{equipo}\", \"ip\":\"{ip}\"}}");
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la actividad: " + ex.Message);
                }
            }
        }

        private string ObtenerIPv4()
        {
            string ip = string.Empty;
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
    }
}
