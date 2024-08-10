// Form hecho por Jorge Enrique Ávila || 0901-21-1280
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace AdminRepartoApp
{
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            CargarLogs();
            CargarEmpleados();
        }

        private void CargarLogs()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM LogActividades";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvLogs.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void CargarEmpleados()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT DISTINCT ID_Empleado FROM LogActividades WHERE ID_Empleado IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    cmbFiltrarEmpleado.Items.Clear();
                    cmbFiltrarEmpleado.Items.Add("Todos");
                    while (reader.Read())
                    {
                        cmbFiltrarEmpleado.Items.Add(reader["ID_Empleado"].ToString());
                    }
                    reader.Close();
                    cmbFiltrarEmpleado.SelectedIndex = 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnAplicarFiltro_Click_1(object sender, EventArgs e)
        {
            string filtro = cmbFiltrarEmpleado.SelectedItem.ToString();
            if (filtro == "Todos")
            {
                CargarLogs();
            }
            else
            {
                FiltrarLogsPorEmpleado(int.Parse(filtro));
            }
        }

        private void FiltrarLogsPorEmpleado(int idEmpleado)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM LogActividades WHERE ID_Empleado = @idEmpleado";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvLogs.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnLimpiarFiltro_Click_1(object sender, EventArgs e)
        {
            cmbFiltrarEmpleado.SelectedIndex = 0;
            CargarLogs();
        }

        private void btnExportarLogs_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar logs como CSV";
            saveFileDialog.FileName = "logs.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        // Escribir encabezados de columna
                        for (int i = 0; i < dgvLogs.Columns.Count; i++)
                        {
                            writer.Write(dgvLogs.Columns[i].HeaderText);
                            if (i < dgvLogs.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();

                        // Escribir filas de datos
                        for (int i = 0; i < dgvLogs.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvLogs.Columns.Count; j++)
                            {
                                writer.Write(dgvLogs.Rows[i].Cells[j].Value);
                                if (j < dgvLogs.Columns.Count - 1)
                                {
                                    writer.Write(",");
                                }
                            }
                            writer.WriteLine();
                        }
                    }
                    MessageBox.Show("Logs exportados exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar logs: " + ex.Message);
                }
            }
        }
    }
}
