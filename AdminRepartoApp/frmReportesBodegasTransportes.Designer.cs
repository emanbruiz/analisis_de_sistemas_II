
namespace AdminRepartoApp
{
    partial class frmReportesBodegasTransportes
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.gpbPedido = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoPedido = new System.Windows.Forms.ComboBox();
            this.cmbBuscarPedido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbEnvio = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEstadoEnvio = new System.Windows.Forms.ComboBox();
            this.txtIDPedidoEnvio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtApellidosCliente = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtNoFactura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.gpbPedido.SuspendLayout();
            this.gpbEnvio.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblRegister);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(682, 34);
            this.pnlMain.TabIndex = 3;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(4, 9);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(274, 21);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Reportes de Bodegas y Transportes";
            // 
            // gpbPedido
            // 
            this.gpbPedido.Controls.Add(this.txtNoFactura);
            this.gpbPedido.Controls.Add(this.label10);
            this.gpbPedido.Controls.Add(this.label8);
            this.gpbPedido.Controls.Add(this.cmbEstado);
            this.gpbPedido.Controls.Add(this.txtEnvio);
            this.gpbPedido.Controls.Add(this.label7);
            this.gpbPedido.Controls.Add(this.txtEmpresa);
            this.gpbPedido.Controls.Add(this.label6);
            this.gpbPedido.Controls.Add(this.txtMonto);
            this.gpbPedido.Controls.Add(this.label5);
            this.gpbPedido.Controls.Add(this.txtCantidad);
            this.gpbPedido.Controls.Add(this.label4);
            this.gpbPedido.Controls.Add(this.label1);
            this.gpbPedido.Controls.Add(this.dtpFechaSolicitud);
            this.gpbPedido.Controls.Add(this.label3);
            this.gpbPedido.Controls.Add(this.cmbTipoPedido);
            this.gpbPedido.Location = new System.Drawing.Point(8, 79);
            this.gpbPedido.Name = "gpbPedido";
            this.gpbPedido.Size = new System.Drawing.Size(331, 242);
            this.gpbPedido.TabIndex = 4;
            this.gpbPedido.TabStop = false;
            this.gpbPedido.Text = "Datos del Pedido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Estado del Pedido";
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
            this.cmbEstado.Location = new System.Drawing.Point(131, 176);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(194, 21);
            this.cmbEstado.TabIndex = 18;
            // 
            // txtEnvio
            // 
            this.txtEnvio.Location = new System.Drawing.Point(131, 150);
            this.txtEnvio.Name = "txtEnvio";
            this.txtEnvio.ReadOnly = true;
            this.txtEnvio.Size = new System.Drawing.Size(194, 20);
            this.txtEnvio.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Envío";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(131, 124);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(194, 20);
            this.txtEmpresa.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Empresa";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(131, 98);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            this.txtMonto.Size = new System.Drawing.Size(194, 20);
            this.txtMonto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Monto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(131, 72);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(194, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Solicitud";
            // 
            // dtpFechaSolicitud
            // 
            this.dtpFechaSolicitud.Location = new System.Drawing.Point(131, 46);
            this.dtpFechaSolicitud.Name = "dtpFechaSolicitud";
            this.dtpFechaSolicitud.Size = new System.Drawing.Size(194, 20);
            this.dtpFechaSolicitud.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo del Pedido";
            // 
            // cmbTipoPedido
            // 
            this.cmbTipoPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPedido.FormattingEnabled = true;
            this.cmbTipoPedido.Items.AddRange(new object[] {
            "Normal",
            "Rápido"});
            this.cmbTipoPedido.Location = new System.Drawing.Point(131, 19);
            this.cmbTipoPedido.Name = "cmbTipoPedido";
            this.cmbTipoPedido.Size = new System.Drawing.Size(194, 21);
            this.cmbTipoPedido.TabIndex = 6;
            // 
            // cmbBuscarPedido
            // 
            this.cmbBuscarPedido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPedido.FormattingEnabled = true;
            this.cmbBuscarPedido.Location = new System.Drawing.Point(8, 57);
            this.cmbBuscarPedido.Name = "cmbBuscarPedido";
            this.cmbBuscarPedido.Size = new System.Drawing.Size(157, 21);
            this.cmbBuscarPedido.TabIndex = 5;
            this.cmbBuscarPedido.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPedido_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Pedido";
            // 
            // gpbEnvio
            // 
            this.gpbEnvio.Controls.Add(this.label9);
            this.gpbEnvio.Controls.Add(this.cmbEstadoEnvio);
            this.gpbEnvio.Controls.Add(this.txtIDPedidoEnvio);
            this.gpbEnvio.Controls.Add(this.label11);
            this.gpbEnvio.Location = new System.Drawing.Point(344, 222);
            this.gpbEnvio.Name = "gpbEnvio";
            this.gpbEnvio.Size = new System.Drawing.Size(331, 79);
            this.gpbEnvio.TabIndex = 19;
            this.gpbEnvio.TabStop = false;
            this.gpbEnvio.Text = "Datos del Envío";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Estado del envío";
            // 
            // cmbEstadoEnvio
            // 
            this.cmbEstadoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoEnvio.FormattingEnabled = true;
            this.cmbEstadoEnvio.Items.AddRange(new object[] {
            "En Tránsito",
            "Entregado",
            "Retrasado",
            "Cancelado"});
            this.cmbEstadoEnvio.Location = new System.Drawing.Point(130, 19);
            this.cmbEstadoEnvio.Name = "cmbEstadoEnvio";
            this.cmbEstadoEnvio.Size = new System.Drawing.Size(194, 21);
            this.cmbEstadoEnvio.TabIndex = 18;
            // 
            // txtIDPedidoEnvio
            // 
            this.txtIDPedidoEnvio.Location = new System.Drawing.Point(130, 46);
            this.txtIDPedidoEnvio.Name = "txtIDPedidoEnvio";
            this.txtIDPedidoEnvio.ReadOnly = true;
            this.txtIDPedidoEnvio.Size = new System.Drawing.Size(194, 20);
            this.txtIDPedidoEnvio.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "ID del Envío";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCorreoCliente);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtDireccionCliente);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtApellidosCliente);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Location = new System.Drawing.Point(345, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 133);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Cliente";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(130, 103);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(194, 20);
            this.txtCorreoCliente.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Correo";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(130, 75);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(194, 20);
            this.txtDireccionCliente.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Dirección";
            // 
            // txtApellidosCliente
            // 
            this.txtApellidosCliente.Location = new System.Drawing.Point(130, 49);
            this.txtApellidosCliente.Name = "txtApellidosCliente";
            this.txtApellidosCliente.ReadOnly = true;
            this.txtApellidosCliente.Size = new System.Drawing.Size(194, 20);
            this.txtApellidosCliente.TabIndex = 12;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 50);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(44, 13);
            this.label31.TabIndex = 11;
            this.label31.Text = "Apellido";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(130, 23);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(194, 20);
            this.txtNombreCliente.TabIndex = 10;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 24);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 13);
            this.label32.TabIndex = 9;
            this.label32.Text = "Nombre";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(131, 203);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.ReadOnly = true;
            this.txtNoFactura.Size = new System.Drawing.Size(194, 20);
            this.txtNoFactura.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "No. Factura";
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(579, 307);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(96, 23);
            this.btnGenerarReporte.TabIndex = 25;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click_1);
            // 
            // frmReportesBodegasTransportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 369);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBuscarPedido);
            this.Controls.Add(this.gpbPedido);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmReportesBodegasTransportes";
            this.Text = "frmReportesBodegasTransportes";
            this.Load += new System.EventHandler(this.frmReportesBodegasTransportes_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbPedido.ResumeLayout(false);
            this.gpbPedido.PerformLayout();
            this.gpbEnvio.ResumeLayout(false);
            this.gpbEnvio.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.GroupBox gpbPedido;
        private System.Windows.Forms.ComboBox cmbBuscarPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaSolicitud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtEnvio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbEnvio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEstadoEnvio;
        private System.Windows.Forms.TextBox txtIDPedidoEnvio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtApellidosCliente;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtNoFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGenerarReporte;
    }
}