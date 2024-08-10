// Form hecho por Jorge Enrique Ávila || 0901-21-1280
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;  // Importar el espacio de nombres ClosedXML

namespace AdminRepartoApp
{
    public partial class frmReportesPersonal : Form
    {
        public frmReportesPersonal()
        {
            InitializeComponent();
            HabilitarCampos(false);
        }

        private void frmReportesPersonal_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    CargarComboboxEmpleados(connection);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void CargarComboboxEmpleados(MySqlConnection connection)
        {
            string query = "SELECT Correo_Personal FROM Datos_Personales WHERE ID_Empleado IS NOT NULL";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            cmbBuscarEmpleado.Items.Clear();
            while (reader.Read())
            {
                cmbBuscarEmpleado.Items.Add(reader["Correo_Personal"].ToString());
            }
            reader.Close();

            if (cmbBuscarEmpleado.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron empleados en la base de datos.");
            }
        }

        private void cmbBuscarEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarEmpleado.SelectedItem == null)
                return;

            string correo = cmbBuscarEmpleado.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.Nombres, dp.Apellidos, dp.Genero, dp.Direccion_Personal, dp.Correo_Personal, dp.DPI, dp.Telefono,
                               e.Tipo_Empleado, e.Horario, e.Permitir_Editar, e.Permitir_Eliminar, e.Permitir_Añadir_Usuario, e.Estado
                        FROM Datos_Personales dp
                        INNER JOIN Empleado e ON dp.ID_Empleado = e.ID_Empleado
                        WHERE dp.Correo_Personal = @correo";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["Nombres"].ToString();
                        txtApellido.Text = reader["Apellidos"].ToString();
                        cmbGenero.SelectedItem = reader["Genero"].ToString();
                        txtDireccion.Text = reader["Direccion_Personal"].ToString();
                        txtCorreo.Text = reader["Correo_Personal"].ToString();
                        txtDPI.Text = reader["DPI"].ToString();
                        txtTelefono.Text = reader["Telefono"].ToString();
                        cmbTipoEmpleado.SelectedItem = reader["Tipo_Empleado"].ToString();
                        txtHorario.Text = reader["Horario"].ToString();
                        chkPermitirEditar.Checked = reader["Permitir_Editar"].ToString() == "V";
                        chkPermitirEliminar.Checked = reader["Permitir_Eliminar"].ToString() == "V";
                        chkPermitirAñadir.Checked = reader["Permitir_Añadir_Usuario"].ToString() == "V";
                        cmbEstado.SelectedItem = reader["Estado"].ToString();

                        HabilitarCampos(true);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtApellido.Enabled = habilitar;
            cmbGenero.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            txtCorreo.Enabled = habilitar;
            txtDPI.Enabled = habilitar;
            txtTelefono.Enabled = habilitar;
            cmbTipoEmpleado.Enabled = habilitar;
            txtHorario.Enabled = habilitar;
            chkPermitirEditar.Enabled = habilitar;
            chkPermitirEliminar.Enabled = habilitar;
            chkPermitirAñadir.Enabled = habilitar;
            cmbEstado.Enabled = habilitar;
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbGenero.SelectedIndex = -1;
            txtDireccion.Clear();
            txtCorreo.Clear();
            txtDPI.Clear();
            txtTelefono.Clear();
            cmbTipoEmpleado.SelectedIndex = -1;
            txtHorario.Clear();
            chkPermitirEditar.Checked = false;
            chkPermitirEliminar.Checked = false;
            chkPermitirAñadir.Checked = false;
            cmbEstado.SelectedIndex = -1;
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            CargarDatosEmpleados();
        }

        private void CargarDatosEmpleados()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.Nombres, dp.Apellidos, dp.Genero, dp.Direccion_Personal, dp.Correo_Personal, dp.DPI, dp.Telefono,
                               e.Tipo_Empleado, e.Horario, e.Permitir_Editar, e.Permitir_Eliminar, e.Permitir_Añadir_Usuario, e.Estado
                        FROM Datos_Personales dp
                        INNER JOIN Empleado e ON dp.ID_Empleado = e.ID_Empleado";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvEmpleados.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos de empleados: " + ex.Message);
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Guardar reporte de empleados";
                saveFileDialog.FileName = "ReporteEmpleados.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            DataTable dt = (DataTable)dgvEmpleados.DataSource;
                            workbook.Worksheets.Add(dt, "Empleados");
                            workbook.SaveAs(saveFileDialog.FileName);
                        }
                        MessageBox.Show("Datos exportados exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar datos: " + ex.Message);
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
