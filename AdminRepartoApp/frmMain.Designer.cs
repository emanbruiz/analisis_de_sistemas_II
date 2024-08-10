
namespace AdminRepartoApp
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnNuevosUsuarios = new System.Windows.Forms.Button();
            this.btnGestionPersonal = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtInformativo = new System.Windows.Forms.Label();
            this.lblUsuarioMain = new System.Windows.Forms.Label();
            this.lblUsuarioIniciado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClientesPilotos = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnGestionPedidos = new System.Windows.Forms.Button();
            this.btnReportesBodegasTransportes = new System.Windows.Forms.Button();
            this.btnBodegasTransportes = new System.Windows.Forms.Button();
            this.btnReportesPersonal = new System.Windows.Forms.Button();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pnlMain.SuspendLayout();
            this.gbxBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.gbxBotones);
            this.pnlMain.Controls.Add(this.btnCerrarSesion);
            this.pnlMain.Controls.Add(this.lblMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1067, 73);
            this.pnlMain.TabIndex = 2;
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnLogs);
            this.gbxBotones.Controls.Add(this.btnProductos);
            this.gbxBotones.Controls.Add(this.btnNuevosUsuarios);
            this.gbxBotones.Controls.Add(this.btnGestionPersonal);
            this.gbxBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBotones.ForeColor = System.Drawing.Color.White;
            this.gbxBotones.Location = new System.Drawing.Point(100, 0);
            this.gbxBotones.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBotones.Size = new System.Drawing.Size(809, 73);
            this.gbxBotones.TabIndex = 6;
            this.gbxBotones.TabStop = false;
            this.gbxBotones.Text = "Opciones";
            // 
            // btnLogs
            // 
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogs.Location = new System.Drawing.Point(691, 28);
            this.btnLogs.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(84, 28);
            this.btnLogs.TabIndex = 3;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Visible = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Location = new System.Drawing.Point(483, 28);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(159, 28);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Añadir Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnNuevosUsuarios
            // 
            this.btnNuevosUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevosUsuarios.Location = new System.Drawing.Point(37, 30);
            this.btnNuevosUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevosUsuarios.Name = "btnNuevosUsuarios";
            this.btnNuevosUsuarios.Size = new System.Drawing.Size(152, 28);
            this.btnNuevosUsuarios.TabIndex = 0;
            this.btnNuevosUsuarios.Text = "Registrar Usuario";
            this.btnNuevosUsuarios.UseVisualStyleBackColor = true;
            this.btnNuevosUsuarios.Click += new System.EventHandler(this.btnNuevosUsuarios_Click);
            // 
            // btnGestionPersonal
            // 
            this.btnGestionPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPersonal.Location = new System.Drawing.Point(229, 28);
            this.btnGestionPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionPersonal.Name = "btnGestionPersonal";
            this.btnGestionPersonal.Size = new System.Drawing.Size(215, 28);
            this.btnGestionPersonal.TabIndex = 1;
            this.btnGestionPersonal.Text = "Gestión de Personal";
            this.btnGestionPersonal.UseVisualStyleBackColor = true;
            this.btnGestionPersonal.Click += new System.EventHandler(this.btnGestionPersonal_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightPink;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Image = global::AdminRepartoApp.Properties.Resources.cerrar_sesion__1_;
            this.btnCerrarSesion.Location = new System.Drawing.Point(916, 22);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(147, 31);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(16, 22);
            this.lblMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(81, 32);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Menú";
            this.lblMain.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // txtInformativo
            // 
            this.txtInformativo.AutoSize = true;
            this.txtInformativo.ForeColor = System.Drawing.Color.Black;
            this.txtInformativo.Location = new System.Drawing.Point(4, 76);
            this.txtInformativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtInformativo.Name = "txtInformativo";
            this.txtInformativo.Size = new System.Drawing.Size(145, 17);
            this.txtInformativo.TabIndex = 3;
            this.txtInformativo.Text = "Sesión iniciada como:";
            // 
            // lblUsuarioMain
            // 
            this.lblUsuarioMain.AutoSize = true;
            this.lblUsuarioMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioMain.Location = new System.Drawing.Point(147, 76);
            this.lblUsuarioMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioMain.Name = "lblUsuarioMain";
            this.lblUsuarioMain.Size = new System.Drawing.Size(0, 17);
            this.lblUsuarioMain.TabIndex = 4;
            // 
            // lblUsuarioIniciado
            // 
            this.lblUsuarioIniciado.AutoSize = true;
            this.lblUsuarioIniciado.BackColor = System.Drawing.Color.White;
            this.lblUsuarioIniciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioIniciado.Location = new System.Drawing.Point(147, 76);
            this.lblUsuarioIniciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioIniciado.Name = "lblUsuarioIniciado";
            this.lblUsuarioIniciado.Size = new System.Drawing.Size(64, 17);
            this.lblUsuarioIniciado.TabIndex = 5;
            this.lblUsuarioIniciado.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(155)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.btnClientesPilotos);
            this.panel1.Controls.Add(this.btnVerProductos);
            this.panel1.Controls.Add(this.btnGestionPedidos);
            this.panel1.Controls.Add(this.btnReportesBodegasTransportes);
            this.panel1.Controls.Add(this.btnBodegasTransportes);
            this.panel1.Controls.Add(this.btnReportesPersonal);
            this.panel1.Location = new System.Drawing.Point(0, 135);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 320);
            this.panel1.TabIndex = 6;
            // 
            // btnClientesPilotos
            // 
            this.btnClientesPilotos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientesPilotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesPilotos.Location = new System.Drawing.Point(3, 274);
            this.btnClientesPilotos.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientesPilotos.Name = "btnClientesPilotos";
            this.btnClientesPilotos.Size = new System.Drawing.Size(215, 28);
            this.btnClientesPilotos.TabIndex = 9;
            this.btnClientesPilotos.Text = "Gestión de Clientes";
            this.btnClientesPilotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientesPilotos.UseVisualStyleBackColor = true;
            this.btnClientesPilotos.Click += new System.EventHandler(this.btnClientesPilotos_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.Location = new System.Drawing.Point(5, 10);
            this.btnVerProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(215, 28);
            this.btnVerProductos.TabIndex = 4;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnGestionPedidos
            // 
            this.btnGestionPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPedidos.Location = new System.Drawing.Point(4, 225);
            this.btnGestionPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnGestionPedidos.Name = "btnGestionPedidos";
            this.btnGestionPedidos.Size = new System.Drawing.Size(215, 28);
            this.btnGestionPedidos.TabIndex = 8;
            this.btnGestionPedidos.Text = "Gestión de Pedidos";
            this.btnGestionPedidos.UseVisualStyleBackColor = true;
            this.btnGestionPedidos.Click += new System.EventHandler(this.btnGestionPedidos_Click);
            // 
            // btnReportesBodegasTransportes
            // 
            this.btnReportesBodegasTransportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportesBodegasTransportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesBodegasTransportes.Location = new System.Drawing.Point(5, 161);
            this.btnReportesBodegasTransportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportesBodegasTransportes.Name = "btnReportesBodegasTransportes";
            this.btnReportesBodegasTransportes.Size = new System.Drawing.Size(215, 44);
            this.btnReportesBodegasTransportes.TabIndex = 7;
            this.btnReportesBodegasTransportes.Text = "Reportes Bodegas";
            this.btnReportesBodegasTransportes.UseVisualStyleBackColor = true;
            this.btnReportesBodegasTransportes.Click += new System.EventHandler(this.btnReportesBodegasTransportes_Click);
            // 
            // btnBodegasTransportes
            // 
            this.btnBodegasTransportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBodegasTransportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodegasTransportes.Location = new System.Drawing.Point(5, 108);
            this.btnBodegasTransportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnBodegasTransportes.Name = "btnBodegasTransportes";
            this.btnBodegasTransportes.Size = new System.Drawing.Size(215, 28);
            this.btnBodegasTransportes.TabIndex = 6;
            this.btnBodegasTransportes.Text = "Ver Pedidos";
            this.btnBodegasTransportes.UseVisualStyleBackColor = true;
            this.btnBodegasTransportes.Click += new System.EventHandler(this.btnBodegasTransportes_Click);
            // 
            // btnReportesPersonal
            // 
            this.btnReportesPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportesPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesPersonal.Location = new System.Drawing.Point(7, 59);
            this.btnReportesPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportesPersonal.Name = "btnReportesPersonal";
            this.btnReportesPersonal.Size = new System.Drawing.Size(215, 28);
            this.btnReportesPersonal.TabIndex = 5;
            this.btnReportesPersonal.Text = "Reportes Personal";
            this.btnReportesPersonal.UseVisualStyleBackColor = true;
            this.btnReportesPersonal.Click += new System.EventHandler(this.btnReportesPersonal_Click);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(933, 80);
            this.lblFechaHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(0, 17);
            this.lblFechaHora.TabIndex = 0;
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Interval = 1000;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 454);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsuarioIniciado);
            this.Controls.Add(this.lblUsuarioMain);
            this.Controls.Add(this.txtInformativo);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gbxBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label txtInformativo;
        private System.Windows.Forms.Label lblUsuarioMain;
        private System.Windows.Forms.Label lblUsuarioIniciado;
        private System.Windows.Forms.GroupBox gbxBotones;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnNuevosUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.Button btnClientesPilotos;
        private System.Windows.Forms.Button btnGestionPedidos;
        private System.Windows.Forms.Button btnReportesBodegasTransportes;
        private System.Windows.Forms.Button btnBodegasTransportes;
        private System.Windows.Forms.Button btnGestionPersonal;
        private System.Windows.Forms.Button btnReportesPersonal;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}