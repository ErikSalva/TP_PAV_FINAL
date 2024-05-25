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
    public partial class ReporteListadoProvincias : Form
    {
        public ReporteListadoProvincias()
        {
            InitializeComponent();
            rb_todos.Checked = true;
            txtDesde.Enabled = false;
            txtHasta.Enabled = false;
            
        }

        private void ReporteTurnos_Load(object sender, EventArgs e)
        {

            this.rptProvincia.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sentencia = "";
            string alcance = "";
            if (rb_todos.Checked)
            {
                cargarProvincias("");
                alcance = "Todas las provincias";
            }

            bool resultado = ValidarCampos();
            if (resultado)
            {
                if (rb_rango_id.Checked)
                {
                    int idDesde = Convert.ToInt32(txtDesde.Text);
                    int idHasta = Convert.ToInt32(txtHasta.Text);
                    sentencia = $" where Id_Prov >= '{idDesde}' AND Id_Prov <= '{idHasta}'";
                    alcance = "Rango de id de las provincias. Inicio: " + idDesde.ToString() + " - Final: " + idHasta.ToString();
                    LimpiarCampos();
                }
                if (rb_rango_cod.Checked)
                {
                    int idDesde = Convert.ToInt32(txtDesde.Text);
                    int idHasta = Convert.ToInt32(txtHasta.Text);
                    sentencia = $" where Cod_Postal >= '{idDesde}' AND Cod_Postal <= '{idHasta}' ORDER BY Cod_Postal";
                    alcance = "Rango de códigos postales. Inicio: " + idDesde.ToString() + " - Final: " + idHasta.ToString();
                    LimpiarCampos();
                }
            }
            else if (resultado = true && rb_todos.Checked == false)
            {
                MessageBox.Show("No ingresó los rangos");
            }

            cargarProvincias(sentencia);
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("RP01", alcance);
            rptProvincia.LocalReport.SetParameters(parametros);

        }

        private void cargarProvincias(string sentencia)
        {
            DataTable tabla = new DataTable();
            string sentenciaSQL = "SELECT * FROM Provincia";
            sentenciaSQL += sentencia;
            tabla = AD_Provincias.ObtenerListadoDeProvincias(sentenciaSQL);

            ReportDataSource ds = new ReportDataSource("DatosProvincia", tabla);

            rptProvincia.LocalReport.DataSources.Clear();
            rptProvincia.LocalReport.DataSources.Add(ds);
            rptProvincia.LocalReport.Refresh();
            this.rptProvincia.RefreshReport();
        }

        private bool ValidarCampos()
        {
            bool ValidarCampos = false;
            if (txtDesde.Text.Equals("") || txtHasta.Text.Equals(""))
            {
                return ValidarCampos;
            }
            else
            {
                ValidarCampos = true;
                return ValidarCampos;
            }
        }

        private void rb_rango_id_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDesde.Enabled = true;
            txtHasta.Enabled = true;
        }

        private void rb_rango_cod_CheckedChanged_1(object sender, EventArgs e)
        {
            txtDesde.Enabled = true;
            txtHasta.Enabled = true;
        }

        private void LimpiarCampos()
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
        }
    }
}
