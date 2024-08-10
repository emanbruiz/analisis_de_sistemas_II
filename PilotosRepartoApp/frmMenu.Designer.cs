
namespace PilotosRepartoApp
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblFyH = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblInformativo = new System.Windows.Forms.Label();
            this.btnVerRutas = new System.Windows.Forms.Button();
            this.btnVerPedidos = new System.Windows.Forms.Button();
            this.btnRegistroEntregas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFyH
            // 
            this.lblFyH.AutoSize = true;
            this.lblFyH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFyH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblFyH.Location = new System.Drawing.Point(185, 15);
            this.lblFyH.Name = "lblFyH";
            this.lblFyH.Size = new System.Drawing.Size(69, 13);
            this.lblFyH.TabIndex = 6;
            this.lblFyH.Text = "FechaHora";
            this.lblFyH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Lime;
            this.lblFecha.Location = new System.Drawing.Point(144, 15);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMenu.Location = new System.Drawing.Point(10, 7);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(63, 24);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(113)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.lblFyH);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.lblMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 42);
            this.panel2.TabIndex = 6;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogOut.Location = new System.Drawing.Point(392, 11);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(94, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Cerrar Sesión";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(125, 46);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Usuario";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInformativo
            // 
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.Location = new System.Drawing.Point(2, 46);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(125, 13);
            this.lblInformativo.TabIndex = 8;
            this.lblInformativo.Text = "Ha iniciado sesión como:";
            // 
            // btnVerRutas
            // 
            this.btnVerRutas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerRutas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerRutas.Location = new System.Drawing.Point(0, 62);
            this.btnVerRutas.Name = "btnVerRutas";
            this.btnVerRutas.Size = new System.Drawing.Size(153, 23);
            this.btnVerRutas.TabIndex = 3;
            this.btnVerRutas.Text = "Ver Rutas";
            this.btnVerRutas.UseVisualStyleBackColor = true;
            this.btnVerRutas.Click += new System.EventHandler(this.btnVerRutas_Click);
            // 
            // btnVerPedidos
            // 
            this.btnVerPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerPedidos.Location = new System.Drawing.Point(1, 3);
            this.btnVerPedidos.Name = "btnVerPedidos";
            this.btnVerPedidos.Size = new System.Drawing.Size(153, 23);
            this.btnVerPedidos.TabIndex = 1;
            this.btnVerPedidos.Text = "Ver Pedidos";
            this.btnVerPedidos.UseVisualStyleBackColor = true;
            this.btnVerPedidos.Click += new System.EventHandler(this.btnVerPedidos_Click);
            // 
            // btnRegistroEntregas
            // 
            this.btnRegistroEntregas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistroEntregas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegistroEntregas.Location = new System.Drawing.Point(1, 32);
            this.btnRegistroEntregas.Name = "btnRegistroEntregas";
            this.btnRegistroEntregas.Size = new System.Drawing.Size(153, 23);
            this.btnRegistroEntregas.TabIndex = 2;
            this.btnRegistroEntregas.Text = "Actualizar Pedido";
            this.btnRegistroEntregas.UseVisualStyleBackColor = true;
            this.btnRegistroEntregas.Click += new System.EventHandler(this.btnRegistroEntregas_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(113)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.btnVerPerfil);
            this.panel3.Controls.Add(this.btnVerRutas);
            this.panel3.Controls.Add(this.btnVerPedidos);
            this.panel3.Controls.Add(this.btnRegistroEntregas);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(4, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(155, 123);
            this.panel3.TabIndex = 7;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnVerPerfil.Location = new System.Drawing.Point(0, 91);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(153, 23);
            this.btnVerPerfil.TabIndex = 4;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(490, 228);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInformativo);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFyH;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.Button btnVerRutas;
        private System.Windows.Forms.Button btnVerPedidos;
        private System.Windows.Forms.Button btnRegistroEntregas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}