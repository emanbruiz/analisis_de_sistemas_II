
namespace AdminRepartoApp
{
    partial class frmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            this.chkAnadir = new System.Windows.Forms.CheckBox();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.chkEditarPermiso = new System.Windows.Forms.CheckBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRoles = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkAnadir
            // 
            this.chkAnadir.AutoSize = true;
            this.chkAnadir.Location = new System.Drawing.Point(24, 238);
            this.chkAnadir.Name = "chkAnadir";
            this.chkAnadir.Size = new System.Drawing.Size(177, 17);
            this.chkAnadir.TabIndex = 44;
            this.chkAnadir.Text = "Permitir Añadir Usuarios Nuevos";
            this.chkAnadir.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(24, 211);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(99, 17);
            this.chkEliminar.TabIndex = 43;
            this.chkEliminar.Text = "Permitir Eliminar";
            this.chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkEditarPermiso
            // 
            this.chkEditarPermiso.AutoSize = true;
            this.chkEditarPermiso.Location = new System.Drawing.Point(24, 184);
            this.chkEditarPermiso.Name = "chkEditarPermiso";
            this.chkEditarPermiso.Size = new System.Drawing.Size(90, 17);
            this.chkEditarPermiso.TabIndex = 42;
            this.chkEditarPermiso.Text = "Permitir Editar";
            this.chkEditarPermiso.UseVisualStyleBackColor = true;
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisos.ForeColor = System.Drawing.Color.Black;
            this.lblPermisos.Location = new System.Drawing.Point(18, 146);
            this.lblPermisos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(91, 25);
            this.lblPermisos.TabIndex = 41;
            this.lblPermisos.Text = "Permisos";
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.Location = new System.Drawing.Point(24, 262);
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(146, 48);
            this.btnActualizarUsuario.TabIndex = 36;
            this.btnActualizarUsuario.Text = "Actualizar Usuario";
            this.btnActualizarUsuario.UseVisualStyleBackColor = true;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(19, 91);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(197, 25);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Seleccione el usuario";
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.ForeColor = System.Drawing.Color.White;
            this.lblRoles.Location = new System.Drawing.Point(19, 25);
            this.lblRoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(150, 25);
            this.lblRoles.TabIndex = 0;
            this.lblRoles.Text = "Gestionar Roles";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblRoles);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(336, 65);
            this.pnlMain.TabIndex = 49;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(227, 101);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(96, 39);
            this.btnCargar.TabIndex = 51;
            this.btnCargar.Text = "Cargar Usuarios";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(23, 119);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(193, 21);
            this.cmbUsuarios.TabIndex = 52;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 349);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.chkAnadir);
            this.Controls.Add(this.chkEliminar);
            this.Controls.Add(this.chkEditarPermiso);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.btnActualizarUsuario);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRoles";
            this.Opacity = 0.97D;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkAnadir;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.CheckBox chkEditarPermiso;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRoles;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cmbUsuarios;
    }
}