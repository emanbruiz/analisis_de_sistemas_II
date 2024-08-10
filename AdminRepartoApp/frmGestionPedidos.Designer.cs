
namespace AdminRepartoApp
{
    partial class frmGestionPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPedidos));
            this.lblGestionPedidos = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblPedido = new System.Windows.Forms.Label();
            this.gpbPedidos = new System.Windows.Forms.GroupBox();
            this.lblNoPedido = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.cmbBuscarPedido = new System.Windows.Forms.ComboBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnActualizarPedido = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtEnvio = new System.Windows.Forms.TextBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtCalificacionCliente = new System.Windows.Forms.TextBox();
            this.txtDPICliente = new System.Windows.Forms.TextBox();
            this.lblDPI_C = new System.Windows.Forms.Label();
            this.cmbGeneroCliente = new System.Windows.Forms.ComboBox();
            this.lblGeneroC = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionC = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoC = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.lblCorreoC = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.gpbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGestionPedidos
            // 
            this.lblGestionPedidos.AutoSize = true;
            this.lblGestionPedidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPedidos.ForeColor = System.Drawing.Color.White;
            this.lblGestionPedidos.Location = new System.Drawing.Point(5, 11);
            this.lblGestionPedidos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGestionPedidos.Name = "lblGestionPedidos";
            this.lblGestionPedidos.Size = new System.Drawing.Size(235, 32);
            this.lblGestionPedidos.TabIndex = 0;
            this.lblGestionPedidos.Text = "Gestión de pedidos";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblGestionPedidos);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(961, 48);
            this.pnlMain.TabIndex = 4;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Location = new System.Drawing.Point(11, 23);
            this.lblPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(52, 17);
            this.lblPedido.TabIndex = 5;
            this.lblPedido.Text = "Pedido";
            // 
            // gpbPedidos
            // 
            this.gpbPedidos.Controls.Add(this.lblNoPedido);
            this.gpbPedidos.Controls.Add(this.lblTipo);
            this.gpbPedidos.Controls.Add(this.cmbTipoPedido);
            this.gpbPedidos.Controls.Add(this.cmbBuscarPedido);
            this.gpbPedidos.Controls.Add(this.dgvPedidos);
            this.gpbPedidos.Controls.Add(this.btnActualizarPedido);
            this.gpbPedidos.Controls.Add(this.lblEstado);
            this.gpbPedidos.Controls.Add(this.cmbEstado);
            this.gpbPedidos.Controls.Add(this.txtEnvio);
            this.gpbPedidos.Controls.Add(this.lblEnvio);
            this.gpbPedidos.Controls.Add(this.txtEmpresa);
            this.gpbPedidos.Controls.Add(this.lblEmpresa);
            this.gpbPedidos.Controls.Add(this.txtMonto);
            this.gpbPedidos.Controls.Add(this.lblMonto);
            this.gpbPedidos.Controls.Add(this.txtCantidad);
            this.gpbPedidos.Controls.Add(this.lblCantidad);
            this.gpbPedidos.Controls.Add(this.dtpFechaSolicitud);
            this.gpbPedidos.Controls.Add(this.lblFecha);
            this.gpbPedidos.Controls.Add(this.txtNoFactura);
            this.gpbPedidos.Controls.Add(this.lblPedido);
            this.gpbPedidos.Location = new System.Drawing.Point(0, 57);
            this.gpbPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPedidos.Name = "gpbPedidos";
            this.gpbPedidos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPedidos.Size = new System.Drawing.Size(476, 549);
            this.gpbPedidos.TabIndex = 6;
            this.gpbPedidos.TabStop = false;
            this.gpbPedidos.Text = "Sección pedidos";
            // 
            // lblNoPedido
            // 
            this.lblNoPedido.AutoSize = true;
            this.lblNoPedido.Location = new System.Drawing.Point(16, 53);
            this.lblNoPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoPedido.Name = "lblNoPedido";
            this.lblNoPedido.Size = new System.Drawing.Size(78, 17);
            this.lblNoPedido.TabIndex = 31;
            this.lblNoPedido.Text = "No. Pedido";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(12, 281);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 17);
            this.lblTipo.TabIndex = 30;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.ItemHeight = 16;
            this.cmbTipoPedido.Items.AddRange(new object[] {
            "Normal",
            "Rápido"});
            this.cmbTipoPedido.Location = new System.Drawing.Point(195, 281);
            this.cmbTipoPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(265, 24);
            this.cmbTipoPedido.TabIndex = 9;
            this.cmbTipoPedido.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPedido_SelectedIndexChanged);
            // 
            // cmbBuscarPedido
            // 
            this.cmbBuscarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPedido.FormattingEnabled = true;
            this.cmbBuscarPedido.Location = new System.Drawing.Point(195, 20);
            this.cmbBuscarPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBuscarPedido.Name = "cmbBuscarPedido";
            this.cmbBuscarPedido.Size = new System.Drawing.Size(265, 24);
            this.cmbBuscarPedido.TabIndex = 1;
            this.cmbBuscarPedido.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPedido_SelectedIndexChanged);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(11, 396);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.Size = new System.Drawing.Size(449, 135);
            this.dgvPedidos.TabIndex = 27;
            // 
            // btnActualizarPedido
            // 
            this.btnActualizarPedido.Location = new System.Drawing.Point(315, 325);
            this.btnActualizarPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizarPedido.Name = "btnActualizarPedido";
            this.btnActualizarPedido.Size = new System.Drawing.Size(145, 43);
            this.btnActualizarPedido.TabIndex = 10;
            this.btnActualizarPedido.Text = "Actualizar Pedido";
            this.btnActualizarPedido.UseVisualStyleBackColor = true;
            this.btnActualizarPedido.Click += new System.EventHandler(this.btnActualizarPedido_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 246);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.ItemHeight = 16;
            this.cmbEstado.Items.AddRange(new object[] {
            "En Tránsito",
            "Entregado",
            "Retrasado",
            "Cancelado",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(195, 246);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(265, 24);
            this.cmbEstado.TabIndex = 8;
            // 
            // txtEnvio
            // 
            this.txtEnvio.Location = new System.Drawing.Point(195, 214);
            this.txtEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.Size = new System.Drawing.Size(265, 22);
            this.txtEnvio.TabIndex = 7;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(12, 214);
            this.lblEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(43, 17);
            this.lblEnvio.TabIndex = 18;
            this.lblEnvio.Text = "Envío";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(195, 182);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(265, 22);
            this.txtEmpresa.TabIndex = 6;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(12, 182);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(64, 17);
            this.lblEmpresa.TabIndex = 16;
            this.lblEmpresa.Text = "Empresa";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(195, 150);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(265, 22);
            this.txtMonto.TabIndex = 5;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 150);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(47, 17);
            this.lblMonto.TabIndex = 14;
            this.lblMonto.Text = "Monto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(195, 118);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(265, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 118);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 17);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Text = "Cantidad";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(195, 86);
            this.dtpFechaSolicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaSolicitud.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 86);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(124, 17);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha de Solicitud";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(195, 53);
            this.txtNoFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.ReadOnly = true;
            this.txtNoFactura.Size = new System.Drawing.Size(265, 22);
            this.txtNoFactura.TabIndex = 2;
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.lblCalificacion);
            this.gpbCliente.Controls.Add(this.txtCalificacionCliente);
            this.gpbCliente.Controls.Add(this.txtDPICliente);
            this.gpbCliente.Controls.Add(this.lblDPI_C);
            this.gpbCliente.Controls.Add(this.cmbGeneroCliente);
            this.gpbCliente.Controls.Add(this.lblGeneroC);
            this.gpbCliente.Controls.Add(this.txtDireccionCliente);
            this.gpbCliente.Controls.Add(this.lblDireccionC);
            this.gpbCliente.Controls.Add(this.txtTelefonoCliente);
            this.gpbCliente.Controls.Add(this.lblTelefonoC);
            this.gpbCliente.Controls.Add(this.txtCorreoCliente);
            this.gpbCliente.Controls.Add(this.lblCorreoC);
            this.gpbCliente.Controls.Add(this.txtApellidoCliente);
            this.gpbCliente.Controls.Add(this.lblApellidoCliente);
            this.gpbCliente.Controls.Add(this.txtNombreCliente);
            this.gpbCliente.Controls.Add(this.lblNombreCliente);
            this.gpbCliente.Location = new System.Drawing.Point(484, 57);
            this.gpbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbCliente.Size = new System.Drawing.Size(475, 282);
            this.gpbCliente.TabIndex = 7;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Sección de cliente";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(16, 246);
            this.lblCalificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(177, 17);
            this.lblCalificacion.TabIndex = 29;
            this.lblCalificacion.Text = "Calificación hacia el cliente";
            // 
            // txtCalificacionCliente
            // 
            this.txtCalificacionCliente.Location = new System.Drawing.Point(199, 246);
            this.txtCalificacionCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalificacionCliente.Name = "txtCalificacionCliente";
            this.txtCalificacionCliente.ReadOnly = true;
            this.txtCalificacionCliente.Size = new System.Drawing.Size(265, 22);
            this.txtCalificacionCliente.TabIndex = 18;
            // 
            // txtDPICliente
            // 
            this.txtDPICliente.Location = new System.Drawing.Point(199, 214);
            this.txtDPICliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDPICliente.Name = "txtDPICliente";
            this.txtDPICliente.ReadOnly = true;
            this.txtDPICliente.Size = new System.Drawing.Size(265, 22);
            this.txtDPICliente.TabIndex = 17;
            // 
            // lblDPI_C
            // 
            this.lblDPI_C.AutoSize = true;
            this.lblDPI_C.Location = new System.Drawing.Point(16, 214);
            this.lblDPI_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPI_C.Name = "lblDPI_C";
            this.lblDPI_C.Size = new System.Drawing.Size(30, 17);
            this.lblDPI_C.TabIndex = 25;
            this.lblDPI_C.Text = "DPI";
            // 
            // cmbGeneroCliente
            // 
            this.cmbGeneroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroCliente.Enabled = false;
            this.cmbGeneroCliente.FormattingEnabled = true;
            this.cmbGeneroCliente.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGeneroCliente.Location = new System.Drawing.Point(199, 181);
            this.cmbGeneroCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGeneroCliente.Name = "cmbGeneroCliente";
            this.cmbGeneroCliente.Size = new System.Drawing.Size(265, 24);
            this.cmbGeneroCliente.TabIndex = 16;
            // 
            // lblGeneroC
            // 
            this.lblGeneroC.AutoSize = true;
            this.lblGeneroC.Location = new System.Drawing.Point(16, 181);
            this.lblGeneroC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGeneroC.Name = "lblGeneroC";
            this.lblGeneroC.Size = new System.Drawing.Size(56, 17);
            this.lblGeneroC.TabIndex = 24;
            this.lblGeneroC.Text = "Género";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(199, 149);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(265, 22);
            this.txtDireccionCliente.TabIndex = 15;
            // 
            // lblDireccionC
            // 
            this.lblDireccionC.AutoSize = true;
            this.lblDireccionC.Location = new System.Drawing.Point(16, 149);
            this.lblDireccionC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionC.Name = "lblDireccionC";
            this.lblDireccionC.Size = new System.Drawing.Size(67, 17);
            this.lblDireccionC.TabIndex = 22;
            this.lblDireccionC.Text = "Dirección";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(199, 117);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(265, 22);
            this.txtTelefonoCliente.TabIndex = 14;
            // 
            // lblTelefonoC
            // 
            this.lblTelefonoC.AutoSize = true;
            this.lblTelefonoC.Location = new System.Drawing.Point(16, 117);
            this.lblTelefonoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefonoC.Name = "lblTelefonoC";
            this.lblTelefonoC.Size = new System.Drawing.Size(64, 17);
            this.lblTelefonoC.TabIndex = 20;
            this.lblTelefonoC.Text = "Teléfono";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(199, 85);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(265, 22);
            this.txtCorreoCliente.TabIndex = 13;
            // 
            // lblCorreoC
            // 
            this.lblCorreoC.AutoSize = true;
            this.lblCorreoC.Location = new System.Drawing.Point(16, 85);
            this.lblCorreoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoC.Name = "lblCorreoC";
            this.lblCorreoC.Size = new System.Drawing.Size(51, 17);
            this.lblCorreoC.TabIndex = 18;
            this.lblCorreoC.Text = "Correo";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(199, 53);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(265, 22);
            this.txtApellidoCliente.TabIndex = 12;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(16, 53);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(58, 17);
            this.lblApellidoCliente.TabIndex = 16;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(199, 21);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(265, 22);
            this.txtNombreCliente.TabIndex = 11;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(16, 21);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(58, 17);
            this.lblNombreCliente.TabIndex = 14;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // frmGestionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 618);
            this.Controls.Add(this.gpbCliente);
            this.Controls.Add(this.gpbPedidos);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmGestionPedidos";
            this.Text = "Gestión de Pedidos";
            this.Load += new System.EventHandler(this.frmGestionPedidos_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbPedidos.ResumeLayout(false);
            this.gpbPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPedidos;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.GroupBox gpbPedidos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label lblTelefonoC;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label lblCorreoC;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.TextBox txtDPICliente;
        private System.Windows.Forms.Label lblDPI_C;
        private System.Windows.Forms.ComboBox cmbGeneroCliente;
        private System.Windows.Forms.Label lblGeneroC;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionC;
        private System.Windows.Forms.Button btnActualizarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.ComboBox cmbBuscarPedido;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private System.Windows.Forms.Label lblNoPedido;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtCalificacionCliente;
    }
}