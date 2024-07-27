using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace AdminRepartoApp
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
            pbImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage; // Escalar imagen en PictureBox
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // Cargar datos iniciales si es necesario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Manejar eventos si es necesario
        }

        private void txtDetalleProducto_TextChanged(object sender, EventArgs e)
        {
            // Manejar eventos si es necesario
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pbImagenProducto.Image = Image.FromFile(imagePath);
                txtImagenPath.Text = imagePath; // Asumiendo que tienes un TextBox oculto para almacenar la ruta de la imagen
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    byte[] imageBytes = null;
                    if (!string.IsNullOrEmpty(txtImagenPath.Text))
                    {
                        imageBytes = File.ReadAllBytes(txtImagenPath.Text);
                    }

                    // Insertar el producto
                    string query = @"INSERT INTO Producto (Nombre_Producto, Detalle_Producto, Precio_Producto, Imagen_Producto, Pais_Fabricante, IVA, Comentarios_Producto, Stock, Marca, Pais_Marca, Contacto_Marca, Tipo_UM, Nombre_Presentacion, Descripcion_Presentacion)
                                     VALUES (@nombre, @detalle, @precio, @imagen, @pais, @iva, @comentarios, @stock, @marca, @paisMarca, @contactoMarca, @tipoUM, @nombrePresentacion, @descripcionPresentacion)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@detalle", txtDetalleProducto.Text);
                    cmd.Parameters.AddWithValue("@precio", Convert.ToDecimal(txtPrecioProducto.Text));
                    cmd.Parameters.AddWithValue("@imagen", imageBytes);
                    cmd.Parameters.AddWithValue("@pais", txtPaisFabricante.Text);
                    cmd.Parameters.AddWithValue("@iva", Convert.ToDecimal(txtIVA.Text));
                    cmd.Parameters.AddWithValue("@comentarios", txtComentariosProducto.Text);
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(txtStock.Text));
                    cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                    cmd.Parameters.AddWithValue("@paisMarca", txtPaisMarca.Text);
                    cmd.Parameters.AddWithValue("@contactoMarca", txtContactoMarca.Text);
                    cmd.Parameters.AddWithValue("@tipoUM", cmbTipoUM.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@nombrePresentacion", txtNombrePresentacion.Text);
                    cmd.Parameters.AddWithValue("@descripcionPresentacion", txtDescripcionPresentacion.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Producto guardado exitosamente.");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar el producto: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error: " + ex.Message);
                }
            }
        }
    }
}
