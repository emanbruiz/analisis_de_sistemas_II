
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerPedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVerPedidos = new System.Windows.Forms.Label();
            this.cmbEstadoPedidos = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
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
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.gpbPiloto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(44)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.lblVerPedidos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 53);
            this.panel1.TabIndex = 3;
            // 
            // lblVerPedidos
            // 
            this.lblVerPedidos.AutoSize = true;
            this.lblVerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblVerPedidos.Location = new System.Drawing.Point(16, 11);
            this.lblVerPedidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerPedidos.Name = "lblVerPedidos";
            this.lblVerPedidos.Size = new System.Drawing.Size(157, 29);
            this.lblVerPedidos.TabIndex = 0;
            this.lblVerPedidos.Text = "Ver Pedidos";
            // 
            // cmbEstadoPedidos
            // 
            this.cmbEstadoPedidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoPedidos.FormattingEnabled = true;
            this.cmbEstadoPedidos.Location = new System.Drawing.Point(21, 101);
            this.cmbEstadoPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbEstadoPedidos.Name = "cmbEstadoPedidos";
            this.cmbEstadoPedidos.Size = new System.Drawing.Size(173, 24);
            this.cmbEstadoPedidos.TabIndex = 1;
            this.cmbEstadoPedidos.SelectedIndexChanged += new System.EventHandler(this.cmbEstadoPedidos_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(17, 81);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(146, 17);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Ver Estado de Pedido";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(20, 142);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.Size = new System.Drawing.Size(467, 314);
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
            this.gpbPiloto.Controls.Add(this.lblDetalle);
            this.gpbPiloto.Controls.Add(this.lblNombrePiloto);
            this.gpbPiloto.Location = new System.Drawing.Point(493, 167);
            this.gpbPiloto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPiloto.Name = "gpbPiloto";
            this.gpbPiloto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbPiloto.Size = new System.Drawing.Size(196, 263);
            this.gpbPiloto.TabIndex = 7;
            this.gpbPiloto.TabStop = false;
            this.gpbPiloto.Text = "Califique al Piloto";
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(12, 126);
            this.txtNombrePiloto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.ReadOnly = true;
            this.txtNombrePiloto.Size = new System.Drawing.Size(169, 22);
            this.txtNombrePiloto.TabIndex = 4;
            // 
            // txtIDPiloto
            // 
            this.txtIDPiloto.Location = new System.Drawing.Point(12, 82);
            this.txtIDPiloto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDPiloto.Name = "txtIDPiloto";
            this.txtIDPiloto.ReadOnly = true;
            this.txtIDPiloto.Size = new System.Drawing.Size(169, 22);
            this.txtIDPiloto.TabIndex = 3;
            // 
            // cmbFactura
            // 
            this.cmbFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Location = new System.Drawing.Point(8, 17);
            this.cmbFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(173, 24);
            this.cmbFactura.TabIndex = 2;
            this.cmbFactura.SelectedIndexChanged += new System.EventHandler(this.cmbFactura_SelectedIndexChanged);
            // 
            // btnCalificarPiloto
            // 
            this.btnCalificarPiloto.Location = new System.Drawing.Point(45, 228);
            this.btnCalificarPiloto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalificarPiloto.Name = "btnCalificarPiloto";
            this.btnCalificarPiloto.Size = new System.Drawing.Size(115, 30);
            this.btnCalificarPiloto.TabIndex = 7;
            this.btnCalificarPiloto.Text = "Calificar Piloto";
            this.btnCalificarPiloto.UseVisualStyleBackColor = true;
            this.btnCalificarPiloto.Click += new System.EventHandler(this.btnCalificarPiloto_Click_1);
            // 
            // btnDisminuirCalificacion
            // 
            this.btnDisminuirCalificacion.Location = new System.Drawing.Point(129, 180);
            this.btnDisminuirCalificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisminuirCalificacion.Name = "btnDisminuirCalificacion";
            this.btnDisminuirCalificacion.Size = new System.Drawing.Size(45, 28);
            this.btnDisminuirCalificacion.TabIndex = 6;
            this.btnDisminuirCalificacion.Text = "-";
            this.btnDisminuirCalificacion.UseVisualStyleBackColor = true;
            this.btnDisminuirCalificacion.Click += new System.EventHandler(this.btnDisminuirCalificacion_Click);
            // 
            // btnAumentarCalificacion
            // 
            this.btnAumentarCalificacion.Location = new System.Drawing.Point(16, 178);
            this.btnAumentarCalificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAumentarCalificacion.Name = "btnAumentarCalificacion";
            this.btnAumentarCalificacion.Size = new System.Drawing.Size(45, 28);
            this.btnAumentarCalificacion.TabIndex = 5;
            this.btnAumentarCalificacion.Text = "+";
            this.btnAumentarCalificacion.UseVisualStyleBackColor = true;
            this.btnAumentarCalificacion.Click += new System.EventHandler(this.btnAumentarCalificacion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Calificar Piloto";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(81, 182);
            this.txtCalificacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.ReadOnly = true;
            this.txtCalificacion.Size = new System.Drawing.Size(28, 22);
            this.txtCalificacion.TabIndex = 23;
            // 
            // lblIDPiloto
            // 
            this.lblIDPiloto.AutoSize = true;
            this.lblIDPiloto.Location = new System.Drawing.Point(8, 63);
            this.lblIDPiloto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDPiloto.Name = "lblIDPiloto";
            this.lblIDPiloto.Size = new System.Drawing.Size(83, 17);
            this.lblIDPiloto.TabIndex = 22;
            this.lblIDPiloto.Text = "ID del Piloto";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(8, 47);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(72, 17);
            this.lblDetalle.TabIndex = 21;
            this.lblDetalle.Text = "Detalles:";
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(8, 106);
            this.lblNombrePiloto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(120, 17);
            this.lblNombrePiloto.TabIndex = 19;
            this.lblNombrePiloto.Text = "Nombre del Piloto";
            // 
            // frmVerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 480);
            this.Controls.Add(this.gpbPiloto);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstadoPedidos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmVerPedidos";
            this.Text = "Ver Pedidos";
            this.Load += new System.EventHandler(this.frmVerPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.gpbPiloto.ResumeLayout(false);
            this.gpbPiloto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVerPedidos;
        private System.Windows.Forms.ComboBox cmbEstadoPedidos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.GroupBox gpbPiloto;
        private System.Windows.Forms.Button btnCalificarPiloto;
        private System.Windows.Forms.Button btnDisminuirCalificacion;
        private System.Windows.Forms.Button btnAumentarCalificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.ComboBox cmbFactura;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.TextBox txtIDPiloto;
        private System.Windows.Forms.Label lblIDPiloto;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}