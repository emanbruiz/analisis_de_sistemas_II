using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClientesRepartoApp
{
    public partial class frmRealizarPedidos : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
        private int idPersona;

        public frmRealizarPedidos(int idPersona)
        {
            InitializeComponent();
            this.idPersona = idPersona;
            pbImagenProducto.BackgroundImageLayout = ImageLayout.Stretch; // Siempre stretch
        }

        private void frmRealizarPedidos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID_Producto, Nombre_Producto FROM producto";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbProductos.Items.Add(new ComboBoxItem(reader["ID_Producto"].ToString(), reader["Nombre_Producto"].ToString()));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar productos: " + ex.Message);
                }
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null) return;

            ComboBoxItem selectedItem = (ComboBoxItem)cmbProductos.SelectedItem;
            int idProducto = int.Parse(selectedItem.Value);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Precio_Producto, IVA, Stock, Descripcion_Presentacion, Imagen_Producto FROM producto WHERE ID_Producto = @idProducto";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal precio = reader.GetDecimal("Precio_Producto");
                        decimal iva = reader.GetDecimal("IVA");
                        int stock = reader.GetInt32("Stock");
                        string descripcion = reader.GetString("Descripcion_Presentacion");
                        byte[] imagen = reader["Imagen_Producto"] as byte[];

                        lblPrecioProducto.Text = $"Precio: {precio} + IVA: {iva} = {precio + iva}";
                        lblStock.Text = $"Stock: {stock}";
                        txtDescripcion.Text = descripcion;

                        if (imagen != null)
                        {
                            using (var ms = new System.IO.MemoryStream(imagen))
                            {
                                pbImagenProducto.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pbImagenProducto.Image = null;
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar detalles del producto: " + ex.Message);
                }
            }
        }

        private void btnAumentarCantidad_Click(object sender, EventArgs e)
        {
            int cantidad = int.TryParse(txtCantidad.Text, out cantidad) ? cantidad : 0;
            int stock = int.TryParse(lblStock.Text.Replace("Stock: ", ""), out stock) ? stock : 0;

            if (cantidad < stock)
            {
                cantidad++;
                txtCantidad.Text = cantidad.ToString();
            }
        }

        private void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            int cantidad = int.TryParse(txtCantidad.Text, out cantidad) ? cantidad : 0;

            if (cantidad > 0)
            {
                cantidad--;
                txtCantidad.Text = cantidad.ToString();
            }
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            if (cmbProductos.SelectedItem == null || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto y ingrese la cantidad.");
                return;
            }

            if (!rbtnPagoContraEntrega.Checked && !rbtnTarjeta.Checked)
            {
                MessageBox.Show("Por favor, seleccione un método de pago.");
                return;
            }

            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                ComboBoxItem selectedItem = (ComboBoxItem)cmbProductos.SelectedItem;
                int idProducto = int.Parse(selectedItem.Value);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener el precio y IVA del producto
                    string queryProducto = "SELECT Precio_Producto, IVA FROM producto WHERE ID_Producto = @idProducto";
                    MySqlCommand cmdProducto = new MySqlCommand(queryProducto, connection);
                    cmdProducto.Parameters.AddWithValue("@idProducto", idProducto);
                    MySqlDataReader reader = cmdProducto.ExecuteReader();

                    decimal precio = 0, iva = 0;
                    if (reader.Read())
                    {
                        precio = reader.GetDecimal("Precio_Producto");
                        iva = reader.GetDecimal("IVA");
                    }
                    reader.Close();

                    decimal total = cantidad * (precio + iva);

                    // Insertar en la tabla detalle
                    string queryDetalle = "INSERT INTO detalle (Cantidad, Precio_U, Total) VALUES (@cantidad, @precioU, @total); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdDetalle = new MySqlCommand(queryDetalle, connection);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdDetalle.Parameters.AddWithValue("@precioU", precio);
                    cmdDetalle.Parameters.AddWithValue("@total", total);
                    int idDetalle = Convert.ToInt32(cmdDetalle.ExecuteScalar());

                    // Generar número de factura
                    string noFactura;
                    do
                    {
                        noFactura = GenerarHexadecimal(10);
                    } while (ExisteNoFactura(connection, noFactura));

                    // Insertar en la tabla pedido
                    string[] empresas = { "DHL", "FedEx", "UPS" };
                    Random rand = new Random();
                    string empresa = empresas[rand.Next(empresas.Length)];

                    string queryPedido = @"
                        INSERT INTO pedido (Tipo_Pedido, No_Factura, Fecha_Solicitud, Cantidad, Monto, Empresa, Envio, ID_Persona, Estado, ID_Detalle, TipoPago_Pedido)
                        VALUES ('Normal', @noFactura, NOW(), @cantidad, @monto, @empresa, '1-3 días hábiles', @idPersona, 'Pendiente', @idDetalle, @tipoPago)";
                    MySqlCommand cmdPedido = new MySqlCommand(queryPedido, connection);
                    cmdPedido.Parameters.AddWithValue("@noFactura", noFactura);
                    cmdPedido.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdPedido.Parameters.AddWithValue("@monto", total);
                    cmdPedido.Parameters.AddWithValue("@empresa", empresa);
                    cmdPedido.Parameters.AddWithValue("@idPersona", idPersona);
                    cmdPedido.Parameters.AddWithValue("@idDetalle", idDetalle);
                    cmdPedido.Parameters.AddWithValue("@tipoPago", rbtnPagoContraEntrega.Checked ? "Contra Entrega" : "Tarjeta POS");
                    cmdPedido.ExecuteNonQuery();

                    // Obtener ID_Pedido
                    int idPedido = Convert.ToInt32(cmdPedido.LastInsertedId);

                    // Actualizar ID_Pedido en la tabla detalle
                    string queryActualizarDetalle = "UPDATE detalle SET ID_Pedido = @idPedido WHERE ID_Detalle = @idDetalle";
                    MySqlCommand cmdActualizarDetalle = new MySqlCommand(queryActualizarDetalle, connection);
                    cmdActualizarDetalle.Parameters.AddWithValue("@idPedido", idPedido);
                    cmdActualizarDetalle.Parameters.AddWithValue("@idDetalle", idDetalle);
                    cmdActualizarDetalle.ExecuteNonQuery();

                    // Actualizar el stock del producto
                    string queryActualizarStock = "UPDATE producto SET Stock = Stock - @cantidad WHERE ID_Producto = @idProducto";
                    MySqlCommand cmdActualizarStock = new MySqlCommand(queryActualizarStock, connection);
                    cmdActualizarStock.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdActualizarStock.Parameters.AddWithValue("@idProducto", idProducto);
                    cmdActualizarStock.ExecuteNonQuery();

                    MessageBox.Show("Pedido realizado exitosamente.");
                    // Recargar la ventana
                    frmRealizarPedidos_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar el pedido: " + ex.Message);
            }
        }

        private string GenerarHexadecimal(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEF0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private bool ExisteNoFactura(MySqlConnection connection, string noFactura)
        {
            string query = "SELECT COUNT(*) FROM pedido WHERE No_Factura = @noFactura";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@noFactura", noFactura);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }
    }

    public class ComboBoxItem
    {
        public string Value { get; set; }
        public string Text { get; set; }

        public ComboBoxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
