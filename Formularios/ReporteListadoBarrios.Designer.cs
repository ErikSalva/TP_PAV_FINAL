namespace TP_PAV_v1.Formularios
{
    partial class ReporteListadoBarrios
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
            this.txtIngreseLetra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbXLocalidad = new System.Windows.Forms.ComboBox();
            this.rb_x_localidad = new System.Windows.Forms.RadioButton();
            this.rb_letra = new System.Windows.Forms.RadioButton();
            this.rb_rango_id = new System.Windows.Forms.RadioButton();
            this.rb_todos = new System.Windows.Forms.RadioButton();
            this.txtHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRangoDesde = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rptBarrios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIngreseLetra
            // 
            this.txtIngreseLetra.Location = new System.Drawing.Point(634, 114);
            this.txtIngreseLetra.Name = "txtIngreseLetra";
            this.txtIngreseLetra.Size = new System.Drawing.Size(65, 20);
            this.txtIngreseLetra.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(533, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Ingrese letra";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbXLocalidad);
            this.panel2.Controls.Add(this.rb_x_localidad);
            this.panel2.Controls.Add(this.rb_letra);
            this.panel2.Controls.Add(this.rb_rango_id);
            this.panel2.Controls.Add(this.rb_todos);
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 106);
            this.panel2.TabIndex = 84;
            // 
            // cmbXLocalidad
            // 
            this.cmbXLocalidad.FormattingEnabled = true;
            this.cmbXLocalidad.Location = new System.Drawing.Point(231, 71);
            this.cmbXLocalidad.Name = "cmbXLocalidad";
            this.cmbXLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbXLocalidad.TabIndex = 68;
            this.cmbXLocalidad.Visible = false;
            // 
            // rb_x_localidad
            // 
            this.rb_x_localidad.AutoSize = true;
            this.rb_x_localidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_x_localidad.ForeColor = System.Drawing.Color.White;
            this.rb_x_localidad.Location = new System.Drawing.Point(6, 72);
            this.rb_x_localidad.Name = "rb_x_localidad";
            this.rb_x_localidad.Size = new System.Drawing.Size(201, 20);
            this.rb_x_localidad.TabIndex = 67;
            this.rb_x_localidad.TabStop = true;
            this.rb_x_localidad.Text = "Restringido por localidad";
            this.rb_x_localidad.UseVisualStyleBackColor = true;
            this.rb_x_localidad.CheckedChanged += new System.EventHandler(this.rb_x_localidad_CheckedChanged);
            // 
            // rb_letra
            // 
            this.rb_letra.AutoSize = true;
            this.rb_letra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_letra.ForeColor = System.Drawing.Color.White;
            this.rb_letra.Location = new System.Drawing.Point(6, 43);
            this.rb_letra.Name = "rb_letra";
            this.rb_letra.Size = new System.Drawing.Size(306, 20);
            this.rb_letra.TabIndex = 66;
            this.rb_letra.TabStop = true;
            this.rb_letra.Text = "Restringido por primera letra del nombre";
            this.rb_letra.UseVisualStyleBackColor = true;
            this.rb_letra.CheckedChanged += new System.EventHandler(this.rb_letra_CheckedChanged);
            // 
            // rb_rango_id
            // 
            this.rb_rango_id.AutoSize = true;
            this.rb_rango_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.rb_rango_id.ForeColor = System.Drawing.Color.White;
            this.rb_rango_id.Location = new System.Drawing.Point(88, 15);
            this.rb_rango_id.Name = "rb_rango_id";
            this.rb_rango_id.Size = new System.Drawing.Size(215, 20);
            this.rb_rango_id.TabIndex = 64;
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
            this.rb_todos.Location = new System.Drawing.Point(6, 15);
            this.rb_todos.Name = "rb_todos";
            this.rb_todos.Size = new System.Drawing.Size(70, 20);
            this.rb_todos.TabIndex = 65;
            this.rb_todos.TabStop = true;
            this.rb_todos.Text = "Todos";
            this.rb_todos.UseVisualStyleBackColor = true;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(634, 82);
            this.txtHasta.Mask = "9999";
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(65, 20);
            this.txtHasta.TabIndex = 83;
            this.txtHasta.ValidatingType = typeof(int);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(634, 50);
            this.txtDesde.Mask = "9999";
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(65, 20);
            this.txtDesde.TabIndex = 82;
            this.txtDesde.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(482, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Ingrese rango hasta";
            // 
            // lblRangoDesde
            // 
            this.lblRangoDesde.AutoSize = true;
            this.lblRangoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangoDesde.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRangoDesde.Location = new System.Drawing.Point(476, 55);
            this.lblRangoDesde.Name = "lblRangoDesde";
            this.lblRangoDesde.Size = new System.Drawing.Size(151, 16);
            this.lblRangoDesde.TabIndex = 80;
            this.lblRangoDesde.Text = "Ingrese rango desde";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(730, 120);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 29);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(329, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "Reporte de barrios";
            // 
            // rptBarrios
            // 
            this.rptBarrios.BackColor = System.Drawing.Color.Gainsboro;
            this.rptBarrios.LocalReport.ReportEmbeddedResource = "TP_PAV_v1.ReporteBarrios.rdlc";
            this.rptBarrios.Location = new System.Drawing.Point(12, 165);
            this.rptBarrios.Name = "rptBarrios";
            this.rptBarrios.ServerReport.BearerToken = null;
            this.rptBarrios.Size = new System.Drawing.Size(800, 367);
            this.rptBarrios.TabIndex = 77;
            // 
            // ReporteListadoBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(3)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(824, 543);
            this.Controls.Add(this.txtIngreseLetra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRangoDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rptBarrios);
            this.Name = "ReporteListadoBarrios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de barrios";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIngreseLetra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbXLocalidad;
        private System.Windows.Forms.RadioButton rb_x_localidad;
        private System.Windows.Forms.RadioButton rb_letra;
        private System.Windows.Forms.RadioButton rb_rango_id;
        private System.Windows.Forms.RadioButton rb_todos;
        private System.Windows.Forms.MaskedTextBox txtHasta;
        private System.Windows.Forms.MaskedTextBox txtDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRangoDesde;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer rptBarrios;
    }
}