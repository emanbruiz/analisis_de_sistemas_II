
namespace AdminRepartoApp
{
    partial class frmBodegasTransportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodegasTransportes));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblGestionPedidos = new System.Windows.Forms.Label();
            this.gpbAsingarPedidos = new System.Windows.Forms.GroupBox();
            this.txtEnvio = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblM = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarEnvio = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstadoEnvio = new System.Windows.Forms.ComboBox();
            this.txtDireccionRecoleccion = new System.Windows.Forms.TextBox();
            this.lblDireccionR = new System.Windows.Forms.Label();
            this.txtDireccionEntrega = new System.Windows.Forms.TextBox();
            this.lblDireccionE = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.lblDireccionC = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoC = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblPiloto = new System.Windows.Forms.Label();
            this.cmbBuscarPiloto = new System.Windows.Forms.ComboBox();
            this.lblNoAsignados = new System.Windows.Forms.Label();
            this.cmbBuscarPedidoNoAsignado = new System.Windows.Forms.ComboBox();
            this.gpbOC = new System.Windows.Forms.GroupBox();
            this.btnGuardarOrden = new System.Windows.Forms.Button();
            this.txtMontoOrden = new System.Windows.Forms.TextBox();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtCantidadOrden = new System.Windows.Forms.TextBox();
            this.lblCantidadASolicitar = new System.Windows.Forms.Label();
            this.lblProductoOC = new System.Windows.Forms.Label();
            this.cmbProductoOrden = new System.Windows.Forms.ComboBox();
            this.txtIDEnvio = new System.Windows.Forms.TextBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.txtIDVehiculo = new System.Windows.Forms.TextBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.gpbAsingarPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpbOC.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlMain.Size = new System.Drawing.Size(1040, 49);
            this.pnlMain.TabIndex = 3;
            // 
            // lblGestionPedidos
            // 
            this.lblGestionPedidos.AutoSize = true;
            this.lblGestionPedidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPedidos.ForeColor = System.Drawing.Color.White;
            this.lblGestionPedidos.Location = new System.Drawing.Point(5, 11);
            this.lblGestionPedidos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGestionPedidos.Name = "lblGestionPedidos";
            this.lblGestionPedidos.Size = new System.Drawing.Size(234, 32);
            this.lblGestionPedidos.TabIndex = 0;
            this.lblGestionPedidos.Text = "Gestión de Pedidos";
            // 
            // gpbAsingarPedidos
            // 
            this.gpbAsingarPedidos.Controls.Add(this.txtEnvio);
            this.gpbAsingarPedidos.Controls.Add(this.lblE);
            this.gpbAsingarPedidos.Controls.Add(this.txtMonto);
            this.gpbAsingarPedidos.Controls.Add(this.lblM);
            this.gpbAsingarPedidos.Controls.Add(this.txtCantidad);
            this.gpbAsingarPedidos.Controls.Add(this.lblC);
            this.gpbAsingarPedidos.Controls.Add(this.lblFecha);
            this.gpbAsingarPedidos.Controls.Add(this.dtpFechaSolicitud);
            this.gpbAsingarPedidos.Controls.Add(this.btnGuardarEnvio);
            this.gpbAsingarPedidos.Controls.Add(this.lblEstado);
            this.gpbAsingarPedidos.Controls.Add(this.cmbEstadoEnvio);
            this.gpbAsingarPedidos.Controls.Add(this.txtDireccionRecoleccion);
            this.gpbAsingarPedidos.Controls.Add(this.lblDireccionR);
            this.gpbAsingarPedidos.Controls.Add(this.txtDireccionEntrega);
            this.gpbAsingarPedidos.Controls.Add(this.lblDireccionE);
            this.gpbAsingarPedidos.Controls.Add(this.txtCorreoCliente);
            this.gpbAsingarPedidos.Controls.Add(this.lblCorreo);
            this.gpbAsingarPedidos.Controls.Add(this.txtDireccionCliente);
            this.gpbAsingarPedidos.Controls.Add(this.lblDireccionC);
            this.gpbAsingarPedidos.Controls.Add(this.txtApellidosCliente);
            this.gpbAsingarPedidos.Controls.Add(this.lblApellidoC);
            this.gpbAsingarPedidos.Controls.Add(this.txtNombreCliente);
            this.gpbAsingarPedidos.Controls.Add(this.lblNombreC);
            this.gpbAsingarPedidos.Controls.Add(this.dgvPedidos);
            this.gpbAsingarPedidos.Controls.Add(this.lblPiloto);
            this.gpbAsingarPedidos.Controls.Add(this.cmbBuscarPiloto);
            this.gpbAsingarPedidos.Controls.Add(this.lblNoAsignados);
            this.gpbAsingarPedidos.Controls.Add(this.cmbBuscarPedidoNoAsignado);
            this.gpbAsingarPedidos.Location = new System.Drawing.Point(9, 58);
            this.gpbAsingarPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAsingarPedidos.Name = "gpbAsingarPedidos";
            this.gpbAsingarPedidos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbAsingarPedidos.Size = new System.Drawing.Size(503, 721);
            this.gpbAsingarPedidos.TabIndex = 4;
            this.gpbAsingarPedidos.TabStop = false;
            this.gpbAsingarPedidos.Text = "Asignación de Pedidos";
            // 
            // txtEnvio
            // 
            this.txtEnvio.Location = new System.Drawing.Point(236, 640);
            this.txtEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.Size = new System.Drawing.Size(257, 22);
            this.txtEnvio.TabIndex = 13;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(8, 640);
            this.lblE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(43, 17);
            this.lblE.TabIndex = 27;
            this.lblE.Text = "Envío";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(236, 608);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(257, 22);
            this.txtMonto.TabIndex = 12;
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(8, 608);
            this.lblM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(47, 17);
            this.lblM.TabIndex = 25;
            this.lblM.Text = "Monto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(236, 576);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(257, 22);
            this.txtCantidad.TabIndex = 11;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(8, 576);
            this.lblC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(64, 17);
            this.lblC.TabIndex = 23;
            this.lblC.Text = "Cantidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(8, 544);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(117, 17);
            this.lblFecha.TabIndex = 22;
            this.lblFecha.Text = "Fecha del pedido";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(235, 544);
            this.dtpFechaSolicitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(255, 22);
            this.dtpFechaSolicitud.TabIndex = 10;
            // 
            // btnGuardarEnvio
            // 
            this.btnGuardarEnvio.Location = new System.Drawing.Point(379, 672);
            this.btnGuardarEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarEnvio.Name = "btnGuardarEnvio";
            this.btnGuardarEnvio.Size = new System.Drawing.Size(115, 34);
            this.btnGuardarEnvio.TabIndex = 14;
            this.btnGuardarEnvio.Text = "Guardar Envío";
            this.btnGuardarEnvio.UseVisualStyleBackColor = true;
            this.btnGuardarEnvio.Click += new System.EventHandler(this.btnGuardarEnvio_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(7, 510);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(91, 17);
            this.lblEstado.TabIndex = 19;
            this.lblEstado.Text = "Estado Envío";
            // 
            // cmbEstadoEnvio
            // 
            this.cmbEstadoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEnvio.FormattingEnabled = true;
            this.cmbEstadoEnvio.Location = new System.Drawing.Point(236, 510);
            this.cmbEstadoEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoEnvio.Name = "cmbEstadoEnvio";
            this.cmbEstadoEnvio.Size = new System.Drawing.Size(256, 24);
            this.cmbEstadoEnvio.TabIndex = 9;
            // 
            // txtDireccionRecoleccion
            // 
            this.txtDireccionRecoleccion.Location = new System.Drawing.Point(235, 478);
            this.txtDireccionRecoleccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionRecoleccion.Name = "txtDireccionRecoleccion";
            this.txtDireccionRecoleccion.Size = new System.Drawing.Size(257, 22);
            this.txtDireccionRecoleccion.TabIndex = 8;
            // 
            // lblDireccionR
            // 
            this.lblDireccionR.AutoSize = true;
            this.lblDireccionR.Location = new System.Drawing.Point(7, 478);
            this.lblDireccionR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionR.Name = "lblDireccionR";
            this.lblDireccionR.Size = new System.Drawing.Size(143, 17);
            this.lblDireccionR.TabIndex = 16;
            this.lblDireccionR.Text = "Dirección recolección";
            // 
            // txtDireccionEntrega
            // 
            this.txtDireccionEntrega.Location = new System.Drawing.Point(235, 446);
            this.txtDireccionEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionEntrega.Name = "txtDireccionEntrega";
            this.txtDireccionEntrega.Size = new System.Drawing.Size(257, 22);
            this.txtDireccionEntrega.TabIndex = 7;
            // 
            // lblDireccionE
            // 
            this.lblDireccionE.AutoSize = true;
            this.lblDireccionE.Location = new System.Drawing.Point(7, 446);
            this.lblDireccionE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionE.Name = "lblDireccionE";
            this.lblDireccionE.Size = new System.Drawing.Size(120, 17);
            this.lblDireccionE.TabIndex = 14;
            this.lblDireccionE.Text = "Dirección entrega";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(235, 414);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(257, 22);
            this.txtCorreoCliente.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(7, 414);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(98, 17);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo Cliente";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(235, 382);
            this.txtDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(257, 22);
            this.txtDireccionCliente.TabIndex = 5;
            // 
            // lblDireccionC
            // 
            this.lblDireccionC.AutoSize = true;
            this.lblDireccionC.Location = new System.Drawing.Point(7, 382);
            this.lblDireccionC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccionC.Name = "lblDireccionC";
            this.lblDireccionC.Size = new System.Drawing.Size(114, 17);
            this.lblDireccionC.TabIndex = 10;
            this.lblDireccionC.Text = "Dirección Cliente";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(236, 350);
            this.txtApellidosCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.Size = new System.Drawing.Size(257, 22);
            this.txtApellidosCliente.TabIndex = 4;
            // 
            // lblApellidoC
            // 
            this.lblApellidoC.AutoSize = true;
            this.lblApellidoC.Location = new System.Drawing.Point(8, 350);
            this.lblApellidoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoC.Name = "lblApellidoC";
            this.lblApellidoC.Size = new System.Drawing.Size(105, 17);
            this.lblApellidoC.TabIndex = 8;
            this.lblApellidoC.Text = "Apellido Cliente";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(236, 318);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(257, 22);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(8, 318);
            this.lblNombreC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(105, 17);
            this.lblNombreC.TabIndex = 6;
            this.lblNombreC.Text = "Nombre Cliente";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(11, 89);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.Size = new System.Drawing.Size(487, 218);
            this.dgvPedidos.TabIndex = 5;
            // 
            // lblPiloto
            // 
            this.lblPiloto.AutoSize = true;
            this.lblPiloto.Location = new System.Drawing.Point(8, 57);
            this.lblPiloto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPiloto.Name = "lblPiloto";
            this.lblPiloto.Size = new System.Drawing.Size(95, 17);
            this.lblPiloto.TabIndex = 3;
            this.lblPiloto.Text = "Asignar Piloto";
            // 
            // cmbBuscarPiloto
            // 
            this.cmbBuscarPiloto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPiloto.FormattingEnabled = true;
            this.cmbBuscarPiloto.Location = new System.Drawing.Point(307, 57);
            this.cmbBuscarPiloto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBuscarPiloto.Name = "cmbBuscarPiloto";
            this.cmbBuscarPiloto.Size = new System.Drawing.Size(187, 24);
            this.cmbBuscarPiloto.TabIndex = 2;
            // 
            // lblNoAsignados
            // 
            this.lblNoAsignados.AutoSize = true;
            this.lblNoAsignados.Location = new System.Drawing.Point(8, 23);
            this.lblNoAsignados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoAsignados.Name = "lblNoAsignados";
            this.lblNoAsignados.Size = new System.Drawing.Size(151, 17);
            this.lblNoAsignados.TabIndex = 1;
            this.lblNoAsignados.Text = "Pedidos No Asignados";
            // 
            // cmbBuscarPedidoNoAsignado
            // 
            this.cmbBuscarPedidoNoAsignado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPedidoNoAsignado.FormattingEnabled = true;
            this.cmbBuscarPedidoNoAsignado.Location = new System.Drawing.Point(307, 23);
            this.cmbBuscarPedidoNoAsignado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBuscarPedidoNoAsignado.Name = "cmbBuscarPedidoNoAsignado";
            this.cmbBuscarPedidoNoAsignado.Size = new System.Drawing.Size(187, 24);
            this.cmbBuscarPedidoNoAsignado.TabIndex = 1;
            this.cmbBuscarPedidoNoAsignado.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPedidoNoAsignado_SelectedIndexChanged);
            // 
            // gpbOC
            // 
            this.gpbOC.Controls.Add(this.btnGuardarOrden);
            this.gpbOC.Controls.Add(this.txtMontoOrden);
            this.gpbOC.Controls.Add(this.lblMontoTotal);
            this.gpbOC.Controls.Add(this.txtCantidadOrden);
            this.gpbOC.Controls.Add(this.lblCantidadASolicitar);
            this.gpbOC.Controls.Add(this.lblProductoOC);
            this.gpbOC.Controls.Add(this.cmbProductoOrden);
            this.gpbOC.Location = new System.Drawing.Point(528, 66);
            this.gpbOC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbOC.Name = "gpbOC";
            this.gpbOC.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbOC.Size = new System.Drawing.Size(503, 169);
            this.gpbOC.TabIndex = 5;
            this.gpbOC.TabStop = false;
            this.gpbOC.Text = "Órden de Compra";
            // 
            // btnGuardarOrden
            // 
            this.btnGuardarOrden.Location = new System.Drawing.Point(307, 121);
            this.btnGuardarOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarOrden.Name = "btnGuardarOrden";
            this.btnGuardarOrden.Size = new System.Drawing.Size(188, 34);
            this.btnGuardarOrden.TabIndex = 18;
            this.btnGuardarOrden.Text = "Guardar Órden de Compra";
            this.btnGuardarOrden.UseVisualStyleBackColor = true;
            this.btnGuardarOrden.Click += new System.EventHandler(this.btnGuardarOrden_Click);
            // 
            // txtMontoOrden
            // 
            this.txtMontoOrden.Location = new System.Drawing.Point(307, 89);
            this.txtMontoOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoOrden.Name = "txtMontoOrden";
            this.txtMontoOrden.Size = new System.Drawing.Size(187, 22);
            this.txtMontoOrden.TabIndex = 17;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(8, 89);
            this.lblMontoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(83, 17);
            this.lblMontoTotal.TabIndex = 23;
            this.lblMontoTotal.Text = "Monto Total";
            // 
            // txtCantidadOrden
            // 
            this.txtCantidadOrden.Location = new System.Drawing.Point(307, 57);
            this.txtCantidadOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidadOrden.Name = "txtCantidadOrden";
            this.txtCantidadOrden.Size = new System.Drawing.Size(187, 22);
            this.txtCantidadOrden.TabIndex = 16;
            // 
            // lblCantidadASolicitar
            // 
            this.lblCantidadASolicitar.AutoSize = true;
            this.lblCantidadASolicitar.Location = new System.Drawing.Point(8, 57);
            this.lblCantidadASolicitar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadASolicitar.Name = "lblCantidadASolicitar";
            this.lblCantidadASolicitar.Size = new System.Drawing.Size(211, 17);
            this.lblCantidadASolicitar.TabIndex = 21;
            this.lblCantidadASolicitar.Text = "Cantidad del producto a solicitar";
            // 
            // lblProductoOC
            // 
            this.lblProductoOC.AutoSize = true;
            this.lblProductoOC.Location = new System.Drawing.Point(8, 23);
            this.lblProductoOC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductoOC.Name = "lblProductoOC";
            this.lblProductoOC.Size = new System.Drawing.Size(212, 17);
            this.lblProductoOC.TabIndex = 22;
            this.lblProductoOC.Text = "Producto de la órden de compra";
            // 
            // cmbProductoOrden
            // 
            this.cmbProductoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductoOrden.FormattingEnabled = true;
            this.cmbProductoOrden.ItemHeight = 16;
            this.cmbProductoOrden.Location = new System.Drawing.Point(307, 23);
            this.cmbProductoOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProductoOrden.Name = "cmbProductoOrden";
            this.cmbProductoOrden.Size = new System.Drawing.Size(187, 24);
            this.cmbProductoOrden.TabIndex = 21;
            this.cmbProductoOrden.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtIDEnvio
            // 
            this.txtIDEnvio.Location = new System.Drawing.Point(772, 242);
            this.txtIDEnvio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDEnvio.Name = "txtIDEnvio";
            this.txtIDEnvio.Size = new System.Drawing.Size(257, 22);
            this.txtIDEnvio.TabIndex = 30;
            this.txtIDEnvio.Visible = false;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(544, 242);
            this.lblEnvio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(60, 17);
            this.lblEnvio.TabIndex = 29;
            this.lblEnvio.Text = "ID Envío";
            this.lblEnvio.Visible = false;
            // 
            // txtIDVehiculo
            // 
            this.txtIDVehiculo.Location = new System.Drawing.Point(772, 274);
            this.txtIDVehiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDVehiculo.Name = "txtIDVehiculo";
            this.txtIDVehiculo.Size = new System.Drawing.Size(257, 22);
            this.txtIDVehiculo.TabIndex = 32;
            this.txtIDVehiculo.Visible = false;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(544, 274);
            this.lblVehiculo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(79, 17);
            this.lblVehiculo.TabIndex = 31;
            this.lblVehiculo.Text = "ID Vehículo";
            this.lblVehiculo.Visible = false;
            // 
            // frmBodegasTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 790);
            this.Controls.Add(this.txtIDVehiculo);
            this.Controls.Add(this.lblVehiculo);
            this.Controls.Add(this.txtIDEnvio);
            this.Controls.Add(this.lblEnvio);
            this.Controls.Add(this.gpbOC);
            this.Controls.Add(this.gpbAsingarPedidos);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmBodegasTransportes";
            this.Text = "Gestión de Pedidos";
            this.Load += new System.EventHandler(this.frmBodegasTransportes_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbAsingarPedidos.ResumeLayout(false);
            this.gpbAsingarPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gpbOC.ResumeLayout(false);
            this.gpbOC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblGestionPedidos;
        private System.Windows.Forms.GroupBox gpbAsingarPedidos;
        private System.Windows.Forms.Label lblNoAsignados;
        private System.Windows.Forms.ComboBox cmbBuscarPedidoNoAsignado;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblPiloto;
        private System.Windows.Forms.ComboBox cmbBuscarPiloto;
        private System.Windows.Forms.Button btnGuardarEnvio;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstadoEnvio;
        private System.Windows.Forms.TextBox txtDireccionRecoleccion;
        private System.Windows.Forms.Label lblDireccionR;
        private System.Windows.Forms.TextBox txtDireccionEntrega;
        private System.Windows.Forms.Label lblDireccionE;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label lblDireccionC;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label lblApellidoC;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.GroupBox gpbOC;
        private System.Windows.Forms.Button btnGuardarOrden;
        private System.Windows.Forms.TextBox txtMontoOrden;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtCantidadOrden;
        private System.Windows.Forms.Label lblCantidadASolicitar;
        private System.Windows.Forms.Label lblProductoOC;
        private System.Windows.Forms.ComboBox cmbProductoOrden;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.TextBox txtIDEnvio;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.TextBox txtIDVehiculo;
        private System.Windows.Forms.Label lblVehiculo;
    }
}