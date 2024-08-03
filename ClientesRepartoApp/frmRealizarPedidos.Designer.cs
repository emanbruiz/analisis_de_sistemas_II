
namespace ClientesRepartoApp
{
    partial class frmRealizarPedidos
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
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAumentarCantidad = new System.Windows.Forms.Button();
            this.btnDisminuirCantidad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnPagoContraEntrega = new System.Windows.Forms.RadioButton();
            this.rbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(44)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 53);
            this.panel1.TabIndex = 2;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblRegistro.Location = new System.Drawing.Point(16, 11);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(112, 29);
            this.lblRegistro.TabIndex = 0;
            this.lblRegistro.Text = "Registro";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DisplayMember = "Text";
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(7, 114);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(411, 24);
            this.cmbProductos.TabIndex = 3;
            this.cmbProductos.ValueMember = "Value";
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(181, 219);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(235, 117);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Text = "";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(237, 183);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(18, 17);
            this.lblPrecioProducto.TabIndex = 5;
            this.lblPrecioProducto.Text = "\"\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(200, 347);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(30, 22);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Text = "0";
            // 
            // btnAumentarCantidad
            // 
            this.btnAumentarCantidad.Location = new System.Drawing.Point(303, 347);
            this.btnAumentarCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAumentarCantidad.Name = "btnAumentarCantidad";
            this.btnAumentarCantidad.Size = new System.Drawing.Size(115, 28);
            this.btnAumentarCantidad.TabIndex = 8;
            this.btnAumentarCantidad.Text = "Aumentar";
            this.btnAumentarCantidad.UseVisualStyleBackColor = true;
            this.btnAumentarCantidad.Click += new System.EventHandler(this.btnAumentarCantidad_Click);
            // 
            // btnDisminuirCantidad
            // 
            this.btnDisminuirCantidad.Location = new System.Drawing.Point(0, 343);
            this.btnDisminuirCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisminuirCantidad.Name = "btnDisminuirCantidad";
            this.btnDisminuirCantidad.Size = new System.Drawing.Size(132, 28);
            this.btnDisminuirCantidad.TabIndex = 9;
            this.btnDisminuirCantidad.Text = "Disminuir";
            this.btnDisminuirCantidad.UseVisualStyleBackColor = true;
            this.btnDisminuirCantidad.Click += new System.EventHandler(this.btnDisminuirCantidad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Stock";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(239, 199);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(18, 17);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "\"\"";
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagenProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenProducto.Location = new System.Drawing.Point(7, 177);
            this.pbImagenProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(173, 158);
            this.pbImagenProducto.TabIndex = 12;
            this.pbImagenProducto.TabStop = false;
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Location = new System.Drawing.Point(139, 379);
            this.btnRealizarPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(141, 28);
            this.btnRealizarPedido.TabIndex = 13;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Seleccione el producto";
            // 
            // rbtnPagoContraEntrega
            // 
            this.rbtnPagoContraEntrega.AutoSize = true;
            this.rbtnPagoContraEntrega.Location = new System.Drawing.Point(21, 462);
            this.rbtnPagoContraEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnPagoContraEntrega.Name = "rbtnPagoContraEntrega";
            this.rbtnPagoContraEntrega.Size = new System.Drawing.Size(162, 21);
            this.rbtnPagoContraEntrega.TabIndex = 15;
            this.rbtnPagoContraEntrega.TabStop = true;
            this.rbtnPagoContraEntrega.Text = "Pago Contra Entrega";
            this.rbtnPagoContraEntrega.UseVisualStyleBackColor = true;
            // 
            // rbtnTarjeta
            // 
            this.rbtnTarjeta.AutoSize = true;
            this.rbtnTarjeta.Location = new System.Drawing.Point(233, 462);
            this.rbtnTarjeta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTarjeta.Name = "rbtnTarjeta";
            this.rbtnTarjeta.Size = new System.Drawing.Size(183, 21);
            this.rbtnTarjeta.TabIndex = 16;
            this.rbtnTarjeta.TabStop = true;
            this.rbtnTarjeta.Text = "Pago Con Tarjeta (POS)";
            this.rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 442);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tipo de pago";
            // 
            // frmRealizarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbtnTarjeta);
            this.Controls.Add(this.rbtnPagoContraEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnDisminuirCantidad);
            this.Controls.Add(this.btnAumentarCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimizeBox = false;
            this.Name = "frmRealizarPedidos";
            this.Text = "frmRealizarPedidos";
            this.Load += new System.EventHandler(this.frmRealizarPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAumentarCantidad;
        private System.Windows.Forms.Button btnDisminuirCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnPagoContraEntrega;
        private System.Windows.Forms.RadioButton rbtnTarjeta;
        private System.Windows.Forms.Label label4;
    }
}