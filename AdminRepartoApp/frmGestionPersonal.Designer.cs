
namespace AdminRepartoApp
{
    partial class frmGestionPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPersonal));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblGestionPersonal = new System.Windows.Forms.Label();
            this.lblBuscarPersonal = new System.Windows.Forms.Label();
            this.cmbTipoPersonal = new System.Windows.Forms.ComboBox();
            this.lblTipoPersonal = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.grpDetallesPersonal = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.chkPermitirAnadir = new System.Windows.Forms.CheckBox();
            this.chkPermitirEliminar = new System.Windows.Forms.CheckBox();
            this.chkPermitirEditar = new System.Windows.Forms.CheckBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.lblDPI = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbBuscarPersonal = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.grpDetallesPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblGestionPersonal);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1002, 48);
            this.pnlMain.TabIndex = 3;
            // 
            // lblGestionPersonal
            // 
            this.lblGestionPersonal.AutoSize = true;
            this.lblGestionPersonal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPersonal.ForeColor = System.Drawing.Color.White;
            this.lblGestionPersonal.Location = new System.Drawing.Point(5, 11);
            this.lblGestionPersonal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGestionPersonal.Name = "lblGestionPersonal";
            this.lblGestionPersonal.Size = new System.Drawing.Size(242, 32);
            this.lblGestionPersonal.TabIndex = 0;
            this.lblGestionPersonal.Text = "Gestión de Personal";
            // 
            // lblBuscarPersonal
            // 
            this.lblBuscarPersonal.AutoSize = true;
            this.lblBuscarPersonal.Location = new System.Drawing.Point(447, 58);
            this.lblBuscarPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscarPersonal.Name = "lblBuscarPersonal";
            this.lblBuscarPersonal.Size = new System.Drawing.Size(112, 17);
            this.lblBuscarPersonal.TabIndex = 4;
            this.lblBuscarPersonal.Text = "Buscar Personal";
            // 
            // cmbTipoPersonal
            // 
            this.cmbTipoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPersonal.FormattingEnabled = true;
            this.cmbTipoPersonal.ItemHeight = 16;
            this.cmbTipoPersonal.Location = new System.Drawing.Point(747, 77);
            this.cmbTipoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoPersonal.Name = "cmbTipoPersonal";
            this.cmbTipoPersonal.Size = new System.Drawing.Size(244, 24);
            this.cmbTipoPersonal.TabIndex = 6;
            this.cmbTipoPersonal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPersonal_SelectedIndexChanged);
            // 
            // lblTipoPersonal
            // 
            this.lblTipoPersonal.AutoSize = true;
            this.lblTipoPersonal.Location = new System.Drawing.Point(743, 57);
            this.lblTipoPersonal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPersonal.Name = "lblTipoPersonal";
            this.lblTipoPersonal.Size = new System.Drawing.Size(116, 17);
            this.lblTipoPersonal.TabIndex = 7;
            this.lblTipoPersonal.Text = "Tipo de Personal";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(6, 429);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(127, 41);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(451, 107);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.RowHeadersWidth = 51;
            this.dgvPersonal.RowTemplate.Height = 24;
            this.dgvPersonal.Size = new System.Drawing.Size(541, 419);
            this.dgvPersonal.TabIndex = 13;
            // 
            // grpDetallesPersonal
            // 
            this.grpDetallesPersonal.Controls.Add(this.txtPassword);
            this.grpDetallesPersonal.Controls.Add(this.lblPassword);
            this.grpDetallesPersonal.Controls.Add(this.cmbGenero);
            this.grpDetallesPersonal.Controls.Add(this.btnEliminar);
            this.grpDetallesPersonal.Controls.Add(this.btnActualizar);
            this.grpDetallesPersonal.Controls.Add(this.lblGenero);
            this.grpDetallesPersonal.Controls.Add(this.chkPermitirAnadir);
            this.grpDetallesPersonal.Controls.Add(this.chkPermitirEliminar);
            this.grpDetallesPersonal.Controls.Add(this.chkPermitirEditar);
            this.grpDetallesPersonal.Controls.Add(this.cmbEstado);
            this.grpDetallesPersonal.Controls.Add(this.cmbRol);
            this.grpDetallesPersonal.Controls.Add(this.lblEstado);
            this.grpDetallesPersonal.Controls.Add(this.lblRol);
            this.grpDetallesPersonal.Controls.Add(this.txtDireccion);
            this.grpDetallesPersonal.Controls.Add(this.lblDireccion);
            this.grpDetallesPersonal.Controls.Add(this.txtTelefono);
            this.grpDetallesPersonal.Controls.Add(this.lblTelefono);
            this.grpDetallesPersonal.Controls.Add(this.txtCorreo);
            this.grpDetallesPersonal.Controls.Add(this.lblCorreo);
            this.grpDetallesPersonal.Controls.Add(this.txtDPI);
            this.grpDetallesPersonal.Controls.Add(this.lblDPI);
            this.grpDetallesPersonal.Controls.Add(this.txtApellido);
            this.grpDetallesPersonal.Controls.Add(this.lblApellido);
            this.grpDetallesPersonal.Controls.Add(this.txtNombre);
            this.grpDetallesPersonal.Controls.Add(this.lblNombre);
            this.grpDetallesPersonal.Location = new System.Drawing.Point(11, 56);
            this.grpDetallesPersonal.Name = "grpDetallesPersonal";
            this.grpDetallesPersonal.Size = new System.Drawing.Size(423, 476);
            this.grpDetallesPersonal.TabIndex = 14;
            this.grpDetallesPersonal.TabStop = false;
            this.grpDetallesPersonal.Text = "Detalles Personales";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(143, 272);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(275, 22);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(4, 276);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(135, 17);
            this.lblPassword.TabIndex = 39;
            this.lblPassword.Text = "Cambiar contraseña";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(143, 303);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(275, 24);
            this.cmbGenero.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(290, 429);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 41);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(3, 303);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(56, 17);
            this.lblGenero.TabIndex = 37;
            this.lblGenero.Text = "Género";
            // 
            // chkPermitirAnadir
            // 
            this.chkPermitirAnadir.AutoSize = true;
            this.chkPermitirAnadir.Location = new System.Drawing.Point(6, 391);
            this.chkPermitirAnadir.Name = "chkPermitirAnadir";
            this.chkPermitirAnadir.Size = new System.Drawing.Size(123, 21);
            this.chkPermitirAnadir.TabIndex = 15;
            this.chkPermitirAnadir.Text = "Permitir Añadir";
            this.chkPermitirAnadir.UseVisualStyleBackColor = true;
            // 
            // chkPermitirEliminar
            // 
            this.chkPermitirEliminar.AutoSize = true;
            this.chkPermitirEliminar.Location = new System.Drawing.Point(6, 364);
            this.chkPermitirEliminar.Name = "chkPermitirEliminar";
            this.chkPermitirEliminar.Size = new System.Drawing.Size(132, 21);
            this.chkPermitirEliminar.TabIndex = 14;
            this.chkPermitirEliminar.Text = "Permitir Eliminar";
            this.chkPermitirEliminar.UseVisualStyleBackColor = true;
            // 
            // chkPermitirEditar
            // 
            this.chkPermitirEditar.AutoSize = true;
            this.chkPermitirEditar.Location = new System.Drawing.Point(6, 337);
            this.chkPermitirEditar.Name = "chkPermitirEditar";
            this.chkPermitirEditar.Size = new System.Drawing.Size(119, 21);
            this.chkPermitirEditar.TabIndex = 13;
            this.chkPermitirEditar.Text = "Permitir Editar";
            this.chkPermitirEditar.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido"});
            this.cmbEstado.Location = new System.Drawing.Point(142, 240);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(275, 24);
            this.cmbEstado.TabIndex = 10;
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(142, 207);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(275, 24);
            this.cmbRol.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(3, 240);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(52, 17);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "Estado";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(3, 210);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(29, 17);
            this.lblRol.TabIndex = 27;
            this.lblRol.Text = "Rol";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(141, 177);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(276, 22);
            this.txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(3, 180);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 25;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(141, 147);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(276, 22);
            this.txtTelefono.TabIndex = 7;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(3, 147);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 23;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(141, 113);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(276, 22);
            this.txtCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(3, 116);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 21;
            this.lblCorreo.Text = "Correo";
            // 
            // txtDPI
            // 
            this.txtDPI.Location = new System.Drawing.Point(141, 83);
            this.txtDPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(276, 22);
            this.txtDPI.TabIndex = 5;
            // 
            // lblDPI
            // 
            this.lblDPI.AutoSize = true;
            this.lblDPI.Location = new System.Drawing.Point(3, 86);
            this.lblDPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(30, 17);
            this.lblDPI.TabIndex = 19;
            this.lblDPI.Text = "DPI";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 53);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(276, 22);
            this.txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(3, 56);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 23);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(276, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 23);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbBuscarPersonal
            // 
            this.cmbBuscarPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarPersonal.FormattingEnabled = true;
            this.cmbBuscarPersonal.ItemHeight = 16;
            this.cmbBuscarPersonal.Location = new System.Drawing.Point(452, 79);
            this.cmbBuscarPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscarPersonal.Name = "cmbBuscarPersonal";
            this.cmbBuscarPersonal.Size = new System.Drawing.Size(287, 24);
            this.cmbBuscarPersonal.TabIndex = 15;
            this.cmbBuscarPersonal.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarPersonal_SelectedIndexChanged_1);
            // 
            // frmGestionPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 541);
            this.Controls.Add(this.cmbBuscarPersonal);
            this.Controls.Add(this.grpDetallesPersonal);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.lblTipoPersonal);
            this.Controls.Add(this.cmbTipoPersonal);
            this.Controls.Add(this.lblBuscarPersonal);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGestionPersonal";
            this.Text = "Gestión personal";
            this.Load += new System.EventHandler(this.frmGestionPersonal_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.grpDetallesPersonal.ResumeLayout(false);
            this.grpDetallesPersonal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblGestionPersonal;
        private System.Windows.Forms.Label lblBuscarPersonal;
        private System.Windows.Forms.ComboBox cmbTipoPersonal;
        private System.Windows.Forms.Label lblTipoPersonal;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.GroupBox grpDetallesPersonal;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label lblDPI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.CheckBox chkPermitirAnadir;
        private System.Windows.Forms.CheckBox chkPermitirEliminar;
        private System.Windows.Forms.CheckBox chkPermitirEditar;
        private System.Windows.Forms.ComboBox cmbBuscarPersonal;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnEliminar;
    }
}