namespace TP_PAV_v1.Formularios
{
    partial class ReporteListadoProvincias
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
            this.rptProvincia = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreEstacion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.rb_rango_cod = new System.Windows.Forms.RadioButton();
            this.rb_rango_id = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptProvincia
            // 
            this.rptProvincia.BackColor = System.Drawing.Color.Gainsboro;
            this.rptProvincia.LocalReport.ReportEmbeddedResource = "TP_PAV_v1.ReporteProvincia.rdlc";
            this.rptProvincia.Location = new System.Drawing.Point(12, 144);
            this.rptProvincia.Name = "rptProvincia";
            this.rptProvincia.ServerReport.BearerToken = null;
            this.rptProvincia.Size = new System.Drawing.Size(800, 367);
            this.rptProvincia.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(329, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Reporte de provincias";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(709, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 29);
            this.btnBuscar.TabIndex = 58;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombreEstacion
            // 
            this.lblNombreEstacion.AutoSize = true;
            this.lblNombreEstacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEstacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombreEstacion.Location = new System.Drawing.Point(460, 56);
            this.lblNombreEstacion.Name = "lblNombreEstacion";
            this.lblNombreEstacion.Size = new System.Drawing.Size(151, 16);
            this.lblNombreEstacion.TabIndex = 60;
            this.lblNombreEstacion.Text = "Ingrese rango desde";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_rango_cod);
            this.panel1.Controls.Add(this.rb_rango_id);
            this.panel1.Controls.Add(this.rb_todos);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 100);
            this.panel1.TabIndex = 61;
            this.panel1.TabStop = false;
            // 
            // rb_rango_cod
            // 
            this.rb_rango_cod.AutoSize = true;
            this.rb_rango_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_rango_cod.ForeColor = System.Drawing.Color.White;
            this.rb_rango_cod.Location = new System.Drawing.Point(6, 53);
            this.rb_rango_cod.Name = "rb_rango_cod";
            this.rb_rango_cod.Size = new System.Drawing.Size(297, 20);
            this.rb_rango_cod.TabIndex = 62;
            this.rb_rango_cod.TabStop = true;
            this.rb_rango_cod.Text = "Restringido por rango de código postal";
            this.rb_rango_cod.UseVisualStyleBackColor = true;
            this.rb_rango_cod.CheckedChanged += new System.EventHandler(this.rb_rango_cod_CheckedChanged_1);
            // 
            // rb_rango_id
            // 
            this.rb_rango_id.AutoSize = true;
            this.rb_rango_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_rango_id.ForeColor = System.Drawing.Color.White;
            this.rb_rango_id.Location = new System.Drawing.Point(88, 25);
            this.rb_rango_id.Name = "rb_rango_id";
            this.rb_rango_id.Size = new System.Drawing.Size(215, 20);
            this.rb_rango_id.TabIndex = 60;
            this.rb_rango_id.TabStop = true;
            this.rb_rango_id.Text = "Restringido por rango de id\r\n";
            this.rb_rango_id.UseVisualStyleBackColor = true;
            this.rb_rango_id.CheckedChanged += new System.EventHandler(this.rb_rango_id_CheckedChanged_1);
            // 
            // rb_todos
            // 
            this.rb_todos.AutoSize = true;
            this.rb_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_todos.ForeColor = System.Drawing.Color.White;
            this.rb_todos.Location = new System.Drawing.Point(6, 25);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(74, 20);
            this.rb_todos.TabIndex = 61;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todas ";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(460, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 63;
            this.label1.Text = "Ingrese rango hasta";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(618, 51);
            this.txtDesde.Mask = "9999";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(65, 20);
            this.txtDesde.TabIndex = 64;
            this.txtDesde.ValidatingType = typeof(int);
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(618, 83);
            this.txtHasta.Mask = "9999";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(65, 20);
            this.txtHasta.TabIndex = 65;
            this.txtHasta.ValidatingType = typeof(int);
            // 
            // ReporteListadoProvincias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(824, 523);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombreEstacion);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rptProvincia);
            this.Name = "ReporteListadoProvincias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de turnos";
            this.Load += new System.EventHandler(this.ReporteTurnos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptProvincia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreEstacion;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.RadioButton rb_rango_cod;
        private System.Windows.Forms.RadioButton rb_rango_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.MaskedTextBox txtHasta;
    }
}