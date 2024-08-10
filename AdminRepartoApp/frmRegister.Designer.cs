
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.chkEditarPermiso = new System.Windows.Forms.CheckBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkAnadir = new System.Windows.Forms.CheckBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
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
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(765, 64);
            this.pnlMain.TabIndex = 1;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(13, 18);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(211, 32);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Registrar usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(16, 82);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(214, 17);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Ingrese los nombres del usuario:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(299, 82);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(449, 22);
            this.txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(299, 123);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(449, 22);
            this.txtApellidos.TabIndex = 2;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.Black;
            this.lblApellidos.Location = new System.Drawing.Point(16, 123);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(219, 17);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Ingrese los apellidos  del usuario:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(299, 213);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(449, 22);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(16, 213);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(268, 17);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Ingrese la dirección personal del usuario:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(299, 253);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(449, 22);
            this.txtMail.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtCorreo.Location = new System.Drawing.Point(16, 253);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(193, 17);
            this.txtCorreo.TabIndex = 8;
            this.txtCorreo.Text = "Ingrese el correo del usuario:";
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(299, 286);
            this.txtDPI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(449, 22);
            this.txtDPI.TabIndex = 6;
            // 
            // lblDPI
            // 
            this.lblDPI.AutoSize = true;
            this.lblDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPI.ForeColor = System.Drawing.Color.Black;
            this.lblDPI.Location = new System.Drawing.Point(16, 286);
            this.lblDPI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(174, 17);
            this.lblDPI.TabIndex = 10;
            this.lblDPI.Text = "Ingrese el DPI del usuario:";
            // 
            // btnRegisterCliente
            // 
            this.btnRegisterCliente.Location = new System.Drawing.Point(553, 489);
            this.btnRegisterCliente.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegisterCliente.Name = "btnRegisterCliente";
            this.btnRegisterCliente.Size = new System.Drawing.Size(195, 59);
            this.btnRegisterCliente.TabIndex = 13;
            this.btnRegisterCliente.Text = "Añadir Usuario";
            this.btnRegisterCliente.UseVisualStyleBackColor = true;
            this.btnRegisterCliente.Click += new System.EventHandler(this.btnRegisterCliente_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(299, 322);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(449, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblContrasena.Location = new System.Drawing.Point(16, 322);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(245, 17);
            this.lblContrasena.TabIndex = 14;
            this.lblContrasena.Text = "Establezca la contraseña del usuario:";
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarios.Items.AddRange(new object[] {
            "07:00 - 16:00",
            "08:00 - 17:00",
            "17:00 - 02:00"});
            this.cmbHorarios.Location = new System.Drawing.Point(299, 398);
            this.cmbHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(449, 24);
            this.cmbHorarios.TabIndex = 9;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.Color.Black;
            this.lblHorario.Location = new System.Drawing.Point(16, 398);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(219, 17);
            this.lblHorario.TabIndex = 17;
            this.lblHorario.Text = "Seleccione el horario del usuario:";
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.ForeColor = System.Drawing.Color.Black;
            this.lblPermisos.Location = new System.Drawing.Point(16, 431);
            this.lblPermisos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(66, 17);
            this.lblPermisos.TabIndex = 18;
            this.lblPermisos.Text = "Permisos";
            // 
            // chkEditarPermiso
            // 
            this.chkEditarPermiso.AutoSize = true;
            this.chkEditarPermiso.Location = new System.Drawing.Point(17, 461);
            this.chkEditarPermiso.Margin = new System.Windows.Forms.Padding(4);
            this.chkEditarPermiso.Name = "chkEditarPermiso";
            this.chkEditarPermiso.Size = new System.Drawing.Size(119, 21);
            this.chkEditarPermiso.TabIndex = 10;
            this.chkEditarPermiso.Text = "Permitir Editar";
            this.chkEditarPermiso.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(17, 494);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(132, 21);
            this.chkEliminar.TabIndex = 11;
            this.chkEliminar.Text = "Permitir Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkAnadir
            // 
            this.chkAnadir.AutoSize = true;
            this.chkAnadir.Location = new System.Drawing.Point(17, 527);
            this.chkAnadir.Margin = new System.Windows.Forms.Padding(4);
            this.chkAnadir.Name = "chkAnadir";
            this.chkAnadir.Size = new System.Drawing.Size(235, 21);
            this.chkAnadir.TabIndex = 12;
            this.chkAnadir.Text = "Permitir Añadir Usuarios Nuevos";
            this.chkAnadir.UseVisualStyleBackColor = true;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblTipoUsuario.Location = new System.Drawing.Point(16, 359);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(209, 17);
            this.lblTipoUsuario.TabIndex = 23;
            this.lblTipoUsuario.Text = "Seleccione el tipo de empleado:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Bodega",
            "Gerente",
            "Vendedor",
            "Compras"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(299, 359);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(449, 24);
            this.cmbTipoUsuario.TabIndex = 8;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Black;
            this.lblGenero.Location = new System.Drawing.Point(16, 167);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(215, 17);
            this.lblGenero.TabIndex = 25;
            this.lblGenero.Text = "Seleccione el género del usuario";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(299, 167);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(449, 24);
            this.cmbGenero.TabIndex = 3;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 570);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.chkAnadir);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.chkEditarPermiso);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cmbHorarios);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblContrasena);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmRegister";
            this.Opacity = 0.97D;
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
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.CheckBox chkEditarPermiso;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.CheckBox chkAnadir;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
    }
}