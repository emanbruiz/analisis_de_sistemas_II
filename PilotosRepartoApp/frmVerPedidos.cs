// Form hecho por Jorge Enrique Ávila || 0901-21-1280
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PilotosRepartoApp
{
    public partial class frmVerPedidos : Form
    {
        private string correoPiloto;

        public frmVerPedidos(string correo)
        {
            InitializeComponent();
            correoPiloto = correo;
            CargarPedidos(); // Cargar los pedidos en el DataGridView
            CargarFacturas(); // Cargar las facturas en el ComboBox
        }

        private void CargarPedidos()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT p.No_Factura, p.Tipo_Pedido, p.Fecha_Solicitud, p.Estado, dp.Direccion_Personal
                        FROM pedido p
                        INNER JOIN datos_personales dp ON p.ID_Persona = dp.ID_Persona
                        WHERE p.ID_Piloto = (SELECT ID_Piloto FROM datos_personales WHERE Correo_Personal = @correo)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correoPiloto);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPedidos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar pedidos: " + ex.Message);
                }
            }
        }

        private void CargarFacturas()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT No_Factura
                        FROM pedido
                        WHERE ID_Piloto = (SELECT ID_Piloto FROM datos_personales WHERE Correo_Personal = @correo)
                        AND Estado != 'Entregado'"; // Filtrar solo los pedidos que no están entregados
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correoPiloto);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    cmbFiltrar.Items.Clear();
                    while (reader.Read())
                    {
                        cmbFiltrar.Items.Add(reader["No_Factura"].ToString());
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar facturas: " + ex.Message);
                }
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cmbFiltrar.SelectedIndex = -1;
            CargarPedidos();
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPedidosPorFactura();
        }

        private void FiltrarPedidosPorFactura()
        {
            if (cmbFiltrar.SelectedItem == null)
                return;

            string facturaFiltro = cmbFiltrar.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT p.No_Factura, p.Tipo_Pedido, p.Fecha_Solicitud, p.Estado, dp.Direccion_Personal
                        FROM pedido p
                        INNER JOIN datos_personales dp ON p.ID_Persona = dp.ID_Persona
                        WHERE p.ID_Piloto = (SELECT ID_Piloto FROM datos_personales WHERE Correo_Personal = @correo)
                        AND p.No_Factura = @factura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correoPiloto);
                    cmd.Parameters.AddWithValue("@factura", facturaFiltro);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPedidos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al filtrar pedidos por factura: " + ex.Message);
                }
            }
        }

        private void btnVerRuta_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedItem != null)
            {
                string noFactura = cmbFiltrar.SelectedItem.ToString();
                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = @"
                SELECT dp.Direccion_Personal
                FROM pedido p
                INNER JOIN datos_personales dp ON p.ID_Persona = dp.ID_Persona
                WHERE p.No_Factura = @noFactura";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@noFactura", noFactura);

                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            string direccion = reader["Direccion_Personal"].ToString();
                            frmVerRutas verRutasForm = new frmVerRutas(correoPiloto, direccion, noFactura);
                            verRutasForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la dirección para el pedido seleccionado.");
                        }
                        reader.Close();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al obtener la dirección: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un número de factura para ver la ruta.");
            }
        }



    }
}
