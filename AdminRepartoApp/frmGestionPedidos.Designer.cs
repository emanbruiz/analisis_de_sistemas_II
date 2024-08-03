
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
            this.lblRegister = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbPedidos = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.cmbBuscarPedido = new System.Windows.Forms.ComboBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnActualizarPedido = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtEnvio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.txtDPICliente = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbGeneroCliente = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtCalificacionCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.gpbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(5, 11);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(235, 32);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Gestión de pedidos";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblRegister);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(961, 48);
            this.pnlMain.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pedido";
            // 
            // gpbPedidos
            // 
            this.gpbPedidos.Controls.Add(this.label2);
            this.gpbPedidos.Controls.Add(this.label40);
            this.gpbPedidos.Controls.Add(this.cmbTipoPedido);
            this.gpbPedidos.Controls.Add(this.cmbBuscarPedido);
            this.gpbPedidos.Controls.Add(this.dgvPedidos);
            this.gpbPedidos.Controls.Add(this.btnActualizarPedido);
            this.gpbPedidos.Controls.Add(this.label8);
            this.gpbPedidos.Controls.Add(this.cmbEstado);
            this.gpbPedidos.Controls.Add(this.txtEnvio);
            this.gpbPedidos.Controls.Add(this.label7);
            this.gpbPedidos.Controls.Add(this.txtEmpresa);
            this.gpbPedidos.Controls.Add(this.label6);
            this.gpbPedidos.Controls.Add(this.txtMonto);
            this.gpbPedidos.Controls.Add(this.label5);
            this.gpbPedidos.Controls.Add(this.txtCantidad);
            this.gpbPedidos.Controls.Add(this.label4);
            this.gpbPedidos.Controls.Add(this.dtpFechaSolicitud);
            this.gpbPedidos.Controls.Add(this.label3);
            this.gpbPedidos.Controls.Add(this.txtNoFactura);
            this.gpbPedidos.Controls.Add(this.label1);
            this.gpbPedidos.Location = new System.Drawing.Point(0, 57);
            this.gpbPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.gpbPedidos.Name = "gpbPedidos";
            this.gpbPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.gpbPedidos.Size = new System.Drawing.Size(476, 549);
            this.gpbPedidos.TabIndex = 6;
            this.gpbPedidos.TabStop = false;
            this.gpbPedidos.Text = "Sección pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "No. Pedido";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(16, 281);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(36, 17);
            this.label40.TabIndex = 30;
            this.label40.Text = "Tipo";
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.Items.AddRange(new object[] {
            "Normal",
            "Rápido"});
            this.cmbTipoPedido.Location = new System.Drawing.Point(195, 281);
            this.cmbTipoPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(265, 24);
            this.cmbTipoPedido.TabIndex = 29;
            this.cmbTipoPedido.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPedido_SelectedIndexChanged);
            // 
            // cmbBuscarPedido
            // 
            this.cmbBuscarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPedido.FormattingEnabled = true;
            this.cmbBuscarPedido.Location = new System.Drawing.Point(195, 20);
            this.cmbBuscarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscarPedido.Name = "cmbBuscarPedido";
            this.cmbBuscarPedido.Size = new System.Drawing.Size(265, 24);
            this.cmbBuscarPedido.TabIndex = 28;
            this.cmbBuscarPedido.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPedido_SelectedIndexChanged);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(11, 396);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.Size = new System.Drawing.Size(449, 135);
            this.dgvPedidos.TabIndex = 27;
            // 
            // btnActualizarPedido
            // 
            this.btnActualizarPedido.Location = new System.Drawing.Point(315, 325);
            this.btnActualizarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarPedido.Name = "btnActualizarPedido";
            this.btnActualizarPedido.Size = new System.Drawing.Size(145, 43);
            this.btnActualizarPedido.TabIndex = 23;
            this.btnActualizarPedido.Text = "Actualizar Pedido";
            this.btnActualizarPedido.UseVisualStyleBackColor = true;
            this.btnActualizarPedido.Click += new System.EventHandler(this.btnActualizarPedido_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "En Tránsito",
            "Entregado",
            "Retrasado",
            "Cancelado",
            "Pendiente"});
            this.cmbEstado.Location = new System.Drawing.Point(195, 246);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(265, 24);
            this.cmbEstado.TabIndex = 20;
            // 
            // txtEnvio
            // 
            this.txtEnvio.Location = new System.Drawing.Point(195, 214);
            this.txtEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.Size = new System.Drawing.Size(265, 22);
            this.txtEnvio.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Envío";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(195, 182);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(265, 22);
            this.txtEmpresa.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Empresa";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(195, 150);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(265, 22);
            this.txtMonto.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Monto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(195, 118);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(265, 22);
            this.txtCantidad.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cantidad";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(195, 86);
            this.dtpFechaSolicitud.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaSolicitud.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Solicitud";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(195, 53);
            this.txtNoFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.ReadOnly = true;
            this.txtNoFactura.Size = new System.Drawing.Size(265, 22);
            this.txtNoFactura.TabIndex = 8;
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.label15);
            this.gpbCliente.Controls.Add(this.txtCalificacionCliente);
            this.gpbCliente.Controls.Add(this.txtDPICliente);
            this.gpbCliente.Controls.Add(this.label14);
            this.gpbCliente.Controls.Add(this.cmbGeneroCliente);
            this.gpbCliente.Controls.Add(this.label13);
            this.gpbCliente.Controls.Add(this.txtDireccionCliente);
            this.gpbCliente.Controls.Add(this.label12);
            this.gpbCliente.Controls.Add(this.txtTelefonoCliente);
            this.gpbCliente.Controls.Add(this.label11);
            this.gpbCliente.Controls.Add(this.txtCorreoCliente);
            this.gpbCliente.Controls.Add(this.label10);
            this.gpbCliente.Controls.Add(this.txtApellidoCliente);
            this.gpbCliente.Controls.Add(this.label9);
            this.gpbCliente.Controls.Add(this.txtNombreCliente);
            this.gpbCliente.Controls.Add(this.lblNombreCliente);
            this.gpbCliente.Location = new System.Drawing.Point(484, 57);
            this.gpbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gpbCliente.Size = new System.Drawing.Size(474, 282);
            this.gpbCliente.TabIndex = 7;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Sección de cliente";
            // 
            // txtDPICliente
            // 
            this.txtDPICliente.Location = new System.Drawing.Point(199, 214);
            this.txtDPICliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPICliente.Name = "txtDPICliente";
            this.txtDPICliente.ReadOnly = true;
            this.txtDPICliente.Size = new System.Drawing.Size(265, 22);
            this.txtDPICliente.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 214);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "DPI";
            // 
            // cmbGeneroCliente
            // 
            this.cmbGeneroCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneroCliente.FormattingEnabled = true;
            this.cmbGeneroCliente.Location = new System.Drawing.Point(199, 181);
            this.cmbGeneroCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGeneroCliente.Name = "cmbGeneroCliente";
            this.cmbGeneroCliente.Size = new System.Drawing.Size(265, 24);
            this.cmbGeneroCliente.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 181);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Género";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(199, 149);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(265, 22);
            this.txtDireccionCliente.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 149);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Dirección";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(199, 117);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(265, 22);
            this.txtTelefonoCliente.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 117);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Teléfono";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(199, 85);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(265, 22);
            this.txtCorreoCliente.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 85);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Correo";
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(199, 53);
            this.txtApellidoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.ReadOnly = true;
            this.txtApellidoCliente.Size = new System.Drawing.Size(265, 22);
            this.txtApellidoCliente.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(199, 21);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(265, 22);
            this.txtNombreCliente.TabIndex = 15;
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
            // txtCalificacionCliente
            // 
            this.txtCalificacionCliente.Location = new System.Drawing.Point(199, 246);
            this.txtCalificacionCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalificacionCliente.Name = "txtCalificacionCliente";
            this.txtCalificacionCliente.ReadOnly = true;
            this.txtCalificacionCliente.Size = new System.Drawing.Size(265, 22);
            this.txtCalificacionCliente.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 246);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 17);
            this.label15.TabIndex = 29;
            this.label15.Text = "Calificación hacia el cliente";
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
            this.Margin = new System.Windows.Forms.Padding(4);
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

        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbPedidos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDPICliente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbGeneroCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnActualizarPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.ComboBox cmbBuscarPedido;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCalificacionCliente;
    }
}