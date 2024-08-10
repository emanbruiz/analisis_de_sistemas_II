
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblAnadirProductos = new System.Windows.Forms.Label();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblDetallesP = new System.Windows.Forms.Label();
            this.txtDetalleProducto = new System.Windows.Forms.RichTextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioP = new System.Windows.Forms.Label();
            this.txtPaisFabricante = new System.Windows.Forms.TextBox();
            this.lblPaisP = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lblIVAP = new System.Windows.Forms.Label();
            this.txtComentariosProducto = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtContactoMarca = new System.Windows.Forms.TextBox();
            this.lblContactoM = new System.Windows.Forms.Label();
            this.txtPaisMarca = new System.Windows.Forms.TextBox();
            this.lblPaisM = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarcaP = new System.Windows.Forms.Label();
            this.cmbTipoUM = new System.Windows.Forms.ComboBox();
            this.lblUnidadM = new System.Windows.Forms.Label();
            this.txtNombrePresentacion = new System.Windows.Forms.TextBox();
            this.lblNombrePresentacion = new System.Windows.Forms.Label();
            this.txtDescripcionPresentacion = new System.Windows.Forms.RichTextBox();
            this.lblDescripcionP = new System.Windows.Forms.Label();
            this.lblImagenProducto = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
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
            this.pnlMain.Controls.Add(this.lblAnadirProductos);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(623, 49);
            this.pnlMain.TabIndex = 2;
            // 
            // lblAnadirProductos
            // 
            this.lblAnadirProductos.AutoSize = true;
            this.lblAnadirProductos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnadirProductos.ForeColor = System.Drawing.Color.White;
            this.lblAnadirProductos.Location = new System.Drawing.Point(5, 11);
            this.lblAnadirProductos.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnadirProductos.Name = "lblAnadirProductos";
            this.lblAnadirProductos.Size = new System.Drawing.Size(216, 32);
            this.lblAnadirProductos.TabIndex = 0;
            this.lblAnadirProductos.Text = "Añadir Productos";
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(3, 54);
            this.lblNombreP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(141, 17);
            this.lblNombreP.TabIndex = 3;
            this.lblNombreP.Text = "Nombre del producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(7, 74);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(279, 22);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // lblDetallesP
            // 
            this.lblDetallesP.AutoSize = true;
            this.lblDetallesP.Location = new System.Drawing.Point(3, 108);
            this.lblDetallesP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetallesP.Name = "lblDetallesP";
            this.lblDetallesP.Size = new System.Drawing.Size(142, 17);
            this.lblDetallesP.TabIndex = 5;
            this.lblDetallesP.Text = "Detalles del producto";
            this.lblDetallesP.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDetalleProducto
            // 
            this.txtDetalleProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalleProducto.Location = new System.Drawing.Point(7, 128);
            this.txtDetalleProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDetalleProducto.Name = "txtDetalleProducto";
            this.txtDetalleProducto.Size = new System.Drawing.Size(279, 73);
            this.txtDetalleProducto.TabIndex = 2;
            this.txtDetalleProducto.Text = "";
            this.txtDetalleProducto.TextChanged += new System.EventHandler(this.txtDetalleProducto_TextChanged);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(7, 233);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(279, 22);
            this.txtPrecioProducto.TabIndex = 3;
            // 
            // lblPrecioP
            // 
            this.lblPrecioP.AutoSize = true;
            this.lblPrecioP.Location = new System.Drawing.Point(3, 213);
            this.lblPrecioP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioP.Name = "lblPrecioP";
            this.lblPrecioP.Size = new System.Drawing.Size(131, 17);
            this.lblPrecioP.TabIndex = 8;
            this.lblPrecioP.Text = "Precio del producto";
            // 
            // txtPaisFabricante
            // 
            this.txtPaisFabricante.Location = new System.Drawing.Point(7, 286);
            this.txtPaisFabricante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaisFabricante.Name = "txtPaisFabricante";
            this.txtPaisFabricante.Size = new System.Drawing.Size(279, 22);
            this.txtPaisFabricante.TabIndex = 4;
            // 
            // lblPaisP
            // 
            this.lblPaisP.AutoSize = true;
            this.lblPaisP.Location = new System.Drawing.Point(3, 266);
            this.lblPaisP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaisP.Name = "lblPaisP";
            this.lblPaisP.Size = new System.Drawing.Size(102, 17);
            this.lblPaisP.TabIndex = 10;
            this.lblPaisP.Text = "País fabricante";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(7, 342);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(279, 22);
            this.txtIVA.TabIndex = 5;
            // 
            // lblIVAP
            // 
            this.lblIVAP.AutoSize = true;
            this.lblIVAP.Location = new System.Drawing.Point(3, 322);
            this.lblIVAP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIVAP.Name = "lblIVAP";
            this.lblIVAP.Size = new System.Drawing.Size(29, 17);
            this.lblIVAP.TabIndex = 12;
            this.lblIVAP.Text = "IVA";
            // 
            // txtComentariosProducto
            // 
            this.txtComentariosProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentariosProducto.Location = new System.Drawing.Point(7, 398);
            this.txtComentariosProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComentariosProducto.Name = "txtComentariosProducto";
            this.txtComentariosProducto.Size = new System.Drawing.Size(279, 73);
            this.txtComentariosProducto.TabIndex = 6;
            this.txtComentariosProducto.Text = "";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Location = new System.Drawing.Point(3, 378);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(171, 17);
            this.lblComentarios.TabIndex = 14;
            this.lblComentarios.Text = "Comentarios del Producto";
            // 
            // txtContactoMarca
            // 
            this.txtContactoMarca.Location = new System.Drawing.Point(7, 606);
            this.txtContactoMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContactoMarca.Name = "txtContactoMarca";
            this.txtContactoMarca.Size = new System.Drawing.Size(279, 22);
            this.txtContactoMarca.TabIndex = 9;
            // 
            // lblContactoM
            // 
            this.lblContactoM.AutoSize = true;
            this.lblContactoM.Location = new System.Drawing.Point(3, 586);
            this.lblContactoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactoM.Name = "lblContactoM";
            this.lblContactoM.Size = new System.Drawing.Size(142, 17);
            this.lblContactoM.TabIndex = 20;
            this.lblContactoM.Text = "Contacto de la marca";
            // 
            // txtPaisMarca
            // 
            this.txtPaisMarca.Location = new System.Drawing.Point(7, 549);
            this.txtPaisMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPaisMarca.Name = "txtPaisMarca";
            this.txtPaisMarca.Size = new System.Drawing.Size(279, 22);
            this.txtPaisMarca.TabIndex = 8;
            // 
            // lblPaisM
            // 
            this.lblPaisM.AutoSize = true;
            this.lblPaisM.Location = new System.Drawing.Point(3, 529);
            this.lblPaisM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaisM.Name = "lblPaisM";
            this.lblPaisM.Size = new System.Drawing.Size(113, 17);
            this.lblPaisM.TabIndex = 18;
            this.lblPaisM.Text = "País de la marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(7, 496);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(279, 22);
            this.txtMarca.TabIndex = 7;
            // 
            // lblMarcaP
            // 
            this.lblMarcaP.AutoSize = true;
            this.lblMarcaP.Location = new System.Drawing.Point(3, 476);
            this.lblMarcaP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcaP.Name = "lblMarcaP";
            this.lblMarcaP.Size = new System.Drawing.Size(130, 17);
            this.lblMarcaP.TabIndex = 16;
            this.lblMarcaP.Text = "Marca del producto";
            // 
            // cmbTipoUM
            // 
            this.cmbTipoUM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUM.FormattingEnabled = true;
            this.cmbTipoUM.ItemHeight = 16;
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
            this.cmbTipoUM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoUM.Name = "cmbTipoUM";
            this.cmbTipoUM.Size = new System.Drawing.Size(280, 24);
            this.cmbTipoUM.TabIndex = 10;
            // 
            // lblUnidadM
            // 
            this.lblUnidadM.AutoSize = true;
            this.lblUnidadM.Location = new System.Drawing.Point(321, 54);
            this.lblUnidadM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidadM.Name = "lblUnidadM";
            this.lblUnidadM.Size = new System.Drawing.Size(123, 17);
            this.lblUnidadM.TabIndex = 23;
            this.lblUnidadM.Text = "Unidad de Medida";
            // 
            // txtNombrePresentacion
            // 
            this.txtNombrePresentacion.Location = new System.Drawing.Point(325, 128);
            this.txtNombrePresentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombrePresentacion.Name = "txtNombrePresentacion";
            this.txtNombrePresentacion.Size = new System.Drawing.Size(279, 22);
            this.txtNombrePresentacion.TabIndex = 11;
            // 
            // lblNombrePresentacion
            // 
            this.lblNombrePresentacion.AutoSize = true;
            this.lblNombrePresentacion.Location = new System.Drawing.Point(321, 108);
            this.lblNombrePresentacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombrePresentacion.Name = "lblNombrePresentacion";
            this.lblNombrePresentacion.Size = new System.Drawing.Size(179, 17);
            this.lblNombrePresentacion.TabIndex = 24;
            this.lblNombrePresentacion.Text = "Nombre de la presentación";
            // 
            // txtDescripcionPresentacion
            // 
            this.txtDescripcionPresentacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcionPresentacion.Location = new System.Drawing.Point(325, 183);
            this.txtDescripcionPresentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionPresentacion.Name = "txtDescripcionPresentacion";
            this.txtDescripcionPresentacion.Size = new System.Drawing.Size(279, 73);
            this.txtDescripcionPresentacion.TabIndex = 12;
            this.txtDescripcionPresentacion.Text = "";
            // 
            // lblDescripcionP
            // 
            this.lblDescripcionP.AutoSize = true;
            this.lblDescripcionP.Location = new System.Drawing.Point(321, 164);
            this.lblDescripcionP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionP.Name = "lblDescripcionP";
            this.lblDescripcionP.Size = new System.Drawing.Size(203, 17);
            this.lblDescripcionP.TabIndex = 26;
            this.lblDescripcionP.Text = "Descripción de la presentación";
            // 
            // lblImagenProducto
            // 
            this.lblImagenProducto.AutoSize = true;
            this.lblImagenProducto.Location = new System.Drawing.Point(321, 266);
            this.lblImagenProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagenProducto.Name = "lblImagenProducto";
            this.lblImagenProducto.Size = new System.Drawing.Size(137, 17);
            this.lblImagenProducto.TabIndex = 29;
            this.lblImagenProducto.Text = "Imagen del producto";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(508, 398);
            this.btnCargarImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(97, 59);
            this.btnCargarImagen.TabIndex = 13;
            this.btnCargarImagen.Text = "Cargar imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(325, 496);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(279, 22);
            this.txtStock.TabIndex = 14;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(321, 476);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(43, 17);
            this.lblStock.TabIndex = 31;
            this.lblStock.Text = "Stock";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(325, 528);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 59);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtImagenPath
            // 
            this.txtImagenPath.Location = new System.Drawing.Point(721, 75);
            this.txtImagenPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.pbImagenProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbImagenProducto.Name = "pbImagenProducto";
            this.pbImagenProducto.Size = new System.Drawing.Size(174, 171);
            this.pbImagenProducto.TabIndex = 28;
            this.pbImagenProducto.TabStop = false;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 641);
            this.Controls.Add(this.txtImagenPath);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.lblImagenProducto);
            this.Controls.Add(this.pbImagenProducto);
            this.Controls.Add(this.txtDescripcionPresentacion);
            this.Controls.Add(this.lblDescripcionP);
            this.Controls.Add(this.txtNombrePresentacion);
            this.Controls.Add(this.lblNombrePresentacion);
            this.Controls.Add(this.lblUnidadM);
            this.Controls.Add(this.cmbTipoUM);
            this.Controls.Add(this.txtContactoMarca);
            this.Controls.Add(this.lblContactoM);
            this.Controls.Add(this.txtPaisMarca);
            this.Controls.Add(this.lblPaisM);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarcaP);
            this.Controls.Add(this.txtComentariosProducto);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.lblIVAP);
            this.Controls.Add(this.txtPaisFabricante);
            this.Controls.Add(this.lblPaisP);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.lblPrecioP);
            this.Controls.Add(this.txtDetalleProducto);
            this.Controls.Add(this.lblDetallesP);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblAnadirProductos;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblDetallesP;
        private System.Windows.Forms.RichTextBox txtDetalleProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblPrecioP;
        private System.Windows.Forms.TextBox txtPaisFabricante;
        private System.Windows.Forms.Label lblPaisP;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label lblIVAP;
        private System.Windows.Forms.RichTextBox txtComentariosProducto;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.TextBox txtContactoMarca;
        private System.Windows.Forms.Label lblContactoM;
        private System.Windows.Forms.TextBox txtPaisMarca;
        private System.Windows.Forms.Label lblPaisM;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarcaP;
        private System.Windows.Forms.ComboBox cmbTipoUM;
        private System.Windows.Forms.Label lblUnidadM;
        private System.Windows.Forms.TextBox txtNombrePresentacion;
        private System.Windows.Forms.Label lblNombrePresentacion;
        private System.Windows.Forms.RichTextBox txtDescripcionPresentacion;
        private System.Windows.Forms.Label lblDescripcionP;
        private System.Windows.Forms.PictureBox pbImagenProducto;
        private System.Windows.Forms.Label lblImagenProducto;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtImagenPath;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}