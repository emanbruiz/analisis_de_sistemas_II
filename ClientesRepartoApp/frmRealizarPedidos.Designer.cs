
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRealizarPedidos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblPrecioo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAumentarCantidad = new System.Windows.Forms.Button();
            this.btnDisminuirCantidad = new System.Windows.Forms.Button();
            this.lblStock_1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.btnRealizarPedido = new System.Windows.Forms.Button();
            this.lblSeleccionPedido = new System.Windows.Forms.Label();
            this.rbtnPagoContraEntrega = new System.Windows.Forms.RadioButton();
            this.rbtnTarjeta = new System.Windows.Forms.RadioButton();
            this.lblTipoPago = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(44)))), ((int)(((byte)(16)))));
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 53);
            this.panel1.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(16, 11);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(213, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Realizar Pedidos";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DisplayMember = "Text";
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(7, 114);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(527, 24);
            this.cmbProductos.TabIndex = 1;
            this.cmbProductos.ValueMember = "Value";
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(181, 219);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(142, 117);
            this.txtDescripcion.TabIndex = 19;
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
            // lblPrecioo
            // 
            this.lblPrecioo.AutoSize = true;
            this.lblPrecioo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioo.Location = new System.Drawing.Point(176, 183);
            this.lblPrecioo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioo.Name = "lblPrecioo";
            this.lblPrecioo.Size = new System.Drawing.Size(59, 17);
            this.lblPrecioo.TabIndex = 6;
            this.lblPrecioo.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(419, 256);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(30, 22);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Text = "0";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAumentarCantidad
            // 
            this.btnAumentarCantidad.Location = new System.Drawing.Point(462, 253);
            this.btnAumentarCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnAumentarCantidad.Name = "btnAumentarCantidad";
            this.btnAumentarCantidad.Size = new System.Drawing.Size(85, 28);
            this.btnAumentarCantidad.TabIndex = 3;
            this.btnAumentarCantidad.Text = "Aumentar";
            this.btnAumentarCantidad.UseVisualStyleBackColor = true;
            this.btnAumentarCantidad.Click += new System.EventHandler(this.btnAumentarCantidad_Click);
            // 
            // btnDisminuirCantidad
            // 
            this.btnDisminuirCantidad.Location = new System.Drawing.Point(331, 253);
            this.btnDisminuirCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisminuirCantidad.Name = "btnDisminuirCantidad";
            this.btnDisminuirCantidad.Size = new System.Drawing.Size(80, 28);
            this.btnDisminuirCantidad.TabIndex = 2;
            this.btnDisminuirCantidad.Text = "Disminuir";
            this.btnDisminuirCantidad.UseVisualStyleBackColor = true;
            this.btnDisminuirCantidad.Click += new System.EventHandler(this.btnDisminuirCantidad_Click);
            // 
            // lblStock_1
            // 
            this.lblStock_1.AutoSize = true;
            this.lblStock_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock_1.Location = new System.Drawing.Point(177, 199);
            this.lblStock_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock_1.Name = "lblStock_1";
            this.lblStock_1.Size = new System.Drawing.Size(48, 17);
            this.lblStock_1.TabIndex = 11;
            this.lblStock_1.Text = "Stock";
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
            this.pbImagenProducto.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(173, 158);
            this.pbImagenProducto.TabIndex = 12;
            this.pbImagenProducto.TabStop = false;
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.Location = new System.Drawing.Point(393, 496);
            this.btnRealizarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Size = new System.Drawing.Size(141, 28);
            this.btnRealizarPedido.TabIndex = 6;
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.UseVisualStyleBackColor = true;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // lblSeleccionPedido
            // 
            this.lblSeleccionPedido.AutoSize = true;
            this.lblSeleccionPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionPedido.Location = new System.Drawing.Point(3, 95);
            this.lblSeleccionPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeleccionPedido.Name = "lblSeleccionPedido";
            this.lblSeleccionPedido.Size = new System.Drawing.Size(174, 17);
            this.lblSeleccionPedido.TabIndex = 14;
            this.lblSeleccionPedido.Text = "Seleccione el producto";
            // 
            // rbtnPagoContraEntrega
            // 
            this.rbtnPagoContraEntrega.AutoSize = true;
            this.rbtnPagoContraEntrega.Location = new System.Drawing.Point(21, 369);
            this.rbtnPagoContraEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnPagoContraEntrega.Name = "rbtnPagoContraEntrega";
            this.rbtnPagoContraEntrega.Size = new System.Drawing.Size(162, 21);
            this.rbtnPagoContraEntrega.TabIndex = 4;
            this.rbtnPagoContraEntrega.TabStop = true;
            this.rbtnPagoContraEntrega.Text = "Pago Contra Entrega";
            this.rbtnPagoContraEntrega.UseVisualStyleBackColor = true;
            // 
            // rbtnTarjeta
            // 
            this.rbtnTarjeta.AutoSize = true;
            this.rbtnTarjeta.Location = new System.Drawing.Point(21, 408);
            this.rbtnTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnTarjeta.Name = "rbtnTarjeta";
            this.rbtnTarjeta.Size = new System.Drawing.Size(183, 21);
            this.rbtnTarjeta.TabIndex = 5;
            this.rbtnTarjeta.TabStop = true;
            this.rbtnTarjeta.Text = "Pago Con Tarjeta (POS)";
            this.rbtnTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblTipoPago
            // 
            this.lblTipoPago.AutoSize = true;
            this.lblTipoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPago.Location = new System.Drawing.Point(13, 339);
            this.lblTipoPago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoPago.Name = "lblTipoPago";
            this.lblTipoPago.Size = new System.Drawing.Size(104, 17);
            this.lblTipoPago.TabIndex = 17;
            this.lblTipoPago.Text = "Tipo de pago";
            // 
            // frmRealizarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 537);
            this.Controls.Add(this.lblTipoPago);
            this.Controls.Add(this.rbtnTarjeta);
            this.Controls.Add(this.rbtnPagoContraEntrega);
            this.Controls.Add(this.lblSeleccionPedido);
            this.Controls.Add(this.btnRealizarPedido);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.lblStock_1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnDisminuirCantidad);
            this.Controls.Add(this.btnAumentarCantidad);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblPrecioo);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmRealizarPedidos";
            this.Text = "Realizar Pedidos";
            this.Load += new System.EventHandler(this.frmRealizarPedidos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblPrecioo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAumentarCantidad;
        private System.Windows.Forms.Button btnDisminuirCantidad;
        private System.Windows.Forms.Label lblStock_1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Button btnRealizarPedido;
        private System.Windows.Forms.Label lblSeleccionPedido;
        private System.Windows.Forms.RadioButton rbtnPagoContraEntrega;
        private System.Windows.Forms.RadioButton rbtnTarjeta;
        private System.Windows.Forms.Label lblTipoPago;
    }
}