namespace TP_PAV_v1.Formularios
{
    partial class ReporteListadoMarcas
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rb_rango_id = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreEstacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(631, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 29);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rb_rango_id
            // 
            this.rb_rango_id.AutoSize = true;
            this.rb_rango_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_rango_id.ForeColor = System.Drawing.Color.White;
            this.rb_rango_id.Location = new System.Drawing.Point(104, 57);
            this.rb_rango_id.Name = "rb_rango_id";
            this.rb_rango_id.Size = new System.Drawing.Size(215, 20);
            this.rb_rango_id.TabIndex = 75;
            this.rb_rango_id.TabStop = true;
            this.rb_rango_id.Text = "Restringido por rango de id\r\n";
            this.rb_rango_id.UseVisualStyleBackColor = true;
            this.rb_rango_id.CheckedChanged += new System.EventHandler(this.rb_rango_id_CheckedChanged);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos.ForeColor = System.Drawing.Color.White;
            this.rb_todos.Location = new System.Drawing.Point(12, 57);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(70, 20);
            this.rb_todos.TabIndex = 76;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            this.rb_todos.CheckedChanged += new System.EventHandler(this.rb_todos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(272, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 24);
            this.label4.TabIndex = 74;
            this.label4.Text = "Reporte de marcas";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TP_PAV_v1.ListadoDeMarcas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(701, 281);
            this.reportViewer1.TabIndex = 72;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(544, 86);
            this.txtHasta.Mask = "9999";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(65, 20);
            this.txtHasta.TabIndex = 81;
            this.txtHasta.ValidatingType = typeof(int);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(544, 54);
            this.txtDesde.Mask = "9999";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(65, 20);
            this.txtDesde.TabIndex = 80;
            this.txtDesde.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(386, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 79;
            this.label1.Text = "Ingrese rango hasta";
            // 
            // lblNombreEstacion
            // 
            this.lblNombreEstacion.AutoSize = true;
            this.lblNombreEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreEstacion.Location = new System.Drawing.Point(386, 59);
            this.lblNombreEstacion.Name = "lblNombreEstacion";
            this.lblNombreEstacion.Size = new System.Drawing.Size(151, 16);
            this.lblNombreEstacion.TabIndex = 78;
            this.lblNombreEstacion.Text = "Ingrese rango desde";
            // 
            // ReporteListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(725, 421);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreEstacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.rb_rango_id);
            this.Controls.Add(this.rb_todos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteListadoMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rb_rango_id;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombreEstacion;
    }
}