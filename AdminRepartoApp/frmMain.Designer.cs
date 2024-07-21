
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblMain = new System.Windows.Forms.Label();
            this.txtInformativo = new System.Windows.Forms.Label();
            this.lblUsuarioMain = new System.Windows.Forms.Label();
            this.lblUsuarioIniciado = new System.Windows.Forms.Label();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnNuevosUsuarios = new System.Windows.Forms.Button();
            this.btnRoles = new System.Windows.Forms.Button();
            this.btnActualizarDatosUsuarios = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.btnDatosClientes = new System.Windows.Forms.Button();
            this.btnVerPilotos = new System.Windows.Forms.Button();
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
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightPink;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Image = global::AdminRepartoApp.Properties.Resources.cerrar_sesion__1_;
            this.btnCerrarSesion.Location = new System.Drawing.Point(687, 18);
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
            this.lblUsuarioIniciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioIniciado.Location = new System.Drawing.Point(110, 62);
            this.lblUsuarioIniciado.Name = "lblUsuarioIniciado";
            this.lblUsuarioIniciado.Size = new System.Drawing.Size(50, 13);
            this.lblUsuarioIniciado.TabIndex = 5;
            this.lblUsuarioIniciado.Text = "Usuario";
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnLogs);
            this.gbxBotones.Controls.Add(this.btnStock);
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
            // btnNuevosUsuarios
            // 
            this.btnNuevosUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevosUsuarios.Location = new System.Drawing.Point(10, 22);
            this.btnNuevosUsuarios.Name = "btnNuevosUsuarios";
            this.btnNuevosUsuarios.Size = new System.Drawing.Size(114, 23);
            this.btnNuevosUsuarios.TabIndex = 0;
            this.btnNuevosUsuarios.Text = "Registrar Usuario";
            this.btnNuevosUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnRoles
            // 
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRoles.Location = new System.Drawing.Point(130, 22);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(114, 23);
            this.btnRoles.TabIndex = 1;
            this.btnRoles.Text = "Gestionar Roles";
            this.btnRoles.UseVisualStyleBackColor = true;
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
            // 
            // btnStock
            // 
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStock.Location = new System.Drawing.Point(413, 22);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(110, 23);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Actualizar Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogs.Location = new System.Drawing.Point(529, 22);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(72, 23);
            this.btnLogs.TabIndex = 4;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = true;
            this.btnLogs.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(155)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.btnVerPilotos);
            this.panel1.Controls.Add(this.btnDatosClientes);
            this.panel1.Controls.Add(this.btnVerPedidos);
            this.panel1.Location = new System.Drawing.Point(0, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 122);
            this.panel1.TabIndex = 6;
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPedidos.Location = new System.Drawing.Point(4, 3);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(161, 23);
            this.btnVerPedidos.TabIndex = 1;
            this.btnVerPedidos.Text = "Ver Pedidos Pendientes";
            this.btnVerPedidos.UseVisualStyleBackColor = true;
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
            this.timerFechaHora.Interval = 1000; // 1 segundo
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // btnDatosClientes
            // 
            this.btnDatosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatosClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosClientes.Location = new System.Drawing.Point(3, 48);
            this.btnDatosClientes.Name = "btnDatosClientes";
            this.btnDatosClientes.Size = new System.Drawing.Size(161, 23);
            this.btnDatosClientes.TabIndex = 2;
            this.btnDatosClientes.Text = "Ver Clientes";
            this.btnDatosClientes.UseVisualStyleBackColor = true;
            // 
            // btnVerPilotos
            // 
            this.btnVerPilotos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPilotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPilotos.Location = new System.Drawing.Point(3, 93);
            this.btnVerPilotos.Name = "btnVerPilotos";
            this.btnVerPilotos.Size = new System.Drawing.Size(161, 23);
            this.btnVerPilotos.TabIndex = 3;
            this.btnVerPilotos.Text = "Ver Pilotos";
            this.btnVerPilotos.UseVisualStyleBackColor = true;
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(133)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblUsuarioIniciado);
            this.Controls.Add(this.lblUsuarioMain);
            this.Controls.Add(this.txtInformativo);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnActualizarDatosUsuarios;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnNuevosUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Button btnVerPilotos;
        private System.Windows.Forms.Button btnDatosClientes;
        private System.Windows.Forms.Timer timerFechaHora;
    }
}