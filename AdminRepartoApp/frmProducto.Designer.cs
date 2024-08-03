
namespace AdminRepartoApp
{
    partial class frmProducto
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblRegister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetalleProducto = new System.Windows.Forms.RichTextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPaisFabricante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComentariosProducto = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactoMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaisMarca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoUM = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombrePresentacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcionPresentacion = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtImagenPath = new System.Windows.Forms.TextBox();
            this.pbImagenProducto = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.pnlMain.Size = new System.Drawing.Size(625, 49);
            this.pnlMain.TabIndex = 2;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(5, 11);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(216, 32);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Añadir Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(7, 74);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(279, 22);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detalles del producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDetalleProducto
            // 
            this.txtDetalleProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalleProducto.Location = new System.Drawing.Point(7, 128);
            this.txtDetalleProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDetalleProducto.Name = "txtDetalleProducto";
            this.txtDetalleProducto.Size = new System.Drawing.Size(279, 73);
            this.txtDetalleProducto.TabIndex = 7;
            this.txtDetalleProducto.Text = "";
            this.txtDetalleProducto.TextChanged += new System.EventHandler(this.txtDetalleProducto_TextChanged);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(7, 233);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(279, 22);
            this.txtPrecioProducto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio del producto";
            // 
            // txtPaisFabricante
            // 
            this.txtPaisFabricante.Location = new System.Drawing.Point(7, 286);
            this.txtPaisFabricante.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaisFabricante.Name = "txtPaisFabricante";
            this.txtPaisFabricante.Size = new System.Drawing.Size(279, 22);
            this.txtPaisFabricante.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "País fabricante";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(7, 342);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(279, 22);
            this.txtIVA.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 322);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "IVA";
            // 
            // txtComentariosProducto
            // 
            this.txtComentariosProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentariosProducto.Location = new System.Drawing.Point(7, 398);
            this.txtComentariosProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentariosProducto.Name = "txtComentariosProducto";
            this.txtComentariosProducto.Size = new System.Drawing.Size(279, 73);
            this.txtComentariosProducto.TabIndex = 15;
            this.txtComentariosProducto.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Comentarios del Producto";
            // 
            // txtContactoMarca
            // 
            this.txtContactoMarca.Location = new System.Drawing.Point(7, 606);
            this.txtContactoMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactoMarca.Name = "txtContactoMarca";
            this.txtContactoMarca.Size = new System.Drawing.Size(279, 22);
            this.txtContactoMarca.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 586);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Contacto de la marca";
            // 
            // txtPaisMarca
            // 
            this.txtPaisMarca.Location = new System.Drawing.Point(7, 549);
            this.txtPaisMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaisMarca.Name = "txtPaisMarca";
            this.txtPaisMarca.Size = new System.Drawing.Size(279, 22);
            this.txtPaisMarca.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 529);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "País de la marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(7, 496);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(279, 22);
            this.txtMarca.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 476);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Marca del producto";
            // 
            // cmbTipoUM
            // 
            this.cmbTipoUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUM.FormattingEnabled = true;
            this.cmbTipoUM.Items.AddRange(new object[] {
            "Kilogramo (kg)",
            "Gramo (g)",
            "Litro (l)",
            "Mililitro (ml)",
            "Metro (m)",
            "Centímetro (m)",
            "Milímetro (mm",
            "Pieza (pz)",
            "Paquete (pkg)",
            "Caja (box)",
            "Galón (gal)",
            "Onza (oz)",
            "Libra (lb)",
            "Tonelada (t)",
            "Unidad (u)"});
            this.cmbTipoUM.Location = new System.Drawing.Point(325, 73);
            this.cmbTipoUM.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUM.Name = "cmbTipoUM";
            this.cmbTipoUM.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoUM.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Unidad de Medida";
            // 
            // txtNombrePresentacion
            // 
            this.txtNombrePresentacion.Location = new System.Drawing.Point(325, 128);
            this.txtNombrePresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombrePresentacion.Name = "txtNombrePresentacion";
            this.txtNombrePresentacion.Size = new System.Drawing.Size(279, 22);
            this.txtNombrePresentacion.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Nombre de la presentación";
            // 
            // txtDescripcionPresentacion
            // 
            this.txtDescripcionPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionPresentacion.Location = new System.Drawing.Point(325, 183);
            this.txtDescripcionPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionPresentacion.Name = "txtDescripcionPresentacion";
            this.txtDescripcionPresentacion.Size = new System.Drawing.Size(279, 73);
            this.txtDescripcionPresentacion.TabIndex = 27;
            this.txtDescripcionPresentacion.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Descripción de la presentación";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(321, 266);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(137, 17);
            this.lblProducto.TabIndex = 29;
            this.lblProducto.Text = "Imagen del producto";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(508, 398);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(97, 59);
            this.btnCargarImagen.TabIndex = 30;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(325, 496);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(279, 22);
            this.txtStock.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 476);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Stock";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(325, 528);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 59);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtImagenPath
            // 
            this.txtImagenPath.Location = new System.Drawing.Point(721, 75);
            this.txtImagenPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtImagenPath.Name = "txtImagenPath";
            this.txtImagenPath.Size = new System.Drawing.Size(279, 22);
            this.txtImagenPath.TabIndex = 34;
            this.txtImagenPath.Visible = false;
            // 
            // pbImagenProducto
            // 
            this.pbImagenProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImagenProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagenProducto.InitialImage = global::AdminRepartoApp.Properties.Resources.cerrar_sesion;
            this.pbImagenProducto.Location = new System.Drawing.Point(325, 286);
            this.pbImagenProducto.Margin = new System.Windows.Forms.Padding(4);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(174, 171);
            this.pbImagenProducto.TabIndex = 28;
            this.pbImagenProducto.TabStop = false;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 646);
            this.Controls.Add(this.txtImagenPath);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.txtDescripcionPresentacion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNombrePresentacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbTipoUM);
            this.Controls.Add(this.txtContactoMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPaisMarca);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComentariosProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPaisFabricante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDetalleProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmProducto";
            this.Text = "Añadir Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtDetalleProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPaisFabricante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtComentariosProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactoMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaisMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoUM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombrePresentacion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox txtDescripcionPresentacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtImagenPath;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}