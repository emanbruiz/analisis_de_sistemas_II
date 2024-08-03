using System;
using System.Linq;
using System.Windows.Forms;

namespace ClientesRepartoApp
{
    public partial class frmMenu : Form
    {
        private int idPersona;
        private string correoUsuario;

        public frmMenu(int idPersona, string correo)
        {
            InitializeComponent();
            InicializarMenu(idPersona, correo);
        }

        private void InicializarMenu(int idPersona, string correo)
        {
            try
            {
                // Validar que el correo no sea nulo o vacío
                if (string.IsNullOrEmpty(correo))
                {
                    throw new ArgumentException("El correo del usuario no puede ser nulo o vacío.");
                }

                this.idPersona = idPersona;
                this.correoUsuario = correo;
                lblUser.Text = correoUsuario;
                lblFyH.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar el menú: " + ex.Message);
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargar cualquier recurso necesario al iniciar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frmLogin loginForm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault() ?? new frmLogin();
                loginForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar sesión: " + ex.Message);
            }
        }

        private void btnRealizarPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del formulario frmRealizarPedidos y pasar el ID de la persona
                frmRealizarPedidos realizarPedidosForm = new frmRealizarPedidos(idPersona);
                realizarPedidosForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de realizar pedidos: " + ex.Message);
            }
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del formulario frVerPedidos
                frmVerPedidos verPedidosForm = new frmVerPedidos(idPersona);
                verPedidosForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de ver pedidos: " + ex.Message);
            }
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del formulario frVerPedidos
                frmPerfil Perfilform = new frmPerfil(idPersona);
                Perfilform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de ver pedidos: " + ex.Message);
            }
        }
    }
}
