namespace TP_PAV_v1.Formularios
{
    partial class ReporteListadoCamiones
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
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.btnBuscarModelo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModeloReporte = new System.Windows.Forms.TextBox();
            this.txtMarcaReporte = new System.Windows.Forms.TextBox();
            this.lblMarcaReporte = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarMarca.Location = new System.Drawing.Point(567, 74);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(82, 29);
            this.btnBuscarMarca.TabIndex = 78;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = false;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // btnBuscarModelo
            // 
            this.btnBuscarModelo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarModelo.Location = new System.Drawing.Point(242, 74);
            this.btnBuscarModelo.Name = "btnBuscarModelo";
            this.btnBuscarModelo.Size = new System.Drawing.Size(82, 29);
            this.btnBuscarModelo.TabIndex = 77;
            this.btnBuscarModelo.Text = "Buscar";
            this.btnBuscarModelo.UseVisualStyleBackColor = false;
            this.btnBuscarModelo.Click += new System.EventHandler(this.btnBuscarModelo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(238, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 76;
            this.label4.Text = "Reporte de camiones";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(11, 77);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(80, 24);
            this.lblModelo.TabIndex = 75;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModeloReporte
            // 
            this.txtModeloReporte.Location = new System.Drawing.Point(97, 80);
            this.txtModeloReporte.Name = "txtModeloReporte";
            this.txtModeloReporte.Size = new System.Drawing.Size(121, 20);
            this.txtModeloReporte.TabIndex = 74;
            // 
            // txtMarcaReporte
            // 
            this.txtMarcaReporte.Location = new System.Drawing.Point(428, 81);
            this.txtMarcaReporte.Name = "txtMarcaReporte";
            this.txtMarcaReporte.Size = new System.Drawing.Size(121, 20);
            this.txtMarcaReporte.TabIndex = 73;
            // 
            // lblMarcaReporte
            // 
            this.lblMarcaReporte.AutoSize = true;
            this.lblMarcaReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaReporte.ForeColor = System.Drawing.Color.White;
            this.lblMarcaReporte.Location = new System.Drawing.Point(355, 80);
            this.lblMarcaReporte.Name = "lblMarcaReporte";
            this.lblMarcaReporte.Size = new System.Drawing.Size(67, 24);
            this.lblMarcaReporte.TabIndex = 72;
            this.lblMarcaReporte.Text = "Marca";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAV_v1.ListadoDeCamiones.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 126);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(637, 389);
            this.reportViewer1.TabIndex = 71;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // ReporteListadoCamiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(661, 532);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.btnBuscarModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtModeloReporte);
            this.Controls.Add(this.txtMarcaReporte);
            this.Controls.Add(this.lblMarcaReporte);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoCamiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de camiones";
            this.Load += new System.EventHandler(this.ReporteListadoCamiones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.Button btnBuscarModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModeloReporte;
        private System.Windows.Forms.TextBox txtMarcaReporte;
        private System.Windows.Forms.Label lblMarcaReporte;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}