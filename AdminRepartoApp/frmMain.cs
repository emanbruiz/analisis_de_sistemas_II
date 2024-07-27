using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmMain : Form
    {
        private string usuarioCorreo;
        private bool permitirEditar;
        private bool esAdministrador;
        private int idEmpleado; // ID del empleado que inició sesión

        public frmMain(string correo, bool permitirEditar, bool esAdministrador, int idEmpleado)
        {
            InitializeComponent();
            usuarioCorreo = correo;
            this.permitirEditar = permitirEditar;
            this.esAdministrador = esAdministrador;
            this.idEmpleado = idEmpleado;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsuarioIniciado.Text = usuarioCorreo;
            timerFechaHora.Start();
            btnRoles.Enabled = permitirEditar;  // Habilitar o deshabilitar el botón según los permisos
            btnLogs.Visible = esAdministrador; // Mostrar el botón de logs solo para administradores
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        }

        private void btnNuevosUsuarios_Click(object sender, EventArgs e)
        {
            frmRegister registerForm = new frmRegister();
            registerForm.Show();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            // Pasar el ID del empleado al formulario de roles
            frmRoles rolesForm = new frmRoles(idEmpleado);
            rolesForm.Show();
        }

        private void btnActualizarDatosUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                frmUpdate updateForm = new frmUpdate(idEmpleado); // Pasar el ID del empleado al formulario de actualización
                updateForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de actualización: " + ex.Message);
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            try
            {
                frmProducto productosForm = new frmProducto();
                productosForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de productos: " + ex.Message);
            }
        }

        private List<string> ObtenerCorreosUsuarios()
        {
            var correos = new List<string>();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Correo_Personal FROM Datos_Personales";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        correos.Add(reader["Correo_Personal"].ToString());
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
            return correos;
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            try
            {
                frmVerProductos verProductosForm = new frmVerProductos();
                verProductosForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de productos: " + ex.Message);
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogs logsForm = new frmLogs();
                logsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de productos: " + ex.Message);
            }
        }

        private void btnGestionPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                frmGestionPersonal gestionPersonalForm = new frmGestionPersonal(idEmpleado); // Pasar el idEmpleado
                gestionPersonalForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de gestión de personal: " + ex.Message);
            }
        }

        private void btnClientesPilotos_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientesPilotos clientesPilotosForm = new frmClientesPilotos();
                clientesPilotosForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de Clientes y Pilotos: " + ex.Message);
            }
        }

    }
}
