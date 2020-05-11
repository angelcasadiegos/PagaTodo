using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using Entity;

namespace PagaTodo
{
    public partial class ConsultarPagosFrm : Form
    {
        EntidadService entidadService = new EntidadService();
        RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
        ExportacionService exportarservice = new ExportacionService();

        string CreditosInscritoss;
        string CreditosSimples;
        string CreditosCompuestos;
        string TotalCreditosGenerales;
        string TotalCreditosSimples;
        string TotalCreditosCompuestos;
        public ConsultarPagosFrm()
        {
            InitializeComponent();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {

        }

        private void Consultar()
        {


            if (ConsultaSelectedIndex == 0)
            {
                respuestaConsulta = creditoService.Consultar();
                dataGridView1.DataSource = respuestaConsulta.creditos;
                TotalCreditosGenerales = creditoService.SumarCreditos().ToString();
                TotalCreditosSimples = "0";
                TotalCreditosCompuestos = "0";

            }

            else if (TipoConsultacmb.SelectedIndex == 1)
            {
                dataGridView1.DataSource = creditoService.ListaCreditosSimples();
                CreditosInscritoss = CreditosSimples;
                CreditosCompuestos = "0";
                TotalCreditosGenerales = "0";
                TotalCreditosSimples = creditoService.SumarCreditosSimples().ToString();
                TotalCreditosCompuestos = "0";
            }

            else if (TipoConsultacmb.SelectedIndex == 2)
            {
                dataGridView1.DataSource = creditoService.ListaCreditosCompuestos();
                CreditosInscritoss = CreditosCompuestos;
                CreditosSimples = "0";
                TotalCreditosGenerales = "0";
                TotalCreditosCompuestos = creditoService.SumarCreditosCompuestos().ToString();
                TotalCreditosSimples = "0";

            }

            else if (TipoConsultacmb.SelectedIndex == 3)
            {
                dataGridView1.DataSource = creditoService.ConsultaPorNombre(ComparaNombretxt.Text);

            }

            else if (TipoConsultacmb.SelectedIndex == 4)
            {
                DateTime fecha = DtFechaConsulta.Value.Date;
                dataGridView1.DataSource = creditoService.ConsultarXFecha(fecha);
                TotalCreditosGenerales = creditoService.ConsultarXFecha(fecha).Sum(l => l.CapitalFinal).ToString();
                CreditosInscritoss = creditoService.ConsultarXFecha(fecha).Count().ToString();

                TotalCreditosSimples = "0";
                TotalCreditosCompuestos = "0";

            }
            else if (TipoConsultacmb.SelectedIndex == 5)
            {

                DateTime fecha = DtFechaConsulta.Value.Date;
                dataGridView1.DataSource = creditoService.ConsultarXFechaSimples(fecha);
                CreditosSimples = creditoService.ConsultarXFechaSimples(fecha).Count().ToString();
                CreditosInscritoss = "0";
                CreditosCompuestos = "0";
                TotalCreditosSimples = creditoService.ConsultarXFechaSimples(fecha).Sum(l => l.CapitalFinal).ToString();
                TotalCreditosGenerales = "0";
                TotalCreditosCompuestos = "0";
            }
            else if (TipoConsultacmb.SelectedIndex == 6)
            {
                DateTime fecha = DtFechaConsulta.Value.Date;
                dataGridView1.DataSource = creditoService.ConsultarXFechaCompuestos(fecha);
                CreditosSimples = "0";
                CreditosInscritoss = "0";
                CreditosCompuestos = creditoService.ConsultarXFechaCompuestos(fecha).Count().ToString();
                TotalCreditosSimples = "0";
                TotalCreditosGenerales = "0";
                TotalCreditosCompuestos = creditoService.ConsultarXFechaCompuestos(fecha).Sum(l => l.CapitalFinal).ToString();

            }

            LLenarVacios();
        }
    }
}
