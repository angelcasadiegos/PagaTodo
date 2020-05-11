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
        ExportarService exportarService = new ExportarService();
        string PagosRealizados;
        string TotalRecaudos;
        string nombreEntidad;
        
        public ConsultarPagosFrm()
        {
            InitializeComponent();
        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            respuestaConsulta = entidadService.Consultar();
            PagosRealizados = entidadService.TotalizarEntidades().ToString();
            TotalRecaudos = entidadService.SumarPagos().ToString();
            Consultar();

        }

        private void Consultar()
        {

            if (ConsultaEntidadesCmb.SelectedIndex == 0)
            {
                respuestaConsulta = entidadService.Consultar();
                dataGridView1.DataSource = respuestaConsulta.entidades;
                PagosRealizados = entidadService.TotalizarEntidades().ToString();
                TotalRecaudos = entidadService.SumarPagos().ToString();             

            }

            else if (ConsultaEntidadesCmb.SelectedIndex == 1)
            {                               
                dataGridView1.DataSource = entidadService.ConsultaPorNombreEntidad(ConsultaEntidadesCmb.Text);
                PagosRealizados = entidadService.TotalizarPorEntidad(ConsultaEntidadesCmb.Text).ToString();
                TotalRecaudos = entidadService.SumarPorEntidades(ConsultaEntidadesCmb.Text).ToString();                
            }
            else if (ConsultaEntidadesCmb.SelectedIndex == 2)
            {
                dataGridView1.DataSource = entidadService.ConsultaPorNombreEntidad(ConsultaEntidadesCmb.Text);
                PagosRealizados = entidadService.TotalizarPorEntidad(ConsultaEntidadesCmb.Text).ToString();
                TotalRecaudos = entidadService.SumarPorEntidades(ConsultaEntidadesCmb.Text).ToString();
            }
            else if(ConsultaEntidadesCmb.SelectedIndex == 3)
            {
                dataGridView1.DataSource = entidadService.ConsultaPorNombreEntidad(ConsultaEntidadesCmb.Text);
                PagosRealizados = entidadService.TotalizarPorEntidad(ConsultaEntidadesCmb.Text).ToString();
                TotalRecaudos = entidadService.SumarPorEntidades(ConsultaEntidadesCmb.Text).ToString();
            }
            else
            {
                DateTime fecha = dateTimePicker1.Value.Date;
                dataGridView1.DataSource = entidadService.ConsultarXFecha(fecha);
                TotalRecaudos = entidadService.ConsultarXFecha(fecha).Sum(l => l.ValorPagado).ToString();
                PagosRealizados = entidadService.ConsultarXFecha(fecha).Count().ToString();
            }

            LLenarCampos();

        }

        private void LLenarCampos()
        {
            PagosRealizadosTxt.Text = PagosRealizados;
            TotalRecaudosTxt.Text = TotalRecaudos;
        }

        private void ExportarBtn_Click(object sender, EventArgs e)
        {
            string Mensaje;
            string nombreEntidad = ConsultaEntidadesCmb.Text;
            if (ConsultaEntidadesCmb.SelectedIndex == 1)
            {
                nombreEntidad = "Electricaribe";
            }
            Mensaje = exportarService.ExportarPorEntidad(nombreEntidad, entidadService.ConsultaPorNombreEntidad);
            MessageBox.Show(Mensaje);
        }
    }
}
