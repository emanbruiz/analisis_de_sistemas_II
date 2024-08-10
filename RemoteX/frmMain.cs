using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RemoteX
{
    public partial class frmMain : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=remotex_db;Uid=root;Pwd=161101;";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadRecentConnections();
            // Inicializar cualquier configuración adicional
        }

        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            string remoteIP = txtRemoteIP.Text;

            if (string.IsNullOrEmpty(remoteIP))
            {
                MessageBox.Show("Please enter a valid IP address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblStatus.Text = "Status: Connecting to " + remoteIP;
            ConnectToRemote(remoteIP);
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        private void ConnectToRemote(string remoteIP)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO connections (user_id, remote_ip, start_time, status) VALUES (@userId, @remoteIP, NOW(), 'connected')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", 1); // Ajusta esto según el ID del usuario actual
                cmd.Parameters.AddWithValue("@remoteIP", remoteIP);

                try
                {
                    cmd.ExecuteNonQuery();
                    lstRecentConnections.Items.Add(remoteIP + " - " + DateTime.Now.ToString("g"));
                    lblStatus.Text = "Status: Connected to " + remoteIP;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadRecentConnections()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT remote_ip, start_time FROM connections ORDER BY start_time DESC LIMIT 10";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string connection = reader["remote_ip"].ToString() + " - " + Convert.ToDateTime(reader["start_time"]).ToString("g");
                    lstRecentConnections.Items.Add(connection);
                }
            }
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSettings settingsForm = new frmSettings();
            settingsForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAbout aboutForm = new frmAbout();
            aboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenConnection_Click(object sender, EventArgs e)
        {
            // Abre el formulario de conexión frmConnection
            frmConnection connectionForm = new frmConnection();
            connectionForm.ShowDialog(); // Abre frmConnection como un modal
        }
    }
}
