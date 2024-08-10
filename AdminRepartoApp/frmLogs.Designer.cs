
namespace AdminRepartoApp
{
    partial class frmLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogs));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblLogs = new System.Windows.Forms.Label();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.cmbFiltrarEmpleado = new System.Windows.Forms.ComboBox();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnExportarLogs = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(113)))), ((int)(((byte)(236)))));
            this.pnlMain.Controls.Add(this.lblLogs);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1303, 49);
            this.pnlMain.TabIndex = 3;
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogs.ForeColor = System.Drawing.Color.White;
            this.lblLogs.Location = new System.Drawing.Point(5, 9);
            this.lblLogs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Size = new System.Drawing.Size(109, 32);
            this.lblLogs.TabIndex = 0;
            this.lblLogs.Text = "Bitácora";
            // 
            // dgvLogs
            // 
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Location = new System.Drawing.Point(11, 106);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.RowHeadersWidth = 51;
            this.dgvLogs.RowTemplate.Height = 24;
            this.dgvLogs.Size = new System.Drawing.Size(1285, 730);
            this.dgvLogs.TabIndex = 4;
            // 
            // cmbFiltrarEmpleado
            // 
            this.cmbFiltrarEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltrarEmpleado.FormattingEnabled = true;
            this.cmbFiltrarEmpleado.Location = new System.Drawing.Point(11, 77);
            this.cmbFiltrarEmpleado.Name = "cmbFiltrarEmpleado";
            this.cmbFiltrarEmpleado.Size = new System.Drawing.Size(196, 24);
            this.cmbFiltrarEmpleado.TabIndex = 1;
            // 
            // btnAplicarFiltro
            // 
            this.btnAplicarFiltro.Location = new System.Drawing.Point(213, 77);
            this.btnAplicarFiltro.Name = "btnAplicarFiltro";
            this.btnAplicarFiltro.Size = new System.Drawing.Size(75, 24);
            this.btnAplicarFiltro.TabIndex = 2;
            this.btnAplicarFiltro.Text = "Aplicar";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click_1);
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(294, 78);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 3;
            this.btnLimpiarFiltro.Text = "Limpiar";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click_1);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Location = new System.Drawing.Point(12, 57);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(46, 17);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Filtros";
            // 
            // btnExportarLogs
            // 
            this.btnExportarLogs.Location = new System.Drawing.Point(1199, 68);
            this.btnExportarLogs.Name = "btnExportarLogs";
            this.btnExportarLogs.Size = new System.Drawing.Size(97, 32);
            this.btnExportarLogs.TabIndex = 4;
            this.btnExportarLogs.Text = "Exportar";
            this.btnExportarLogs.UseVisualStyleBackColor = true;
            this.btnExportarLogs.Click += new System.EventHandler(this.btnExportarLogs_Click_1);
            // 
            // frmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 840);
            this.Controls.Add(this.btnExportarLogs);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.cmbFiltrarEmpleado);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogs";
            this.Text = "Bitácora";
            this.Load += new System.EventHandler(this.frmLogs_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.ComboBox cmbFiltrarEmpleado;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Button btnLimpiarFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnExportarLogs;
    }
}