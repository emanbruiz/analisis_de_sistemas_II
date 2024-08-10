// Form hecho por Alfonso Emanuel Barahona Ruiz || 0901-21-4035
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace AdminRepartoApp
{
    public partial class frmBodegasTransportes : Form
    {
        public frmBodegasTransportes()
        {
            InitializeComponent();
            CargarComboboxValores();
            CargarComboboxPedidosNoAsignados();
            CargarComboboxPilotos();
            CargarComboboxProductos();
            CargarPedidosNoAsignados();
        }

        private void CargarComboboxValores()
        {
            cmbEstadoEnvio.Items.AddRange(new object[] { "En Tránsito", "Entregado", "Retrasado", "Cancelado", "Pendiente" });
        }

        private void CargarComboboxPedidosNoAsignados()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT No_Factura FROM Pedido WHERE ID_Piloto IS NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbBuscarPedidoNoAsignado.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBuscarPedidoNoAsignado.Items.Add(reader["No_Factura"].ToString());
                    }
                    reader.Close();

                    if (cmbBuscarPedidoNoAsignado.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron pedidos sin asignar.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void CargarComboboxPilotos()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID_Piloto, Correo_Personal FROM Datos_Personales WHERE ID_Piloto IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbBuscarPiloto.Items.Clear();
                    while (reader.Read())
                    {
                        cmbBuscarPiloto.Items.Add(new ComboBoxItem(reader["ID_Piloto"].ToString(), reader["Correo_Personal"].ToString()));
                    }
                    reader.Close();

                    if (cmbBuscarPiloto.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron pilotos en la base de datos.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void CargarComboboxProductos()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ID_Producto, Nombre_Producto FROM Producto";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbProductoOrden.Items.Clear();
                    while (reader.Read())
                    {
                        cmbProductoOrden.Items.Add(new ComboBoxItem(reader["ID_Producto"].ToString(), reader["Nombre_Producto"].ToString()));
                    }
                    reader.Close();

                    if (cmbProductoOrden.Items.Count == 0)
                    {
                        MessageBox.Show("No se encontraron productos en la base de datos.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private class ComboBoxItem
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

        private void CargarPedidosNoAsignados()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            P.No_Factura AS 'Número de Factura',
                            DP.Nombres,
                            DP.Apellidos,
                            DP.Direccion_Personal AS 'Dirección de entrega',
                            P.Estado,
                            P.Fecha_Solicitud AS 'Fecha de la solicitud',
                            P.Cantidad,
                            P.Monto,
                            P.Envio
                        FROM PEDIDO P
                        INNER JOIN DATOS_PERSONALES DP ON P.ID_PERSONA = DP.ID_PERSONA
                        WHERE DP.ID_PILOTO IS NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvPedidos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar pedidos no asignados: " + ex.Message);
                }
            }
        }

        private void cmbBuscarPedidoNoAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarPedidoNoAsignado.SelectedItem == null)
                return;

            string noFactura = cmbBuscarPedidoNoAsignado.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT p.Fecha_Solicitud, p.Cantidad, p.Monto, p.Envio, p.ID_Persona,
                               dp.Nombres AS ClienteNombres, dp.Apellidos AS ClienteApellidos, dp.Direccion_Personal AS ClienteDireccion, dp.Correo_Personal AS ClienteCorreo
                        FROM Pedido p
                        LEFT JOIN datos_personales dp ON p.ID_Persona = dp.ID_Persona
                        WHERE p.No_Factura = @noFactura";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@noFactura", noFactura);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Datos del Pedido
                        dtpFechaSolicitud.Value = Convert.ToDateTime(reader["Fecha_Solicitud"]);
                        txtCantidad.Text = reader["Cantidad"].ToString();
                        txtMonto.Text = reader["Monto"].ToString();
                        txtEnvio.Text = reader["Envio"].ToString();

                        // Datos del Cliente
                        txtNombreCliente.Text = reader["ClienteNombres"].ToString();
                        txtApellidosCliente.Text = reader["ClienteApellidos"].ToString();
                        txtDireccionCliente.Text = reader["ClienteDireccion"].ToString();
                        txtCorreoCliente.Text = reader["ClienteCorreo"].ToString();

                        // Asignar Dirección de Entrega igual a Dirección del Cliente si está vacía
                        if (string.IsNullOrEmpty(txtDireccionEntrega.Text))
                        {
                            txtDireccionEntrega.Text = reader["ClienteDireccion"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para el pedido seleccionado.");
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos del pedido: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
        }

        private void btnGuardarEnvio_Click(object sender, EventArgs e)
        {
            if (cmbBuscarPedidoNoAsignado.SelectedItem == null || cmbBuscarPiloto.SelectedItem == null || string.IsNullOrEmpty(txtDireccionEntrega.Text) || string.IsNullOrEmpty(txtDireccionRecoleccion.Text) || cmbEstadoEnvio.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos del envío y seleccione un piloto.");
                return;
            }

            string noFactura = cmbBuscarPedidoNoAsignado.SelectedItem.ToString();
            ComboBoxItem selectedPiloto = (ComboBoxItem)cmbBuscarPiloto.SelectedItem;
            string idPiloto = selectedPiloto.Value;
            string direccionEntrega = txtDireccionEntrega.Text;
            string direccionRecoleccion = txtDireccionRecoleccion.Text;
            string estadoEnvio = cmbEstadoEnvio.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Asignar el piloto al pedido
                    string queryPedido = "UPDATE Pedido SET ID_Piloto = @idPiloto, Estado = @estado WHERE No_Factura = @noFactura";
                    MySqlCommand cmdPedido = new MySqlCommand(queryPedido, connection);
                    cmdPedido.Parameters.AddWithValue("@idPiloto", idPiloto);
                    cmdPedido.Parameters.AddWithValue("@noFactura", noFactura);
                    cmdPedido.Parameters.AddWithValue("@estado", estadoEnvio);

                    cmdPedido.ExecuteNonQuery();

                    // Insertar el envío
                    string queryEnvio = @"
                        INSERT INTO Envio (ID_Pedido, Direccion_Entrega, Direccion_Recolecta, Estado_Envio)
                        VALUES ((SELECT ID_Pedido FROM Pedido WHERE No_Factura = @noFactura), @direccionEntrega, @direccionRecoleccion, @estadoEnvio)";
                    MySqlCommand cmdEnvio = new MySqlCommand(queryEnvio, connection);
                    cmdEnvio.Parameters.AddWithValue("@noFactura", noFactura);
                    cmdEnvio.Parameters.AddWithValue("@direccionEntrega", direccionEntrega);
                    cmdEnvio.Parameters.AddWithValue("@direccionRecoleccion", direccionRecoleccion);
                    cmdEnvio.Parameters.AddWithValue("@estadoEnvio", estadoEnvio);

                    cmdEnvio.ExecuteNonQuery();
                    MessageBox.Show("Pedido asignado y envío guardado exitosamente.");
                    CargarComboboxPedidosNoAsignados(); // Recargar los pedidos sin asignar
                    CargarPedidosNoAsignados(); // Recargar el DataGridView
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al asignar el pedido o guardar el envío: " + ex.Message);
                }
            }
        }

        private void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            if (cmbProductoOrden.SelectedItem == null || string.IsNullOrEmpty(txtCantidadOrden.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto y la cantidad.");
                return;
            }

            ComboBoxItem selectedItem = (ComboBoxItem)cmbProductoOrden.SelectedItem;
            string idProducto = selectedItem.Value;
            int cantidad = int.Parse(txtCantidadOrden.Text);
            decimal monto = decimal.Parse(txtMonto.Text);
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar la orden de compra
                    string queryOrden = @"
                        INSERT INTO Orden_Compra (ID_Producto, Cantidad, Fecha, Monto)
                        VALUES (@idProducto, @cantidad, NOW(), @monto)";
                    MySqlCommand cmd = new MySqlCommand(queryOrden, connection);
                    cmd.Parameters.AddWithValue("@idProducto", idProducto);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@monto", monto);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Orden de compra generada exitosamente.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al generar la orden de compra: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmBodegasTransportes_Load(object sender, EventArgs e)
        {

        }
    }
}
