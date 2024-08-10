// Form hecho por Maty Lourdes Mancilla García || 0901-21-2128
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientesRepartoApp
{
    public partial class frmVerPedidos : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
        private int idPersona;

        public frmVerPedidos(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
        }

        private void frmVerPedidos_Load(object sender, EventArgs e)
        {
            try
            {
                CargarEstadoPedidos();
                CargarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos iniciales: " + ex.Message);
            }
        }

        private void CargarEstadoPedidos()
        {
            try
            {
                cmbEstadoPedidos.Items.AddRange(new object[] { "En Tránsito", "Entregado", "Retrasado", "Cancelado", "Pendiente" });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar estados de pedidos: " + ex.Message);
            }
        }

        private void CargarFacturas()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT No_Factura FROM pedido WHERE ID_Persona = @idPersona AND Estado = 'Entregado'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbFactura.Items.Clear();
                    while (reader.Read())
                    {
                        cmbFactura.Items.Add(reader["No_Factura"].ToString());
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar facturas desde la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al cargar facturas: " + ex.Message);
                }
            }
        }

        private void cmbEstadoPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string estadoSeleccionado = cmbEstadoPedidos.SelectedItem.ToString();
                CargarPedidosPorEstado(estadoSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar pedidos por estado: " + ex.Message);
            }
        }

        private void CargarPedidosPorEstado(string estado)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            p.No_Factura AS 'Número de Factura',
                            p.Fecha_Solicitud AS 'Fecha solicitado',
                            p.Cantidad,
                            p.Monto,
                            p.Estado,
                            p.Envio AS 'Empresa',
                            p.ID_Piloto AS 'ID del piloto',
                            dp.Nombres AS 'Nombre del piloto',
                            dp.Telefono AS 'Teléfono para comunicarse'
                        FROM PEDIDO p
                        INNER JOIN datos_personales dp ON dp.ID_Piloto = p.ID_Piloto
                        WHERE p.Estado = @estado AND p.ID_Persona = @idPersona";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@idPersona", idPersona);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPedidos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar pedidos por estado desde la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al cargar pedidos por estado: " + ex.Message);
                }
            }
        }

        private void cmbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbFactura.SelectedItem == null) return;

                string noFactura = cmbFactura.SelectedItem.ToString();
                CargarDetallesPedido(noFactura);
                CargarDetallesPilotoPorFactura(noFactura);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la factura seleccionada: " + ex.Message);
            }
        }

        private void CargarDetallesPedido(string noFactura)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT
                            p.No_Factura AS 'Número de Factura',
                            p.Fecha_Solicitud AS 'Fecha solicitado',
                            p.Cantidad,
                            p.Monto,
                            p.Estado,
                            p.Envio AS 'Empresa',
                            p.TipoPago_Pedido,
                            p.ID_Piloto AS 'ID del piloto',
                            dp.Nombres AS 'Nombre del piloto'
                        FROM PEDIDO p
                        INNER JOIN datos_personales dp ON dp.ID_Piloto = p.ID_Piloto
                        WHERE p.No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvPedidos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar detalles del pedido desde la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al cargar detalles del pedido: " + ex.Message);
                }
            }
        }

        private void CargarDetallesPilotoPorFactura(string noFactura)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.ID_Piloto, dp.Nombres
                        FROM pedido p
                        JOIN datos_personales dp ON p.ID_Piloto = dp.ID_Piloto
                        WHERE p.No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtIDPiloto.Text = reader["ID_Piloto"].ToString();
                        txtNombrePiloto.Text = reader["Nombres"].ToString();
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar detalles del piloto desde la base de datos: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado al cargar detalles del piloto: " + ex.Message);
                }
            }
        }

        private void btnAumentarCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                int calificacion = int.TryParse(txtCalificacion.Text, out calificacion) ? calificacion : 0;
                if (calificacion < 5)
                {
                    calificacion++;
                    txtCalificacion.Text = calificacion.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aumentar la calificación: " + ex.Message);
            }
        }

        private void btnDisminuirCalificacion_Click(object sender, EventArgs e)
        {
            try
            {
                int calificacion = int.TryParse(txtCalificacion.Text, out calificacion) ? calificacion : 0;
                if (calificacion > 0)
                {
                    calificacion--;
                    txtCalificacion.Text = calificacion.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al disminuir la calificación: " + ex.Message);
            }
        }

        private void btnCalificarPiloto_Click_1 (object sender, EventArgs e)
        {
            if (cmbFactura.SelectedItem == null || string.IsNullOrEmpty(txtCalificacion.Text))
            {
                MessageBox.Show("Por favor, seleccione una factura e ingrese la calificación.");
                return;
            }

            try
            {
                string noFactura = cmbFactura.SelectedItem.ToString();
                decimal calificacionPiloto = decimal.Parse(txtCalificacion.Text);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Actualizar la calificación del piloto en la tabla pedido
                    string queryCalificarPiloto = @"
                        UPDATE pedido
                        SET Calificacion_Piloto = @calificacionPiloto
                        WHERE No_Factura = @noFactura";
                    MySqlCommand cmdCalificarPiloto = new MySqlCommand(queryCalificarPiloto, connection);
                    cmdCalificarPiloto.Parameters.AddWithValue("@calificacionPiloto", calificacionPiloto);
                    cmdCalificarPiloto.Parameters.AddWithValue("@noFactura", noFactura);
                    cmdCalificarPiloto.ExecuteNonQuery();

                    MessageBox.Show("Calificación registrada exitosamente.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al registrar la calificación en la base de datos: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado al registrar la calificación: " + ex.Message);
            }
        }
    }
}
