//Form hecho por Maty Lourdes Mancilla García || 0901-21-2128
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Text.RegularExpressions;

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
            if (!ValidarCampos()) // Validar campos antes de proceder
            {
                return;
            }

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

                    // Cerrar el formulario después de guardar
                    this.Close();
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

        private bool ValidarCampos()
        {
            try
            {
                // Validar que los campos de texto no estén vacíos
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtDetalleProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPrecioProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtPaisFabricante.Text) ||
                    string.IsNullOrWhiteSpace(txtIVA.Text) ||
                    string.IsNullOrWhiteSpace(txtComentariosProducto.Text) ||
                    string.IsNullOrWhiteSpace(txtStock.Text) ||
                    string.IsNullOrWhiteSpace(txtMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtPaisMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtContactoMarca.Text) ||
                    string.IsNullOrWhiteSpace(txtNombrePresentacion.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcionPresentacion.Text) ||
                    cmbTipoUM.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return false;
                }

                // Validar que el precio y el IVA sean números válidos
                if (!decimal.TryParse(txtPrecioProducto.Text, out decimal precio) || precio < 0)
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                    return false;
                }

                if (!decimal.TryParse(txtIVA.Text, out decimal iva) || iva < 0)
                {
                    MessageBox.Show("Por favor, ingrese un valor de IVA válido.");
                    return false;
                }

                // Validar que el stock sea un número entero
                if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
                {
                    MessageBox.Show("Por favor, ingrese un valor de stock válido.");
                    return false;
                }

                // Validar que el nombre del producto pueda contener letras, números, espacios, tildes y ñ
                if (!Regex.IsMatch(txtNombreProducto.Text, @"^[a-zA-Z0-9ñÑ\sáéíóúÁÉÍÓÚ]+$"))
                {
                    MessageBox.Show("El nombre del producto contiene caracteres no válidos.");
                    return false;
                }

                // Validar que los comentarios puedan contener tildes y ñ
                if (!Regex.IsMatch(txtComentariosProducto.Text, @"^[a-zA-Z0-9ñÑ\sáéíóúÁÉÍÓÚ.,]+$"))
                {
                    MessageBox.Show("Los comentarios contienen caracteres no válidos.");
                    return false;
                }

                // Validar que los contactos de marca no contengan caracteres especiales no deseados
                if (!Regex.IsMatch(txtContactoMarca.Text, @"^[a-zA-Z0-9ñÑ\sáéíóúÁÉÍÓÚ.,@]+$"))
                {
                    MessageBox.Show("Los contactos de marca contienen caracteres no válidos.");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la validación: " + ex.Message);
                return false;
            }
        }
    }
}
