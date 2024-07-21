
namespace ClientesRepartoApp
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lnklblContrasena = new System.Windows.Forms.LinkLabel();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(44)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 62);
            this.panel1.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(119, 21);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 24);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(185, 256);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(86, 23);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(26, 135);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(38, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo";
            // 
            // lnklblContrasena
            // 
            this.lnklblContrasena.AutoSize = true;
            this.lnklblContrasena.Location = new System.Drawing.Point(26, 235);
            this.lnklblContrasena.Name = "lnklblContrasena";
            this.lnklblContrasena.Size = new System.Drawing.Size(119, 13);
            this.lnklblContrasena.TabIndex = 3;
            this.lnklblContrasena.TabStop = true;
            this.lnklblContrasena.Text = "¿Olvidó su contraseña?";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(29, 151);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(242, 20);
            this.txtCorreo.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 6;
            // 
            // txtContrasena
            // 
            this.txtContrasena.AutoSize = true;
            this.txtContrasena.Location = new System.Drawing.Point(26, 185);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(61, 13);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.Text = "Contraseña";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(29, 256);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(86, 23);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Text = "Registrarse";
            this.btnRegistro.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 297);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lnklblContrasena);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.LinkLabel lnklblContrasena;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtContrasena;
        private System.Windows.Forms.Button btnRegistro;
    }
}

