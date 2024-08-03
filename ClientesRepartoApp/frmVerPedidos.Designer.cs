
namespace ClientesRepartoApp
{
    partial class frmVerPedidos
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
            this.lblRegistro = new System.Windows.Forms.Label();
            this.cmbEstadoPedidos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.gpbPiloto = new System.Windows.Forms.GroupBox();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.txtIDPiloto = new System.Windows.Forms.TextBox();
            this.cmbFactura = new System.Windows.Forms.ComboBox();
            this.btnCalificarPiloto = new System.Windows.Forms.Button();
            this.btnDisminuirCalificacion = new System.Windows.Forms.Button();
            this.btnAumentarCalificacion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.lblIDPiloto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpbPiloto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(44)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 43);
            this.panel1.TabIndex = 3;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRegistro.Location = new System.Drawing.Point(12, 9);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(125, 24);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Ver Pedidos";
            // 
            // cmbEstadoPedidos
            // 
            this.cmbEstadoPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPedidos.FormattingEnabled = true;
            this.cmbEstadoPedidos.Location = new System.Drawing.Point(16, 82);
            this.cmbEstadoPedidos.Name = "cmbEstadoPedidos";
            this.cmbEstadoPedidos.Size = new System.Drawing.Size(131, 21);
            this.cmbEstadoPedidos.TabIndex = 4;
            this.cmbEstadoPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoPedidos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ver Estado de Pedido";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(15, 115);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(350, 255);
            this.dgvPedidos.TabIndex = 6;
            // 
            // gpbPiloto
            // 
            this.gpbPiloto.Controls.Add(this.txtNombrePiloto);
            this.gpbPiloto.Controls.Add(this.txtIDPiloto);
            this.gpbPiloto.Controls.Add(this.cmbFactura);
            this.gpbPiloto.Controls.Add(this.btnCalificarPiloto);
            this.gpbPiloto.Controls.Add(this.btnDisminuirCalificacion);
            this.gpbPiloto.Controls.Add(this.btnAumentarCalificacion);
            this.gpbPiloto.Controls.Add(this.label4);
            this.gpbPiloto.Controls.Add(this.txtCalificacion);
            this.gpbPiloto.Controls.Add(this.lblIDPiloto);
            this.gpbPiloto.Controls.Add(this.label3);
            this.gpbPiloto.Controls.Add(this.lblNombrePiloto);
            this.gpbPiloto.Location = new System.Drawing.Point(370, 136);
            this.gpbPiloto.Name = "gpbPiloto";
            this.gpbPiloto.Size = new System.Drawing.Size(147, 214);
            this.gpbPiloto.TabIndex = 7;
            this.gpbPiloto.TabStop = false;
            this.gpbPiloto.Text = "Califique al Piloto";
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(9, 102);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.ReadOnly = true;
            this.txtNombrePiloto.Size = new System.Drawing.Size(128, 20);
            this.txtNombrePiloto.TabIndex = 30;
            // 
            // txtIDPiloto
            // 
            this.txtIDPiloto.Location = new System.Drawing.Point(9, 67);
            this.txtIDPiloto.Name = "txtIDPiloto";
            this.txtIDPiloto.ReadOnly = true;
            this.txtIDPiloto.Size = new System.Drawing.Size(128, 20);
            this.txtIDPiloto.TabIndex = 29;
            // 
            // cmbFactura
            // 
            this.cmbFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Location = new System.Drawing.Point(6, 14);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(131, 21);
            this.cmbFactura.TabIndex = 8;
            this.cmbFactura.SelectedIndexChanged += new System.EventHandler(this.cmbFactura_SelectedIndexChanged);
            // 
            // btnCalificarPiloto
            // 
            this.btnCalificarPiloto.Location = new System.Drawing.Point(34, 185);
            this.btnCalificarPiloto.Name = "btnCalificarPiloto";
            this.btnCalificarPiloto.Size = new System.Drawing.Size(86, 24);
            this.btnCalificarPiloto.TabIndex = 28;
            this.btnCalificarPiloto.Text = "Calificar Piloto";
            this.btnCalificarPiloto.UseVisualStyleBackColor = true;
            this.btnCalificarPiloto.Click += new System.EventHandler(this.btnCalificarPiloto_Click_1);
            // 
            // btnDisminuirCalificacion
            // 
            this.btnDisminuirCalificacion.Location = new System.Drawing.Point(97, 146);
            this.btnDisminuirCalificacion.Name = "btnDisminuirCalificacion";
            this.btnDisminuirCalificacion.Size = new System.Drawing.Size(34, 23);
            this.btnDisminuirCalificacion.TabIndex = 27;
            this.btnDisminuirCalificacion.Text = "-";
            this.btnDisminuirCalificacion.UseVisualStyleBackColor = true;
            this.btnDisminuirCalificacion.Click += new System.EventHandler(this.btnDisminuirCalificacion_Click);
            // 
            // btnAumentarCalificacion
            // 
            this.btnAumentarCalificacion.Location = new System.Drawing.Point(12, 145);
            this.btnAumentarCalificacion.Name = "btnAumentarCalificacion";
            this.btnAumentarCalificacion.Size = new System.Drawing.Size(34, 23);
            this.btnAumentarCalificacion.TabIndex = 26;
            this.btnAumentarCalificacion.Text = "+";
            this.btnAumentarCalificacion.UseVisualStyleBackColor = true;
            this.btnAumentarCalificacion.Click += new System.EventHandler(this.btnAumentarCalificacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Calificar Piloto";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(61, 148);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.ReadOnly = true;
            this.txtCalificacion.Size = new System.Drawing.Size(22, 20);
            this.txtCalificacion.TabIndex = 23;
            // 
            // lblIDPiloto
            // 
            this.lblIDPiloto.AutoSize = true;
            this.lblIDPiloto.Location = new System.Drawing.Point(6, 51);
            this.lblIDPiloto.Name = "lblIDPiloto";
            this.lblIDPiloto.Size = new System.Drawing.Size(64, 13);
            this.lblIDPiloto.TabIndex = 22;
            this.lblIDPiloto.Text = "ID del Piloto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Detalles:";
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(6, 86);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(90, 13);
            this.lblNombrePiloto.TabIndex = 19;
            this.lblNombrePiloto.Text = "Nombre del Piloto";
            // 
            // frmVerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 450);
            this.Controls.Add(this.gpbPiloto);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEstadoPedidos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmVerPedidos";
            this.Text = "frmVerPedidos";
            this.Load += new System.EventHandler(this.frmVerPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gpbPiloto.ResumeLayout(false);
            this.gpbPiloto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.ComboBox cmbEstadoPedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox gpbPiloto;
        private System.Windows.Forms.Button btnCalificarPiloto;
        private System.Windows.Forms.Button btnDisminuirCalificacion;
        private System.Windows.Forms.Button btnAumentarCalificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFactura;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.TextBox txtIDPiloto;
        private System.Windows.Forms.Label lblIDPiloto;
        private System.Windows.Forms.Label lblNombrePiloto;
    }
}