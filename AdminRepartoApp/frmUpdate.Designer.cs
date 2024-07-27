
namespace AdminRepartoApp
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.chkAnadir = new System.Windows.Forms.CheckBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkEditarPermiso = new System.Windows.Forms.CheckBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.lblDPI = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.btnCargarDatos.Enabled = false;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarDatos.Location = new System.Drawing.Point(441, 121);
            this.btnCargarDatos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(128, 48);
            this.btnCargarDatos.TabIndex = 84;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click_1);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(31, 143);
            this.cmbUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(256, 24);
            this.cmbUsuarios.TabIndex = 83;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Location = new System.Drawing.Point(303, 121);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(128, 48);
            this.btnCargar.TabIndex = 82;
            this.btnCargar.Text = "Cargar Usuarios";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(25, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 32);
            this.label2.TabIndex = 81;
            this.label2.Text = "Seleccione el usuario";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblGenero.Location = new System.Drawing.Point(24, 330);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(385, 32);
            this.lblGenero.TabIndex = 80;
            this.lblGenero.Text = "Seleccione el género del usuario";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(29, 383);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(701, 24);
            this.cmbGenero.TabIndex = 79;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTipoUsuario.Location = new System.Drawing.Point(988, 164);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(377, 32);
            this.lblTipoUsuario.TabIndex = 78;
            this.lblTipoUsuario.Text = "Seleccione el tipo de empleado:";
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Almacenero",
            "Gerente",
            "Piloto",
            "Vendedor",
            ""});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(996, 209);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(511, 24);
            this.cmbTipoUsuario.TabIndex = 77;
            // 
            // chkAnadir
            // 
            this.chkAnadir.AutoSize = true;
            this.chkAnadir.Location = new System.Drawing.Point(996, 473);
            this.chkAnadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAnadir.Name = "chkAnadir";
            this.chkAnadir.Size = new System.Drawing.Size(235, 21);
            this.chkAnadir.TabIndex = 76;
            this.chkAnadir.Text = "Permitir Añadir Usuarios Nuevos";
            this.chkAnadir.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(996, 439);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(132, 21);
            this.chkEliminar.TabIndex = 75;
            this.chkEliminar.Text = "Permitir Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkEditarPermiso
            // 
            this.chkEditarPermiso.AutoSize = true;
            this.chkEditarPermiso.Location = new System.Drawing.Point(996, 406);
            this.chkEditarPermiso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEditarPermiso.Name = "chkEditarPermiso";
            this.chkEditarPermiso.Size = new System.Drawing.Size(119, 21);
            this.chkEditarPermiso.TabIndex = 74;
            this.chkEditarPermiso.Text = "Permitir Editar";
            this.chkEditarPermiso.UseVisualStyleBackColor = true;
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblPermisos.Location = new System.Drawing.Point(988, 359);
            this.lblPermisos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(118, 32);
            this.lblPermisos.TabIndex = 73;
            this.lblPermisos.Text = "Permisos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(988, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 32);
            this.label1.TabIndex = 72;
            this.label1.Text = "Seleccione el horario del usuario:";
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarios.Items.AddRange(new object[] {
            "07:00 - 16:00",
            "08:00 - 17:00",
            "17:00 - 02:00"});
            this.cmbHorarios.Location = new System.Drawing.Point(996, 298);
            this.cmbHorarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(511, 24);
            this.cmbHorarios.TabIndex = 71;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(27, 725);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(701, 22);
            this.txtPassword.TabIndex = 70;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblContrasena.Location = new System.Drawing.Point(20, 677);
            this.lblContrasena.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(435, 32);
            this.lblContrasena.TabIndex = 69;
            this.lblContrasena.Text = "Establezca la contraseña del usuario:";
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.btnActualizarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(1321, 503);
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(195, 59);
            this.btnActualizarUsuario.TabIndex = 68;
            this.btnActualizarUsuario.Text = "Actualizar Usuario";
            this.btnActualizarUsuario.UseVisualStyleBackColor = false;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click_1);
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(29, 634);
            this.txtDPI.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(701, 22);
            this.txtDPI.TabIndex = 67;
            // 
            // lblDPI
            // 
            this.lblDPI.AutoSize = true;
            this.lblDPI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDPI.Location = new System.Drawing.Point(20, 592);
            this.lblDPI.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(317, 32);
            this.lblDPI.TabIndex = 66;
            this.lblDPI.Text = "Ingrese el DPI del usuario:";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(29, 539);
            this.txtMail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(701, 22);
            this.txtMail.TabIndex = 65;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCorreo.Location = new System.Drawing.Point(20, 496);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(351, 32);
            this.txtCorreo.TabIndex = 64;
            this.txtCorreo.Text = "Ingrese el correo del usuario:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(29, 453);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(701, 22);
            this.txtDireccion.TabIndex = 63;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblDireccion.Location = new System.Drawing.Point(20, 410);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(488, 32);
            this.lblDireccion.TabIndex = 62;
            this.lblDireccion.Text = "Ingrese la dirección personal del usuario:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(29, 298);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(701, 22);
            this.txtApellidos.TabIndex = 61;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblApellidos.Location = new System.Drawing.Point(20, 255);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(129, 32);
            this.lblApellidos.TabIndex = 60;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(29, 214);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(701, 22);
            this.txtNombres.TabIndex = 59;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblNombre.Location = new System.Drawing.Point(20, 172);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(127, 32);
            this.lblNombre.TabIndex = 58;
            this.lblNombre.Text = "Nombres:";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblRegister);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1533, 80);
            this.pnlMain.TabIndex = 57;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(25, 31);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(211, 32);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Registrar usuario";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(996, 502);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 59);
            this.btnDelete.TabIndex = 85;
            this.btnDelete.Text = "Eliminar Usuario";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1533, 761);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.chkAnadir);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.chkEditarPermiso);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbHorarios);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.btnActualizarUsuario);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpdate";
            this.Text = "Actualizar Datos del Usuario";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.CheckBox chkAnadir;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.CheckBox chkEditarPermiso;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label lblDPI;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnDelete;
    }
}