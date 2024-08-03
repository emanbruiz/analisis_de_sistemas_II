
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
            this.btnActualizarDatosUsuarios = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnNuevosUsuarios = new System.Windows.Forms.Button();
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
            this.btnGestionPersonal = new System.Windows.Forms.Button();
            this.btnReportesPersonal = new System.Windows.Forms.Button();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
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
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 59);
            this.pnlMain.TabIndex = 2;
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnLogs);
            this.gbxBotones.Controls.Add(this.btnProductos);
            this.gbxBotones.Controls.Add(this.btnActualizarDatosUsuarios);
            this.gbxBotones.Controls.Add(this.btnRoles);
            this.gbxBotones.Controls.Add(this.btnNuevosUsuarios);
            this.gbxBotones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxBotones.ForeColor = System.Drawing.Color.White;
            this.gbxBotones.Location = new System.Drawing.Point(75, 0);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(607, 59);
            this.gbxBotones.TabIndex = 6;
            this.gbxBotones.TabStop = false;
            this.gbxBotones.Text = "Opciones";
            // 
            // btnLogs
            // 
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogs.Location = new System.Drawing.Point(538, 22);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(63, 23);
            this.btnLogs.TabIndex = 4;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Visible = false;
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Location = new System.Drawing.Point(413, 22);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(119, 23);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "Añadir Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnActualizarDatosUsuarios
            // 
            this.btnActualizarDatosUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarDatosUsuarios.Location = new System.Drawing.Point(250, 22);
            this.btnActualizarDatosUsuarios.Name = "btnActualizarDatosUsuarios";
            this.btnActualizarDatosUsuarios.Size = new System.Drawing.Size(157, 23);
            this.btnActualizarDatosUsuarios.TabIndex = 2;
            this.btnActualizarDatosUsuarios.Text = "Actualizar Datos Usuario";
            this.btnActualizarDatosUsuarios.UseVisualStyleBackColor = true;
            this.btnActualizarDatosUsuarios.Click += new System.EventHandler(this.btnActualizarDatosUsuarios_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Enabled = false;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoles.Location = new System.Drawing.Point(130, 22);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(114, 23);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Gestionar Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnNuevosUsuarios
            // 
            this.btnNuevosUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevosUsuarios.Location = new System.Drawing.Point(10, 22);
            this.btnNuevosUsuarios.Name = "btnNuevosUsuarios";
            this.btnNuevosUsuarios.Size = new System.Drawing.Size(114, 23);
            this.btnNuevosUsuarios.TabIndex = 0;
            this.btnNuevosUsuarios.Text = "Registrar Usuario";
            this.btnNuevosUsuarios.UseVisualStyleBackColor = true;
            this.btnNuevosUsuarios.Click += new System.EventHandler(this.btnNuevosUsuarios_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightPink;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Image = global::AdminRepartoApp.Properties.Resources.cerrar_sesion__1_;
            this.btnCerrarSesion.Location = new System.Drawing.Point(690, 22);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(110, 25);
            this.btnCerrarSesion.TabIndex = 1;
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
            this.lblMain.Location = new System.Drawing.Point(12, 18);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(64, 25);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Menú";
            this.lblMain.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // txtInformativo
            // 
            this.txtInformativo.AutoSize = true;
            this.txtInformativo.ForeColor = System.Drawing.Color.Black;
            this.txtInformativo.Location = new System.Drawing.Point(3, 62);
            this.txtInformativo.Name = "txtInformativo";
            this.txtInformativo.Size = new System.Drawing.Size(110, 13);
            this.txtInformativo.TabIndex = 3;
            this.txtInformativo.Text = "Sesión iniciada como:";
            // 
            // lblUsuarioMain
            // 
            this.lblUsuarioMain.AutoSize = true;
            this.lblUsuarioMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioMain.Location = new System.Drawing.Point(110, 62);
            this.lblUsuarioMain.Name = "lblUsuarioMain";
            this.lblUsuarioMain.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioMain.TabIndex = 4;
            // 
            // lblUsuarioIniciado
            // 
            this.lblUsuarioIniciado.AutoSize = true;
            this.lblUsuarioIniciado.BackColor = System.Drawing.Color.White;
            this.lblUsuarioIniciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioIniciado.Location = new System.Drawing.Point(110, 62);
            this.lblUsuarioIniciado.Name = "lblUsuarioIniciado";
            this.lblUsuarioIniciado.Size = new System.Drawing.Size(50, 13);
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
            this.panel1.Controls.Add(this.btnGestionPersonal);
            this.panel1.Controls.Add(this.btnReportesPersonal);
            this.panel1.Location = new System.Drawing.Point(0, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 303);
            this.panel1.TabIndex = 6;
            // 
            // btnClientesPilotos
            // 
            this.btnClientesPilotos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientesPilotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientesPilotos.Location = new System.Drawing.Point(3, 268);
            this.btnClientesPilotos.Name = "btnClientesPilotos";
            this.btnClientesPilotos.Size = new System.Drawing.Size(161, 23);
            this.btnClientesPilotos.TabIndex = 12;
            this.btnClientesPilotos.Text = "Clientes y Pilotos";
            this.btnClientesPilotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientesPilotos.UseVisualStyleBackColor = true;
            this.btnClientesPilotos.Click += new System.EventHandler(this.btnClientesPilotos_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerProductos.Location = new System.Drawing.Point(4, 8);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(161, 23);
            this.btnVerProductos.TabIndex = 6;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnGestionPedidos
            // 
            this.btnGestionPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPedidos.Location = new System.Drawing.Point(3, 226);
            this.btnGestionPedidos.Name = "btnGestionPedidos";
            this.btnGestionPedidos.Size = new System.Drawing.Size(161, 23);
            this.btnGestionPedidos.TabIndex = 11;
            this.btnGestionPedidos.Text = "Gestión Pedidos";
            this.btnGestionPedidos.UseVisualStyleBackColor = true;
            this.btnGestionPedidos.Click += new System.EventHandler(this.btnGestionPedidos_Click);
            // 
            // btnReportesBodegasTransportes
            // 
            this.btnReportesBodegasTransportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportesBodegasTransportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesBodegasTransportes.Location = new System.Drawing.Point(4, 174);
            this.btnReportesBodegasTransportes.Name = "btnReportesBodegasTransportes";
            this.btnReportesBodegasTransportes.Size = new System.Drawing.Size(161, 36);
            this.btnReportesBodegasTransportes.TabIndex = 10;
            this.btnReportesBodegasTransportes.Text = "Reportes Bodegas y Trasportes";
            this.btnReportesBodegasTransportes.UseVisualStyleBackColor = true;
            this.btnReportesBodegasTransportes.Click += new System.EventHandler(this.btnReportesBodegasTransportes_Click);
            // 
            // btnBodegasTransportes
            // 
            this.btnBodegasTransportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBodegasTransportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodegasTransportes.Location = new System.Drawing.Point(2, 138);
            this.btnBodegasTransportes.Name = "btnBodegasTransportes";
            this.btnBodegasTransportes.Size = new System.Drawing.Size(161, 23);
            this.btnBodegasTransportes.TabIndex = 9;
            this.btnBodegasTransportes.Text = "Bodegas y Transportes";
            this.btnBodegasTransportes.UseVisualStyleBackColor = true;
            this.btnBodegasTransportes.Click += new System.EventHandler(this.btnBodegasTransportes_Click);
            // 
            // btnGestionPersonal
            // 
            this.btnGestionPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGestionPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionPersonal.Location = new System.Drawing.Point(3, 49);
            this.btnGestionPersonal.Name = "btnGestionPersonal";
            this.btnGestionPersonal.Size = new System.Drawing.Size(161, 23);
            this.btnGestionPersonal.TabIndex = 7;
            this.btnGestionPersonal.Text = "Gestión de Personal";
            this.btnGestionPersonal.UseVisualStyleBackColor = true;
            this.btnGestionPersonal.Click += new System.EventHandler(this.btnGestionPersonal_Click);
            // 
            // btnReportesPersonal
            // 
            this.btnReportesPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportesPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesPersonal.Location = new System.Drawing.Point(2, 93);
            this.btnReportesPersonal.Name = "btnReportesPersonal";
            this.btnReportesPersonal.Size = new System.Drawing.Size(161, 23);
            this.btnReportesPersonal.TabIndex = 8;
            this.btnReportesPersonal.Text = "Reportes Personal";
            this.btnReportesPersonal.UseVisualStyleBackColor = true;
            this.btnReportesPersonal.Click += new System.EventHandler(this.btnReportesPersonal_Click);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Location = new System.Drawing.Point(700, 65);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(0, 13);
            this.lblFechaHora.TabIndex = 0;
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Interval = 1000;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsuarioIniciado);
            this.Controls.Add(this.lblUsuarioMain);
            this.Controls.Add(this.txtInformativo);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnActualizarDatosUsuarios;
        private System.Windows.Forms.Button btnRoles;
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
    }
}