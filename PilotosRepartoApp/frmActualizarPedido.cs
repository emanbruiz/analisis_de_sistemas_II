// Form hecho por Alfonso Emanuel Barahona Ruiz || 0901-21-4035
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace PilotosRepartoApp
{
    public partial class frmActualizarPedido : Form
    {
        private string correoPiloto;

        public frmActualizarPedido(string correoPiloto)
        {
            InitializeComponent();
            this.correoPiloto = correoPiloto;
            CargarFacturas();
            // Deshabilitar botones inicialmente
            btnMarcarEntregado.Enabled = false;
            btnRetrasado.Enabled = false;
            btnLimpiarFiltro.Enabled = false;
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
                        AND Estado != 'Entregado'";
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

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPedido();
            // Habilitar botones cuando se selecciona una factura
            btnMarcarEntregado.Enabled = cmbFiltrar.SelectedItem != null;
            btnRetrasado.Enabled = cmbFiltrar.SelectedItem != null;
            btnLimpiarFiltro.Enabled = cmbFiltrar.SelectedItem != null;
        }

        private void FiltrarPedido()
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
                        SELECT p.No_Factura, p.Tipo_Pedido, p.Fecha_Solicitud, p.Estado, p.Calificacion_Cliente, dp.Direccion_Personal
                        FROM pedido p
                        INNER JOIN datos_personales dp ON p.ID_Persona = dp.ID_Persona
                        WHERE p.No_Factura = @factura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@factura", facturaFiltro);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPedidos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al filtrar pedidos: " + ex.Message);
                }
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            cmbFiltrar.SelectedIndex = -1;
            dgvPedidos.DataSource = null;
            // Deshabilitar botones después de limpiar el filtro
            btnMarcarEntregado.Enabled = false;
            btnRetrasado.Enabled = false;
            btnLimpiarFiltro.Enabled = false;
        }

        private void btnMarcarEntregado_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una factura para marcar como entregada.");
                return;
            }

            string noFactura = cmbFiltrar.SelectedItem.ToString();
            string input = Interaction.InputBox("Califique al cliente (0 a 5):", "Calificación");

            try
            {
                int calificacion = int.Parse(input);

                if (calificacion < 0 || calificacion > 5)
                {
                    MessageBox.Show("La calificación debe estar entre 0 y 5.");
                    return;
                }

                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        UPDATE pedido
                        SET Estado = 'Entregado', Calificacion_Cliente = @calificacion
                        WHERE No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@calificacion", calificacion);
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pedido marcado como entregado y calificación registrada.");
                RecargarFormulario(); // Recargar formulario después de la actualización
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número entero válido para la calificación.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar el pedido: " + ex.Message);
            }
        }

        private void btnRetrasado_Click(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una factura para marcar como retrasada.");
                return;
            }

            string noFactura = cmbFiltrar.SelectedItem.ToString();

            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        UPDATE pedido
                        SET Estado = 'Retrasado'
                        WHERE No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pedido marcado como retrasado.");
                    RecargarFormulario(); // Recargar formulario después de la actualización
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el estado del pedido: " + ex.Message);
                }
            }
        }

        private void RecargarFormulario()
        {
            // Cierra y vuelve a abrir el formulario para recargar los datos
            this.Hide();
            frmActualizarPedido nuevoFormulario = new frmActualizarPedido(correoPiloto);
            nuevoFormulario.Show();
            this.Close();
        }
    }
}
