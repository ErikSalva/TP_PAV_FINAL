using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAV_v1.AccesoADatos;

namespace TP_PAV_v1.Formularios
{
    public partial class ReporteListadoBarrios : Form
    {
        public ReporteListadoBarrios()
        {
            InitializeComponent();
            rb_todos.Enabled = true;
            txtDesde.Enabled = false;
            txtHasta.Enabled = false;
            txtIngreseLetra.Enabled = false;
        }

        private void ReporteListadoBarrios_Load(object sender, EventArgs e)
        {
            this.rptBarrios.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string consulta = "";
            string alcance = "";

            if (rb_todos.Checked)
            {
                cargarBarrios("");
                alcance = "Todos los barrios";
            }

            if (rb_rango_id.Checked)
            {
                if (txtDesde.Text.Equals("") || txtHasta.Text.Equals(""))
                {
                    MessageBox.Show("No ingresó rangos");
                }
                else
                {
                    int idDesde = Convert.ToInt32(txtDesde.Text);
                    int idHasta = Convert.ToInt32(txtHasta.Text);
                    consulta = $" where Id_Barrio >= '{idDesde}' AND Id_Barrio <= '{idHasta}'";
                    alcance = "Rango de id de los barrios. Inicio: " + idDesde.ToString() + " - Final: " + idHasta.ToString();
                }
            }
            cargarBarrios(consulta);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", alcance);
            rptBarrios.LocalReport.SetParameters(parametros);
        }

        private void cargarBarrios(string sentencia)
        {
            DataTable tabla = new DataTable();
            string sentenciaSQL = "SELECT * FROM Barrio";
            sentenciaSQL += sentencia;
            tabla = AD_Barrios.ObtenerListadoDeBarrios(sentenciaSQL);

            ReportDataSource ds = new ReportDataSource("DatosBarrio", tabla);

            rptBarrios.LocalReport.DataSources.Clear();
            rptBarrios.LocalReport.DataSources.Add(ds);
            rptBarrios.LocalReport.Refresh();
            this.rptBarrios.RefreshReport();
        }

        private void rb_rango_id_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Enabled = true;
            txtHasta.Enabled = true;
        }

        private void rb_letra_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Enabled = false;
            txtHasta.Enabled = false;
            txtIngreseLetra.Enabled = true;
        }

        private void rb_x_localidad_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Enabled = false;
            txtHasta.Enabled = false;
            txtIngreseLetra.Enabled = false;
            cmbXLocalidad.Visible = true;
        }
    }
}
