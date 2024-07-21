using System;
using System.Windows.Forms;

namespace AdminRepartoApp
{
    public partial class frmMain : Form
    {
        private string usuarioCorreo;

        public frmMain(string correo)
        {
            InitializeComponent();
            usuarioCorreo = correo;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsuarioIniciado.Text = usuarioCorreo;
            timerFechaHora.Start();
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
    }
}
