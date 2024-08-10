// Form hecho por Anika Miscelly Escoto Leon || 0901-21-8122
using System;
using System.Windows.Forms;

namespace PilotosRepartoApp
{
    public partial class frmMenu : Form
    {
        private int idPersona;
        private string correoPiloto;
        private Timer timerFechaHora; // Timer para actualizar la fecha y hora

        public frmMenu(int idPersona, string correo)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            correoPiloto = correo;
            lblUser.Text = correoPiloto;

            // Inicializar y configurar el timer
            timerFechaHora = new Timer();
            timerFechaHora.Interval = 1000; // 1 segundo
            timerFechaHora.Tick += TimerFechaHora_Tick;
            timerFechaHora.Start();
        }

        private void TimerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFyH.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            frmVerPedidos verPedidosForm = new frmVerPedidos(correoPiloto);
            verPedidosForm.Show();
        }

        private void btnRegistroEntregas_Click(object sender, EventArgs e)
        {
            frmActualizarPedido actualizarPedidoForm = new frmActualizarPedido(correoPiloto);
            actualizarPedidoForm.Show();
        }

        private void btnVerRutas_Click(object sender, EventArgs e)
        {
            // Usa un valor de dirección y número de factura predeterminados si no se selecciona nada
            string direccion = "Seleccione un pedido";
            string noFactura = "Factura Predeterminada";

            // Abre el formulario con valores predeterminados, se actualizarán cuando se cargue el formulario
            frmVerRutas verRutasForm = new frmVerRutas(correoPiloto, direccion, noFactura);
            verRutasForm.Show();
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una instancia del formulario frVerPedidos
                frmPerfil Perfilform = new frmPerfil(idPersona);
                Perfilform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de ver perfil: " + ex.Message);
            }
        }
    }
}
