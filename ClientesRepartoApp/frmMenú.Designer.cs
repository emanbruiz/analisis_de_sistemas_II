
namespace ClientesRepartoApp
{
    partial class frmMenú
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
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnPedidosPendientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRealizarPedidos = new System.Windows.Forms.Button();
            this.btnPedidosRealizados = new System.Windows.Forms.Button();
            this.lblInformativo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(44)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCerrarSesión);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 62);
            this.panel1.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(12, 21);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(63, 24);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú";
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesión.Location = new System.Drawing.Point(694, 21);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(94, 23);
            this.btnCerrarSesión.TabIndex = 1;
            this.btnCerrarSesión.Text = "Cerrar Sesión";
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            // 
            // btnPedidosPendientes
            // 
            this.btnPedidosPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidosPendientes.Location = new System.Drawing.Point(0, -2);
            this.btnPedidosPendientes.Name = "btnPedidosPendientes";
            this.btnPedidosPendientes.Size = new System.Drawing.Size(153, 23);
            this.btnPedidosPendientes.TabIndex = 2;
            this.btnPedidosPendientes.Text = "Pedidos Pendientes";
            this.btnPedidosPendientes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(44)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 62);
            this.panel2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(694, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(95)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.btnPerfil);
            this.panel3.Controls.Add(this.btnPedidosRealizados);
            this.panel3.Controls.Add(this.btnRealizarPedidos);
            this.panel3.Controls.Add(this.btnPedidosPendientes);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 129);
            this.panel3.TabIndex = 3;
            // 
            // btnRealizarPedidos
            // 
            this.btnRealizarPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRealizarPedidos.Location = new System.Drawing.Point(1, 33);
            this.btnRealizarPedidos.Name = "btnRealizarPedidos";
            this.btnRealizarPedidos.Size = new System.Drawing.Size(153, 23);
            this.btnRealizarPedidos.TabIndex = 3;
            this.btnRealizarPedidos.Text = "Realizar Pedidos";
            this.btnRealizarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnPedidosRealizados
            // 
            this.btnPedidosRealizados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidosRealizados.Location = new System.Drawing.Point(-1, 67);
            this.btnPedidosRealizados.Name = "btnPedidosRealizados";
            this.btnPedidosRealizados.Size = new System.Drawing.Size(153, 23);
            this.btnPedidosRealizados.TabIndex = 4;
            this.btnPedidosRealizados.Text = "Pedidos Realizados";
            this.btnPedidosRealizados.UseVisualStyleBackColor = true;
            // 
            // lblInformativo
            // 
            this.lblInformativo.AutoSize = true;
            this.lblInformativo.Location = new System.Drawing.Point(531, 65);
            this.lblInformativo.Name = "lblInformativo";
            this.lblInformativo.Size = new System.Drawing.Size(125, 13);
            this.lblInformativo.TabIndex = 4;
            this.lblInformativo.Text = "Ha iniciado sesión como:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(150, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnPerfil
            // 
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPerfil.Location = new System.Drawing.Point(1, 96);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(153, 23);
            this.btnPerfil.TabIndex = 5;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            // 
            // frmMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 191);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInformativo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmMenú";
            this.Text = "frmMenú";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Button btnPedidosPendientes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Button btnPedidosRealizados;
        private System.Windows.Forms.Button btnRealizarPedidos;
        private System.Windows.Forms.Label lblInformativo;
        private System.Windows.Forms.Label label2;
    }
}