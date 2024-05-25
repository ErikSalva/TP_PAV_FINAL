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
    public partial class ReporteListadoMarcas : Form
    {
        public ReporteListadoMarcas()
        {
            InitializeComponent();
        }

 

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {
           

            rb_todos.Checked = true;
            txtDesde.Enabled = false;
            txtHasta.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string sentenciaSQL = "";
            string alcance = "";
            if (rb_todos.Checked)
            {
                sentenciaSQL = "SELECT * FROM Marcas";
                alcance = "Todas las marcas";
            }

            bool resultado = ValidarCampos();
            if (resultado)
            {
                if (rb_rango_id.Checked)
                {
                    int idDesde = Convert.ToInt32(txtDesde.Text);
                    int idHasta = Convert.ToInt32(txtHasta.Text);
                    sentenciaSQL = $"SELECT * FROM Marcas WHERE Id_Marca >= '{idDesde}' AND Id_Marca <= '{idHasta}'";
                    alcance = "Rango de id de las provincias. Inicio: " + idDesde.ToString() + " - Final: " + idHasta.ToString();
                    LimpiarCampos();
                }
       
            }
            else if (resultado = true && rb_todos.Checked == false)
            {
                MessageBox.Show("No ingresó los rangos");
            }
            
            if (sentenciaSQL != "")
            {
                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("PR01", alcance);
                reportViewer1.LocalReport.SetParameters(parametros);


                DataTable tabla = new DataTable();
                tabla = AD_Marcas.ObtenerListadoMarcas(sentenciaSQL);

                ReportDataSource ds = new ReportDataSource("DatosDeMarcas", tabla);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds);
                reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
            }
       
        
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
        private void LimpiarCampos()
        {
            txtDesde.Text = "";
            txtHasta.Text = "";
        }

        private void rb_rango_id_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Enabled = true;
            txtHasta.Enabled = true;
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txtDesde.Enabled = false;
            txtHasta.Enabled = false;
        }
    }
}
