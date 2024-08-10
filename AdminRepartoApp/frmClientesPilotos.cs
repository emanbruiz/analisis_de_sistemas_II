//Form Hecho por Anika Miscelly Escoto Leon || 0901-21-8122
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AdminRepartoApp
{
    public partial class frmClientesPilotos : Form
    {
        public frmClientesPilotos()
        {
            InitializeComponent();
            HabilitarCamposCliente(false);
            HabilitarCamposPiloto(false);
            DesactivarBotonesIniciales();
        }

        private void DesactivarBotonesIniciales()
        {
            btnVerClientes.Enabled = false;
            btnGuardarCliente.Enabled = false;
            btnCancelarCliente.Enabled = false;

            btnVerPilotos.Enabled = false;
            btnGuardarPiloto.Enabled = false;
            btnCancelarPiloto.Enabled = false;

            btnActualizarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;

            btnActualizarPiloto.Enabled = false;
            btnEliminarPiloto.Enabled = false;
        }

        private void frmClientesPilotos_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    CargarComboboxClientes(connection);
                    CargarComboboxPilotos(connection);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void CargarComboboxClientes(MySqlConnection connection)
        {
            string queryClientes = "SELECT Correo_Personal FROM Datos_Personales WHERE ID_Cliente IS NOT NULL";
            MySqlCommand cmdClientes = new MySqlCommand(queryClientes, connection);
            MySqlDataReader readerClientes = cmdClientes.ExecuteReader();

            cmbBuscarCliente.Items.Clear();
            while (readerClientes.Read())
            {
                cmbBuscarCliente.Items.Add(readerClientes["Correo_Personal"].ToString());
            }
            readerClientes.Close();

            if (cmbBuscarCliente.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes en la base de datos.");
            }
        }

        private void CargarComboboxPilotos(MySqlConnection connection)
        {
            string queryPilotos = "SELECT Correo_Personal FROM Datos_Personales WHERE ID_Piloto IS NOT NULL";
            MySqlCommand cmdPilotos = new MySqlCommand(queryPilotos, connection);
            MySqlDataReader readerPilotos = cmdPilotos.ExecuteReader();

            cmbBuscarPiloto.Items.Clear();
            while (readerPilotos.Read())
            {
                cmbBuscarPiloto.Items.Add(readerPilotos["Correo_Personal"].ToString());
            }
            readerPilotos.Close();

            if (cmbBuscarPiloto.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron pilotos en la base de datos.");
            }
        }

        private void cmbBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuscarCliente.SelectedItem == null)
            {
                HabilitarBotonesCliente(false);
                return;
            }

            string correo = cmbBuscarCliente.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.Nombres, dp.Apellidos, dp.Genero, dp.Direccion_Personal, dp.Correo_Personal, dp.DPI, dp.Telefono, dp.PromedioCalificaciones, dp.Contrasena
                        FROM Datos_Personales dp
                        WHERE dp.Correo_Personal = @correo AND dp.ID_Cliente IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombreCliente.Text = reader["Nombres"].ToString();
                        txtApellidoCliente.Text = reader["Apellidos"].ToString();
                        cmbGeneroCliente.SelectedItem = reader["Genero"].ToString();
                        txtDireccionCliente.Text = reader["Direccion_Personal"].ToString();
                        txtCorreoCliente.Text = reader["Correo_Personal"].ToString();
                        txtDPICliente.Text = reader["DPI"].ToString();
                        txtTelefonoCliente.Text = reader["Telefono"].ToString();
                        txtCalificacionCliente.Text = reader["PromedioCalificaciones"].ToString();
                        txtContrasenaCliente.Text = reader["Contrasena"].ToString();
                        txtConfirmarCliente.Text = reader["Contrasena"].ToString();

                        if (txtContrasenaCliente.Text != txtConfirmarCliente.Text)
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                            HabilitarBotonesCliente(false);
                            return;
                        }

                        HabilitarCamposCliente(true);
                        HabilitarBotonesCliente(true);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void cmbBuscarPiloto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbBuscarPiloto.SelectedItem == null)
            {
                HabilitarBotonesPiloto(false);
                return;
            }

            string correo = cmbBuscarPiloto.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        SELECT dp.Nombres, dp.Apellidos, dp.Genero, dp.Direccion_Personal, dp.Correo_Personal, dp.DPI, dp.Telefono, dp.PromedioCalificaciones, dp.Contrasena
                        FROM Datos_Personales dp
                        WHERE dp.Correo_Personal = @correo AND dp.ID_Piloto IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNombrePiloto.Text = reader["Nombres"].ToString();
                        txtApellidoPiloto.Text = reader["Apellidos"].ToString();
                        cmbGeneroPiloto.SelectedItem = reader["Genero"].ToString();
                        txtDireccionPiloto.Text = reader["Direccion_Personal"].ToString();
                        txtCorreoPiloto.Text = reader["Correo_Personal"].ToString();
                        txtDPIPiloto.Text = reader["DPI"].ToString();
                        txtTelefonoPiloto.Text = reader["Telefono"].ToString();
                        txtCalificacionPiloto.Text = reader["PromedioCalificaciones"].ToString();
                        txtContrasenaPiloto.Text = reader["Contrasena"].ToString();
                        txtConfirmarPiloto.Text = reader["Contrasena"].ToString();

                        if (txtContrasenaPiloto.Text != txtConfirmarPiloto.Text)
                        {
                            MessageBox.Show("Las contraseñas no coinciden.");
                            HabilitarBotonesPiloto(false);
                            return;
                        }

                        HabilitarCamposPiloto(true);
                        HabilitarBotonesPiloto(true);
                    }
                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            HabilitarCamposCliente(true);
            LimpiarCamposCliente();
            btnVerClientes.Enabled = true;
            btnGuardarCliente.Enabled = true;
            btnCancelarCliente.Enabled = true;
            cmbBuscarCliente.Enabled = false;
            btnActualizarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
        }

        private void btnAgregarPiloto_Click(object sender, EventArgs e)
        {
            HabilitarCamposPiloto(true);
            LimpiarCamposPiloto();
            btnVerPilotos.Enabled = true;
            btnGuardarPiloto.Enabled = true;
            btnCancelarPiloto.Enabled = true;
            cmbBuscarPiloto.Enabled = false;
            btnActualizarPiloto.Enabled = false;
            btnEliminarPiloto.Enabled = false;
        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposCliente())
            {
                return;
            }

            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryCliente = "INSERT INTO Cliente() VALUES(); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdCliente = new MySqlCommand(queryCliente, connection);
                    int idCliente = Convert.ToInt32(cmdCliente.ExecuteScalar());

                    string query = @"
                        INSERT INTO Datos_Personales (Nombres, Apellidos, Genero, Direccion_Personal, Correo_Personal, DPI, Telefono, PromedioCalificaciones, Contrasena, ID_Cliente)
                        VALUES (@nombres, @apellidos, @genero, @direccion, @correo, @dpi, @telefono, @calificacion, @contrasena, @idCliente)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombres", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@apellidos", txtApellidoCliente.Text);
                    cmd.Parameters.AddWithValue("@genero", cmbGeneroCliente.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreoCliente.Text);
                    cmd.Parameters.AddWithValue("@dpi", txtDPICliente.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                    cmd.Parameters.AddWithValue("@calificacion", Convert.ToDecimal(txtCalificacionCliente.Text));
                    cmd.Parameters.AddWithValue("@contrasena", txtContrasenaCliente.Text);
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente guardado exitosamente.");
                    LimpiarCamposCliente();
                    HabilitarCamposCliente(false);
                    DesactivarBotonesIniciales();
                    cmbBuscarCliente.Enabled = true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar el cliente: " + ex.Message);
                }
            }
        }

        private void btnGuardarPiloto_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCamposPiloto())
            {
                return;
            }

            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string queryPiloto = "INSERT INTO Piloto() VALUES(); SELECT LAST_INSERT_ID();";
                    MySqlCommand cmdPiloto = new MySqlCommand(queryPiloto, connection);
                    int idPiloto = Convert.ToInt32(cmdPiloto.ExecuteScalar());

                    string query = @"
                        INSERT INTO Datos_Personales (Nombres, Apellidos, Genero, Direccion_Personal, Correo_Personal, DPI, Telefono, PromedioCalificaciones, Contrasena, ID_Piloto)
                        VALUES (@nombres, @apellidos, @genero, @direccion, @correo, @dpi, @telefono, @calificacion, @contrasena, @idPiloto)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombres", txtNombrePiloto.Text);
                    cmd.Parameters.AddWithValue("@apellidos", txtApellidoPiloto.Text);
                    cmd.Parameters.AddWithValue("@genero", cmbGeneroPiloto.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccionPiloto.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreoPiloto.Text);
                    cmd.Parameters.AddWithValue("@dpi", txtDPIPiloto.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoPiloto.Text);
                    cmd.Parameters.AddWithValue("@calificacion", Convert.ToDecimal(txtCalificacionPiloto.Text));
                    cmd.Parameters.AddWithValue("@contrasena", txtContrasenaPiloto.Text);
                    cmd.Parameters.AddWithValue("@idPiloto", idPiloto);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Piloto guardado exitosamente.");
                    LimpiarCamposPiloto();
                    HabilitarCamposPiloto(false);
                    DesactivarBotonesIniciales();
                    cmbBuscarPiloto.Enabled = true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar el piloto: " + ex.Message);
                }
            }
        }

        private void HabilitarCamposCliente(bool habilitar)
        {
            txtNombreCliente.Enabled = habilitar;
            txtApellidoCliente.Enabled = habilitar;
            cmbGeneroCliente.Enabled = habilitar;
            txtDireccionCliente.Enabled = habilitar;
            txtCorreoCliente.Enabled = habilitar;
            txtDPICliente.Enabled = habilitar;
            txtTelefonoCliente.Enabled = habilitar;
            txtCalificacionCliente.Enabled = habilitar;
            txtContrasenaCliente.Enabled = habilitar;
            txtConfirmarCliente.Enabled = habilitar;
        }

        private void HabilitarCamposPiloto(bool habilitar)
        {
            txtNombrePiloto.Enabled = habilitar;
            txtApellidoPiloto.Enabled = habilitar;
            cmbGeneroPiloto.Enabled = habilitar;
            txtDireccionPiloto.Enabled = habilitar;
            txtCorreoPiloto.Enabled = habilitar;
            txtDPIPiloto.Enabled = habilitar;
            txtTelefonoPiloto.Enabled = habilitar;
            txtCalificacionPiloto.Enabled = habilitar;
            txtContrasenaPiloto.Enabled = habilitar;
            txtConfirmarPiloto.Enabled = habilitar;
        }

        private void LimpiarCamposCliente()
        {
            txtNombreCliente.Clear();
            txtApellidoCliente.Clear();
            cmbGeneroCliente.SelectedIndex = -1;
            txtDireccionCliente.Clear();
            txtCorreoCliente.Clear();
            txtDPICliente.Clear();
            txtTelefonoCliente.Clear();
            txtCalificacionCliente.Clear();
            txtContrasenaCliente.Clear();
            txtConfirmarCliente.Clear();
        }

        private void LimpiarCamposPiloto()
        {
            txtNombrePiloto.Clear();
            txtApellidoPiloto.Clear();
            cmbGeneroPiloto.SelectedIndex = -1;
            txtDireccionPiloto.Clear();
            txtCorreoPiloto.Clear();
            txtDPIPiloto.Clear();
            txtTelefonoPiloto.Clear();
            txtCalificacionPiloto.Clear();
            txtContrasenaPiloto.Clear();
            txtConfirmarPiloto.Clear();
        }

        private bool ValidarCamposCliente()
        {
            if (string.IsNullOrEmpty(txtNombreCliente.Text) || string.IsNullOrEmpty(txtApellidoCliente.Text) ||
                cmbGeneroCliente.SelectedItem == null || string.IsNullOrEmpty(txtDireccionCliente.Text) ||
                string.IsNullOrEmpty(txtCorreoCliente.Text) || string.IsNullOrEmpty(txtDPICliente.Text) ||
                string.IsNullOrEmpty(txtTelefonoCliente.Text) || string.IsNullOrEmpty(txtCalificacionCliente.Text) ||
                string.IsNullOrEmpty(txtContrasenaCliente.Text) || string.IsNullOrEmpty(txtConfirmarCliente.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!decimal.TryParse(txtCalificacionCliente.Text, out _))
            {
                MessageBox.Show("La calificación debe ser un valor decimal.");
                return false;
            }

            if (txtContrasenaCliente.Text != txtConfirmarCliente.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            return true;
        }

        private bool ValidarCamposPiloto()
        {
            if (string.IsNullOrEmpty(txtNombrePiloto.Text) || string.IsNullOrEmpty(txtApellidoPiloto.Text) ||
                cmbGeneroPiloto.SelectedItem == null || string.IsNullOrEmpty(txtDireccionPiloto.Text) ||
                string.IsNullOrEmpty(txtCorreoPiloto.Text) || string.IsNullOrEmpty(txtDPIPiloto.Text) ||
                string.IsNullOrEmpty(txtTelefonoPiloto.Text) || string.IsNullOrEmpty(txtCalificacionPiloto.Text) ||
                string.IsNullOrEmpty(txtContrasenaPiloto.Text) || string.IsNullOrEmpty(txtConfirmarPiloto.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }

            if (!decimal.TryParse(txtCalificacionPiloto.Text, out _))
            {
                MessageBox.Show("La calificación debe ser un valor decimal.");
                return false;
            }

            if (txtContrasenaPiloto.Text != txtConfirmarPiloto.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            return true;
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (cmbBuscarCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente para actualizar.");
                return;
            }

            if (!ValidarCamposCliente())
            {
                return;
            }

            string correo = cmbBuscarCliente.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        UPDATE Datos_Personales 
                        SET Nombres = @nombres, Apellidos = @apellidos, Genero = @genero, Direccion_Personal = @direccion,
                            Correo_Personal = @correo, DPI = @dpi, Telefono = @telefono, PromedioCalificaciones = @calificacion, Contrasena = @contrasena
                        WHERE Correo_Personal = @correo AND ID_Cliente IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombres", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@apellidos", txtApellidoCliente.Text);
                    cmd.Parameters.AddWithValue("@genero", cmbGeneroCliente.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccionCliente.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreoCliente.Text);
                    cmd.Parameters.AddWithValue("@dpi", txtDPICliente.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoCliente.Text);
                    cmd.Parameters.AddWithValue("@calificacion", Convert.ToDecimal(txtCalificacionCliente.Text));
                    cmd.Parameters.AddWithValue("@contrasena", txtContrasenaCliente.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente actualizado exitosamente.");
                    LimpiarCamposCliente();
                    HabilitarCamposCliente(false);
                    HabilitarBotonesCliente(false);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el cliente: " + ex.Message);
                }
            }
        }

        private void btnActualizarPiloto_Click_1(object sender, EventArgs e)
        {
            if (cmbBuscarPiloto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un piloto para actualizar.");
                return;
            }

            if (!ValidarCamposPiloto())
            {
                return;
            }

            string correo = cmbBuscarPiloto.SelectedItem.ToString();
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        UPDATE Datos_Personales 
                        SET Nombres = @nombres, Apellidos = @apellidos, Genero = @genero, Direccion_Personal = @direccion,
                            Correo_Personal = @correo, DPI = @dpi, Telefono = @telefono, PromedioCalificaciones = @calificacion, Contrasena = @contrasena
                        WHERE Correo_Personal = @correo AND ID_Piloto IS NOT NULL";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombres", txtNombrePiloto.Text);
                    cmd.Parameters.AddWithValue("@apellidos", txtApellidoPiloto.Text);
                    cmd.Parameters.AddWithValue("@genero", cmbGeneroPiloto.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@direccion", txtDireccionPiloto.Text);
                    cmd.Parameters.AddWithValue("@correo", txtCorreoPiloto.Text);
                    cmd.Parameters.AddWithValue("@dpi", txtDPIPiloto.Text);
                    cmd.Parameters.AddWithValue("@telefono", txtTelefonoPiloto.Text);
                    cmd.Parameters.AddWithValue("@calificacion", Convert.ToDecimal(txtCalificacionPiloto.Text));
                    cmd.Parameters.AddWithValue("@contrasena", txtContrasenaPiloto.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Piloto actualizado exitosamente.");
                    LimpiarCamposPiloto();
                    HabilitarCamposPiloto(false);
                    HabilitarBotonesPiloto(false);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al actualizar el piloto: " + ex.Message);
                }
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (cmbBuscarCliente.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            string correo = cmbBuscarCliente.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar al cliente: " + txtNombreCliente.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Datos_Personales WHERE Correo_Personal = @correo AND ID_Cliente IS NOT NULL";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@correo", correo);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado exitosamente.");
                            cmbBuscarCliente.Items.Remove(correo);
                            LimpiarCamposCliente();
                            HabilitarCamposCliente(false);
                            HabilitarBotonesCliente(false);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el cliente.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                    }
                }
            }
        }

        private void btnEliminarPiloto_Click_1(object sender, EventArgs e)
        {
            if (cmbBuscarPiloto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un piloto para eliminar.");
                return;
            }

            string correo = cmbBuscarPiloto.SelectedItem.ToString();
            DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar al piloto: " + txtNombrePiloto.Text + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM Datos_Personales WHERE Correo_Personal = @correo AND ID_Piloto IS NOT NULL";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@correo", correo);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Piloto eliminado exitosamente.");
                            cmbBuscarPiloto.Items.Remove(correo);
                            LimpiarCamposPiloto();
                            HabilitarCamposPiloto(false);
                            HabilitarBotonesPiloto(false);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el piloto.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el piloto: " + ex.Message);
                    }
                }
            }
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCamposCliente();
            HabilitarCamposCliente(false);
            DesactivarBotonesIniciales();
            cmbBuscarCliente.Enabled = true;
        }

        private void btnCancelarPiloto_Click_1(object sender, EventArgs e)
        {
            LimpiarCamposPiloto();
            HabilitarCamposPiloto(false);
            DesactivarBotonesIniciales();
            cmbBuscarPiloto.Enabled = true;
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            CargarDatosClientes();
        }

        private void btnVerPilotos_Click_1(object sender, EventArgs e)
        {
            CargarDatosPilotos();
        }

        private void CargarDatosClientes()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Datos_Personales WHERE ID_Cliente IS NOT NULL";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvClientes.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos de clientes: " + ex.Message);
                }
            }
        }

        private void CargarDatosPilotos()
        {
            string connectionString = "Server=127.0.0.1;Database=comercioelectronico;Uid=root;Pwd=161101;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Datos_Personales WHERE ID_Piloto IS NOT NULL";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    adapter.Fill(dt);
                    dgvPilotos.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al cargar datos de pilotos: " + ex.Message);
                }
            }
        }

        private void HabilitarBotonesCliente(bool habilitar)
        {
            btnActualizarCliente.Enabled = habilitar;
            btnEliminarCliente.Enabled = habilitar;
        }

        private void HabilitarBotonesPiloto(bool habilitar)
        {
            btnActualizarPiloto.Enabled = habilitar;
            btnEliminarPiloto.Enabled = habilitar;
        }
    }
}
