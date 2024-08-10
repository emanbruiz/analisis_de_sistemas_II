using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace RemoteX
{
    public partial class frmConnection : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=remotex_db;Uid=root;Pwd=161101;";
        private bool isConnecting = false; // Bandera para evitar múltiples conexiones simultáneas

        public frmConnection()
        {
            InitializeComponent();
            InitializeProtocolComboBox(); // Inicializar ComboBox con protocolos
        }

        private void InitializeProtocolComboBox()
        {
            cmbProtocol.Items.Add("TCP");
            cmbProtocol.Items.Add("UDP");
            cmbProtocol.SelectedIndex = 0; // TCP por defecto
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (isConnecting)
            {
                MessageBox.Show("Connection is already in progress. Please wait...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string remoteIP = txtRemoteIP.Text.Trim();
            string port = txtPort.Text.Trim();
            string protocol = cmbProtocol.SelectedItem.ToString();

            if (!ValidateInputs(remoteIP, port, out int portNumber))
            {
                return;
            }

            lblStatus.Text = $"Status: Connecting to {remoteIP} on port {port} using {protocol}...";
            lblStatus.ForeColor = System.Drawing.Color.Blue;
            progressBarConnection.Style = ProgressBarStyle.Marquee;

            isConnecting = true;

            try
            {
                await ConnectToRemoteAsync(remoteIP, portNumber, protocol);
            }
            finally
            {
                isConnecting = false;
                progressBarConnection.Style = ProgressBarStyle.Blocks;
            }
        }

        private bool ValidateInputs(string remoteIP, string port, out int portNumber)
        {
            portNumber = 0;
            if (string.IsNullOrEmpty(remoteIP))
            {
                MessageBox.Show("Please enter a valid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(port) || !int.TryParse(port, out portNumber))
            {
                MessageBox.Show("Please enter a valid port number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private async Task ConnectToRemoteAsync(string remoteIP, int port, string protocol)
        {
            try
            {
                await Task.Delay(2000); // Simulación de conexión asíncrona a un servidor remoto

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    await conn.OpenAsync();

                    string query = "INSERT INTO connections (user_id, remote_ip, port, protocol, start_time, status) " +
                                   "VALUES (@userId, @remoteIP, @port, @protocol, NOW(), 'connected')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Aquí se agrega el user_id válido
                    cmd.Parameters.AddWithValue("@userId", 1); // Asegúrate de que este ID existe en la tabla `users`
                    cmd.Parameters.AddWithValue("@remoteIP", remoteIP);
                    cmd.Parameters.AddWithValue("@port", port);
                    cmd.Parameters.AddWithValue("@protocol", protocol);

                    await cmd.ExecuteNonQueryAsync();

                    lblStatus.Text = $"Status: Connected to {remoteIP} on port {port} using {protocol}";
                    lblStatus.ForeColor = System.Drawing.Color.Green;

                    LogConnection(remoteIP, port, protocol, "Connected");
                    MessageBox.Show("Connection established successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException sqlEx)
            {
                HandleConnectionError("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                HandleConnectionError("Unexpected error: " + ex.Message);
            }
        }


        private void HandleConnectionError(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            lblStatus.Text = "Status: Connection failed";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            LogConnection(txtRemoteIP.Text, int.Parse(txtPort.Text), cmbProtocol.SelectedItem.ToString(), "Failed");
        }

        private void LogConnection(string remoteIP, int port, string protocol, string status)
        {
            // Aquí puedes escribir los logs en un archivo, o guardarlos en una tabla de logs en la base de datos
            string logMessage = $"{DateTime.Now}: Connection to {remoteIP} on port {port} using {protocol} - Status: {status}";
            System.IO.File.AppendAllText("connection_logs.txt", logMessage + Environment.NewLine);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (isConnecting)
            {
                MessageBox.Show("Cannot cancel while connecting. Please wait until the process is complete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.Close();
        }
        private void cmbProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
