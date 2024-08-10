//Form Hecho por Anika Miscelly Escoto Leon || 0901-21-8122
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmGestionPedidos : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";

        public frmGestionPedidos()
        {
            InitializeComponent();
            CargarComboboxPedidos();
            CargarDatosPedidos();
            HabilitarCamposPedido(false);
            HabilitarCamposCliente(false);
        }

        private void CargarComboboxPedidos()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT No_Factura FROM Pedido";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbBuscarPedido.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBuscarPedido.Items.Add(reader["No_Factura"].ToString());
                    }
                    reader.Close();

                    if (cmbBuscarPedido.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron pedidos en la base de datos.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar pedidos: " + ex.Message);
                }
            }
        }

        private void CargarDatosPedidos()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Pedido";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPedidos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos de pedidos: " + ex.Message);
                }
            }
        }

        private void cmbBuscarPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarPedido.SelectedItem == null) return;

            string noFactura = cmbBuscarPedido.SelectedItem.ToString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryPedido = @"
                        SELECT Tipo_Pedido, No_Factura, Fecha_Solicitud, Cantidad, Monto, Empresa, Envio, Estado
                        FROM Pedido
                        WHERE No_Factura = @noFactura";
                    MySqlCommand cmdPedido = new MySqlCommand(queryPedido, connection);
                    cmdPedido.Parameters.AddWithValue("@noFactura", noFactura);

                    MySqlDataReader readerPedido = cmdPedido.ExecuteReader();
                    if (readerPedido.Read())
                    {
                        cmbTipoPedido.SelectedItem = readerPedido["Tipo_Pedido"].ToString();
                        txtNoFactura.Text = readerPedido["No_Factura"].ToString();
                        dtpFechaSolicitud.Value = Convert.ToDateTime(readerPedido["Fecha_Solicitud"]);
                        txtCantidad.Text = readerPedido["Cantidad"].ToString();
                        txtMonto.Text = readerPedido["Monto"].ToString();
                        txtEmpresa.Text = readerPedido["Empresa"].ToString();
                        txtEnvio.Text = readerPedido["Envio"].ToString();
                        cmbEstado.SelectedItem = readerPedido["Estado"].ToString();
                    }
                    readerPedido.Close();

                    string queryCliente = @"
                        SELECT dp.Nombres, dp.Apellidos, dp.Correo_Personal, dp.Telefono, dp.Direccion_Personal, dp.Genero, dp.DPI, dp.PromedioCalificaciones
                        FROM Pedido p
                        JOIN Datos_Personales dp ON p.ID_Persona = dp.ID_Persona
                        WHERE p.No_Factura = @noFactura";
                    MySqlCommand cmdCliente = new MySqlCommand(queryCliente, connection);
                    cmdCliente.Parameters.AddWithValue("@noFactura", noFactura);

                    MySqlDataReader readerCliente = cmdCliente.ExecuteReader();
                    if (readerCliente.Read())
                    {
                        txtNombreCliente.Text = readerCliente["Nombres"].ToString();
                        txtApellidoCliente.Text = readerCliente["Apellidos"].ToString();
                        txtCorreoCliente.Text = readerCliente["Correo_Personal"].ToString();
                        txtTelefonoCliente.Text = readerCliente["Telefono"].ToString();
                        txtDireccionCliente.Text = readerCliente["Direccion_Personal"].ToString();
                        cmbGeneroCliente.SelectedItem = readerCliente["Genero"].ToString();
                        txtDPICliente.Text = readerCliente["DPI"].ToString();
                        txtCalificacionCliente.Text = readerCliente["PromedioCalificaciones"].ToString();
                    }
                    readerCliente.Close();

                    HabilitarCamposPedido(true);
                    HabilitarCamposCliente(true);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos del pedido y cliente: " + ex.Message);
                }
            }
        }

        private void btnActualizarPedido_Click(object sender, EventArgs e)
        {
            if (cmbBuscarPedido.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un pedido para actualizar.");
                return;
            }

            string noFactura = cmbBuscarPedido.SelectedItem.ToString();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        UPDATE Pedido 
                        SET Tipo_Pedido = @tipoPedido, Fecha_Solicitud = @fechaSolicitud, Cantidad = @cantidad,
                            Monto = @monto, Empresa = @empresa, Envio = @envio, Estado = @estado
                        WHERE No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@tipoPedido", cmbTipoPedido.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@fechaSolicitud", dtpFechaSolicitud.Value);
                    cmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidad.Text));
                    cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtMonto.Text));
                    cmd.Parameters.AddWithValue("@empresa", txtEmpresa.Text);
                    cmd.Parameters.AddWithValue("@envio", txtEnvio.Text);
                    cmd.Parameters.AddWithValue("@estado", cmbEstado.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pedido actualizado exitosamente.");
                    LimpiarCamposPedido();
                    LimpiarCamposCliente();
                    HabilitarCamposPedido(false);
                    HabilitarCamposCliente(false);
                    CargarDatosPedidos();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el pedido: " + ex.Message);
                }
            }
        }

        private void HabilitarCamposPedido(bool habilitar)
        {
            cmbTipoPedido.Enabled = habilitar;
            txtNoFactura.Enabled = habilitar;
            dtpFechaSolicitud.Enabled = habilitar;
            txtCantidad.Enabled = habilitar;
            txtMonto.Enabled = habilitar;
            txtEmpresa.Enabled = habilitar;
            txtEnvio.Enabled = habilitar;
            cmbEstado.Enabled = habilitar;
            btnActualizarPedido.Enabled = habilitar;
        }

        private void HabilitarCamposCliente(bool habilitar)
        {
            txtNombreCliente.Enabled = habilitar;
            txtApellidoCliente.Enabled = habilitar;
            txtCorreoCliente.Enabled = habilitar;
            txtTelefonoCliente.Enabled = habilitar;
            txtDireccionCliente.Enabled = habilitar;
            cmbGeneroCliente.Enabled = habilitar;
            txtDPICliente.Enabled = habilitar;
            txtCalificacionCliente.Enabled = habilitar;
        }

        private void LimpiarCamposPedido()
        {
            cmbTipoPedido.SelectedIndex = -1;
            txtNoFactura.Clear();
            dtpFechaSolicitud.Value = DateTime.Now;
            txtCantidad.Clear();
            txtMonto.Clear();
            txtEmpresa.Clear();
            txtEnvio.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private void LimpiarCamposCliente()
        {
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            txtCorreoCliente.Clear();
            txtTelefonoCliente.Clear();
            txtDireccionCliente.Clear();
            cmbGeneroCliente.SelectedIndex = -1;
            txtDPICliente.Clear();
            txtCalificacionCliente.Clear();
        }
        private void cmbTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void frmGestionPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}