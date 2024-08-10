
namespace AdminRepartoApp
{
    partial class frmReportesPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportesPersonal));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblReportePersonal = new System.Windows.Forms.Label();
            this.cmbBuscarEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnVerEmpleados = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.chkPermitirAñadir = new System.Windows.Forms.CheckBox();
            this.chkPermitirEliminar = new System.Windows.Forms.CheckBox();
            this.chkPermitirEditar = new System.Windows.Forms.CheckBox();
            this.cmbTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.lblDPI = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblReportePersonal);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1067, 49);
            this.pnlMain.TabIndex = 3;
            // 
            // lblReportePersonal
            // 
            this.lblReportePersonal.AutoSize = true;
            this.lblReportePersonal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportePersonal.ForeColor = System.Drawing.Color.White;
            this.lblReportePersonal.Location = new System.Drawing.Point(5, 11);
            this.lblReportePersonal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblReportePersonal.Name = "lblReportePersonal";
            this.lblReportePersonal.Size = new System.Drawing.Size(257, 32);
            this.lblReportePersonal.TabIndex = 0;
            this.lblReportePersonal.Text = "Reportes de Personal";
            // 
            // cmbBuscarEmpleado
            // 
            this.cmbBuscarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarEmpleado.FormattingEnabled = true;
            this.cmbBuscarEmpleado.Location = new System.Drawing.Point(20, 86);
            this.cmbBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuscarEmpleado.Name = "cmbBuscarEmpleado";
            this.cmbBuscarEmpleado.Size = new System.Drawing.Size(372, 24);
            this.cmbBuscarEmpleado.TabIndex = 1;
            this.cmbBuscarEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarEmpleado_SelectedIndexChanged);
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(16, 66);
            this.lblEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(119, 17);
            this.lblEmpleado.TabIndex = 5;
            this.lblEmpleado.Text = "Buscar Empleado";
            this.lblEmpleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 11);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvEmpleados);
            this.panel1.Controls.Add(this.btnExportarExcel);
            this.panel1.Controls.Add(this.btnVerEmpleados);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.cmbEstado);
            this.panel1.Controls.Add(this.chkPermitirAñadir);
            this.panel1.Controls.Add(this.chkPermitirEliminar);
            this.panel1.Controls.Add(this.chkPermitirEditar);
            this.panel1.Controls.Add(this.cmbTipoEmpleado);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Controls.Add(this.cmbGenero);
            this.panel1.Controls.Add(this.txtHorario);
            this.panel1.Controls.Add(this.lblHorario);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.txtDPI);
            this.panel1.Controls.Add(this.lblDPI);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.lblCorreo);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(20, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 413);
            this.panel1.TabIndex = 7;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(382, 4);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(632, 394);
            this.dgvEmpleados.TabIndex = 31;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Location = new System.Drawing.Point(245, 359);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(124, 37);
            this.btnExportarExcel.TabIndex = 16;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnVerEmpleados
            // 
            this.btnVerEmpleados.Location = new System.Drawing.Point(12, 361);
            this.btnVerEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerEmpleados.Name = "btnVerEmpleados";
            this.btnVerEmpleados.Size = new System.Drawing.Size(116, 37);
            this.btnVerEmpleados.TabIndex = 15;
            this.btnVerEmpleados.Text = "Ver Empleados";
            this.btnVerEmpleados.UseVisualStyleBackColor = true;
            this.btnVerEmpleados.Click += new System.EventHandler(this.btnVerEmpleados_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 326);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Estado";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(4, 233);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(123, 17);
            this.lblTipo.TabIndex = 27;
            this.lblTipo.Text = "Tipo de Empleado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Suspendido"});
            this.cmbEstado.Location = new System.Drawing.Point(165, 326);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(203, 24);
            this.cmbEstado.TabIndex = 14;
            // 
            // chkPermitirAñadir
            // 
            this.chkPermitirAñadir.AutoSize = true;
            this.chkPermitirAñadir.Location = new System.Drawing.Point(263, 298);
            this.chkPermitirAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.chkPermitirAñadir.Name = "chkPermitirAñadir";
            this.chkPermitirAñadir.Size = new System.Drawing.Size(123, 21);
            this.chkPermitirAñadir.TabIndex = 13;
            this.chkPermitirAñadir.Text = "Permitir Añadir";
            this.chkPermitirAñadir.UseVisualStyleBackColor = true;
            // 
            // chkPermitirEliminar
            // 
            this.chkPermitirEliminar.AutoSize = true;
            this.chkPermitirEliminar.Location = new System.Drawing.Point(128, 298);
            this.chkPermitirEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.chkPermitirEliminar.Name = "chkPermitirEliminar";
            this.chkPermitirEliminar.Size = new System.Drawing.Size(132, 21);
            this.chkPermitirEliminar.TabIndex = 12;
            this.chkPermitirEliminar.Text = "Permitir Eliminar";
            this.chkPermitirEliminar.UseVisualStyleBackColor = true;
            // 
            // chkPermitirEditar
            // 
            this.chkPermitirEditar.AutoSize = true;
            this.chkPermitirEditar.Location = new System.Drawing.Point(9, 299);
            this.chkPermitirEditar.Margin = new System.Windows.Forms.Padding(4);
            this.chkPermitirEditar.Name = "chkPermitirEditar";
            this.chkPermitirEditar.Size = new System.Drawing.Size(119, 21);
            this.chkPermitirEditar.TabIndex = 11;
            this.chkPermitirEditar.Text = "Permitir Editar";
            this.chkPermitirEditar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoEmpleado
            // 
            this.cmbTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEmpleado.FormattingEnabled = true;
            this.cmbTipoEmpleado.Items.AddRange(new object[] {
            "Administrador",
            "Almacenero",
            "Gerente",
            "Piloto",
            "Vendedor"});
            this.cmbTipoEmpleado.Location = new System.Drawing.Point(165, 233);
            this.cmbTipoEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            this.cmbTipoEmpleado.Size = new System.Drawing.Size(203, 24);
            this.cmbTipoEmpleado.TabIndex = 9;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(4, 71);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(56, 17);
            this.lblGenero.TabIndex = 21;
            this.lblGenero.Text = "Género";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbGenero.Location = new System.Drawing.Point(165, 71);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(203, 24);
            this.cmbGenero.TabIndex = 4;
            // 
            // txtHorario
            // 
            this.txtHorario.Enabled = false;
            this.txtHorario.Location = new System.Drawing.Point(165, 266);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.ReadOnly = true;
            this.txtHorario.Size = new System.Drawing.Size(203, 22);
            this.txtHorario.TabIndex = 10;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(4, 266);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(55, 17);
            this.lblHorario.TabIndex = 18;
            this.lblHorario.Text = "Horario";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(165, 201);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(203, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(4, 201);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtDPI
            // 
            this.txtDPI.Enabled = false;
            this.txtDPI.Location = new System.Drawing.Point(165, 169);
            this.txtDPI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.ReadOnly = true;
            this.txtDPI.Size = new System.Drawing.Size(203, 22);
            this.txtDPI.TabIndex = 7;
            // 
            // lblDPI
            // 
            this.lblDPI.AutoSize = true;
            this.lblDPI.Location = new System.Drawing.Point(4, 169);
            this.lblDPI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDPI.Name = "lblDPI";
            this.lblDPI.Size = new System.Drawing.Size(30, 17);
            this.lblDPI.TabIndex = 14;
            this.lblDPI.Text = "DPI";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(165, 137);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(203, 22);
            this.txtCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(4, 137);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(165, 105);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(203, 22);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(4, 105);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 17);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(165, 39);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.Size = new System.Drawing.Size(203, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(4, 43);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 17);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(165, 7);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(203, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // frmReportesPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.cmbBuscarEmpleado);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmReportesPersonal";
            this.Text = "Reportes del personal";
            this.Load += new System.EventHandler(this.frmReportesPersonal_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblReportePersonal;
        private System.Windows.Forms.ComboBox cmbBuscarEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnVerEmpleados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.CheckBox chkPermitirAñadir;
        private System.Windows.Forms.CheckBox chkPermitirEliminar;
        private System.Windows.Forms.CheckBox chkPermitirEditar;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Label lblDPI;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
    }
}