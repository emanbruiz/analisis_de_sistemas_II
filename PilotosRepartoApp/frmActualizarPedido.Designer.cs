
namespace PilotosRepartoApp
{
    partial class frmActualizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarPedido));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActualizarEstadodelPedido = new System.Windows.Forms.Label();
            this.cmbFiltrar = new System.Windows.Forms.ComboBox();
            this.btnMarcarEntregado = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblSeleccioneUnPedido = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.btnRetrasado = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(113)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.lblActualizarEstadodelPedido);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(145)))), ((int)(((byte)(104)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 41);
            this.panel1.TabIndex = 12;
            // 
            // lblActualizarEstadodelPedido
            // 
            this.lblActualizarEstadodelPedido.AutoSize = true;
            this.lblActualizarEstadodelPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizarEstadodelPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblActualizarEstadodelPedido.Location = new System.Drawing.Point(12, 9);
            this.lblActualizarEstadodelPedido.Name = "lblActualizarEstadodelPedido";
            this.lblActualizarEstadodelPedido.Size = new System.Drawing.Size(278, 24);
            this.lblActualizarEstadodelPedido.TabIndex = 0;
            this.lblActualizarEstadodelPedido.Text = "Actualizar Estado del Pedido";
            // 
            // cmbFiltrar
            // 
            this.cmbFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrar.FormattingEnabled = true;
            this.cmbFiltrar.Location = new System.Drawing.Point(14, 80);
            this.cmbFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbFiltrar.Name = "cmbFiltrar";
            this.cmbFiltrar.Size = new System.Drawing.Size(278, 21);
            this.cmbFiltrar.TabIndex = 1;
            this.cmbFiltrar.SelectedIndexChanged += new System.EventHandler(this.cmbFiltrar_SelectedIndexChanged);
            // 
            // btnMarcarEntregado
            // 
            this.btnMarcarEntregado.Location = new System.Drawing.Point(14, 360);
            this.btnMarcarEntregado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMarcarEntregado.Name = "btnMarcarEntregado";
            this.btnMarcarEntregado.Size = new System.Drawing.Size(92, 26);
            this.btnMarcarEntregado.TabIndex = 3;
            this.btnMarcarEntregado.Text = "Entregado";
            this.btnMarcarEntregado.UseVisualStyleBackColor = true;
            this.btnMarcarEntregado.Click += new System.EventHandler(this.btnMarcarEntregado_Click);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(295, 79);
            this.btnLimpiarFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(82, 21);
            this.btnLimpiarFiltro.TabIndex = 2;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // lblSeleccioneUnPedido
            // 
            this.lblSeleccioneUnPedido.AutoSize = true;
            this.lblSeleccioneUnPedido.Location = new System.Drawing.Point(14, 63);
            this.lblSeleccioneUnPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeleccioneUnPedido.Name = "lblSeleccioneUnPedido";
            this.lblSeleccioneUnPedido.Size = new System.Drawing.Size(110, 13);
            this.lblSeleccioneUnPedido.TabIndex = 16;
            this.lblSeleccioneUnPedido.Text = "Seleccione un pedido";
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(14, 105);
            this.dgvPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.RowHeadersWidth = 51;
            this.dgvPedidos.RowTemplate.Height = 24;
            this.dgvPedidos.Size = new System.Drawing.Size(364, 251);
            this.dgvPedidos.TabIndex = 17;
            // 
            // btnRetrasado
            // 
            this.btnRetrasado.Location = new System.Drawing.Point(286, 360);
            this.btnRetrasado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRetrasado.Name = "btnRetrasado";
            this.btnRetrasado.Size = new System.Drawing.Size(92, 26);
            this.btnRetrasado.TabIndex = 4;
            this.btnRetrasado.Text = "Marcar Retraso";
            this.btnRetrasado.UseVisualStyleBackColor = true;
            this.btnRetrasado.Click += new System.EventHandler(this.btnRetrasado_Click);
            // 
            // frmActualizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 398);
            this.Controls.Add(this.btnRetrasado);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblSeleccioneUnPedido);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.btnMarcarEntregado);
            this.Controls.Add(this.cmbFiltrar);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmActualizarPedido";
            this.Text = "Actualizar Estado del Pedido";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActualizarEstadodelPedido;
        private System.Windows.Forms.ComboBox cmbFiltrar;
        private System.Windows.Forms.Button btnMarcarEntregado;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblSeleccioneUnPedido;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Button btnRetrasado;
    }
}