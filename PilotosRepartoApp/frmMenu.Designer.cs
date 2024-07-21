
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnResumenDeEntregas = new System.Windows.Forms.Button();
            this.btnActualizarPedido = new System.Windows.Forms.Button();
            this.btnMapa = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(176)))), ((int)(((byte)(17)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 58);
            this.panel1.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(240)))), ((int)(((byte)(17)))));
            this.lblMenu.Location = new System.Drawing.Point(12, 18);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(53, 20);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú";
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(12, 64);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(120, 23);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos Asignados";
            this.btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnResumenDeEntregas
            // 
            this.btnResumenDeEntregas.Location = new System.Drawing.Point(138, 64);
            this.btnResumenDeEntregas.Name = "btnResumenDeEntregas";
            this.btnResumenDeEntregas.Size = new System.Drawing.Size(120, 23);
            this.btnResumenDeEntregas.TabIndex = 2;
            this.btnResumenDeEntregas.Text = "Resumen de entregas";
            this.btnResumenDeEntregas.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPedido
            // 
            this.btnActualizarPedido.Location = new System.Drawing.Point(264, 64);
            this.btnActualizarPedido.Name = "btnActualizarPedido";
            this.btnActualizarPedido.Size = new System.Drawing.Size(120, 23);
            this.btnActualizarPedido.TabIndex = 3;
            this.btnActualizarPedido.Text = "ActualizarPedido";
            this.btnActualizarPedido.UseVisualStyleBackColor = true;
            // 
            // btnMapa
            // 
            this.btnMapa.Location = new System.Drawing.Point(390, 64);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(55, 23);
            this.btnMapa.TabIndex = 4;
            this.btnMapa.Text = "Mapa";
            this.btnMapa.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Location = new System.Drawing.Point(346, 18);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(96, 23);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 570);
            this.Controls.Add(this.btnMapa);
            this.Controls.Add(this.btnActualizarPedido);
            this.Controls.Add(this.btnResumenDeEntregas);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnResumenDeEntregas;
        private System.Windows.Forms.Button btnActualizarPedido;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}