// Form hecho por Kevin Daniel Santos Castro || 0901-17-2994
using System;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PilotosRepartoApp
{
    public partial class frmVerRutas : Form
    {
        private string correoPiloto;

        public frmVerRutas(string correo, string direccion, string noFactura)
        {
            InitializeComponent();
            correoPiloto = correo;
            txtDireccion.Text = direccion; // Inicializa el TextBox con la dirección proporcionada
            CargarFacturas();
            SeleccionarFactura(noFactura); // Selecciona la factura
            VerificarDireccion(); // Verifica el texto inicial de la dirección
            txtDireccion.TextChanged += TxtDireccion_TextChanged; // Asocia el evento de cambio de texto
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

        public void SeleccionarFactura(string noFactura)
        {
            cmbFiltrar.SelectedItem = noFactura;
            CargarDireccion(noFactura); // Carga la dirección automáticamente
        }

        private void cmbFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltrar.SelectedItem != null)
            {
                string noFactura = cmbFiltrar.SelectedItem.ToString();
                CargarDireccion(noFactura);
            }
        }

        private void CargarDireccion(string noFactura)
        {
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
                        txtDireccion.Text = reader["Direccion_Personal"].ToString();
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar la dirección: " + ex.Message);
                }
            }
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); // Utiliza el método LimpiarCampos para restablecer el formulario
        }

        private void LimpiarCampos()
        {
            cmbFiltrar.SelectedIndex = -1;
            txtDireccion.Clear();
        }

        private void VerificarDireccion()
        {
            // Deshabilita el botón si el texto es "Seleccione un pedido" o está vacío
            btnBuscar.Enabled = !string.IsNullOrWhiteSpace(txtDireccion.Text) && txtDireccion.Text != "Seleccione un pedido";
        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {
            VerificarDireccion();
        }

        // Investigamos en documentación de Google y videos en YouTube en este privavte void de btnBuscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtiene la dirección del TextBox
            string direccion = txtDireccion.Text.Trim();

            // Verifica si la dirección no está vacía
            if (!string.IsNullOrWhiteSpace(direccion))
            {
                // Codifica la dirección para incluirla en una URL
                string direccionCodificada = Uri.EscapeDataString(direccion);
                // Construye la URL para Google Maps con la dirección codificada
                string url = $"https://www.google.com/maps?q={direccionCodificada}&hl=es";

                try
                {
                    // Abre la URL en el navegador predeterminado utilizando ProcessStartInfo
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true // UseShellExecute se utiliza para abrir la URL en el navegador
                    };
                    Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el navegador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una dirección válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
