
namespace AdminRepartoApp
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.lblDPI = new System.Windows.Forms.Label();
            this.btnRegisterCliente = new System.Windows.Forms.Button();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblRegister);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(442, 59);
            this.pnlMain.TabIndex = 1;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(139, 20);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(164, 25);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Registrar usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(12, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(301, 25);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Ingrese los nombres del usuario:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(17, 109);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(396, 20);
            this.txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(17, 164);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(396, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.Black;
            this.lblApellidos.Location = new System.Drawing.Point(12, 136);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(306, 25);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Ingrese los apellidos  del usuario:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(17, 215);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(396, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(12, 187);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(376, 25);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Ingrese la dirección personal del usuario:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(17, 272);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(396, 20);
            this.txtMail.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(12, 244);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(271, 25);
            this.txtCorreo.TabIndex = 8;
            this.txtCorreo.Text = "Ingrese el correo del usuario:";
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(17, 335);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(396, 20);
            this.txtDPI.TabIndex = 11;
            // 
            // lblDPI
            // 
            this.lblDPI.AutoSize = true;
            this.lblDPI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPI.ForeColor = System.Drawing.Color.Black;
            this.lblDPI.Location = new System.Drawing.Point(12, 307);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(244, 25);
            this.lblDPI.TabIndex = 10;
            this.lblDPI.Text = "Ingrese el DPI del usuario:";
            // 
            // btnRegisterCliente
            // 
            this.btnRegisterCliente.Location = new System.Drawing.Point(136, 411);
            this.btnRegisterCliente.Name = "btnRegisterCliente";
            this.btnRegisterCliente.Size = new System.Drawing.Size(171, 48);
            this.btnRegisterCliente.TabIndex = 12;
            this.btnRegisterCliente.Text = "Añadir Usuario";
            this.btnRegisterCliente.UseVisualStyleBackColor = true;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmacion.Location = new System.Drawing.Point(144, 462);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(165, 13);
            this.lblConfirmacion.TabIndex = 13;
            this.lblConfirmacion.Text = "Este usuario ya ha sido registrado";
            this.lblConfirmacion.Visible = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 532);
            this.Controls.Add(this.lblConfirmacion);
            this.Controls.Add(this.btnRegisterCliente);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.lblDPI);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegister";
            this.Text = "Añadir usuario";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label lblDPI;
        private System.Windows.Forms.Button btnRegisterCliente;
        private System.Windows.Forms.Label lblConfirmacion;
    }
}