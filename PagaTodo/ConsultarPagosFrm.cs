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
                nombreEntidad = ConsultaEntidadesCmb.ToString();
                
                dataGridView1.DataSource = entidadService.ConsultaPorNombreEntidad(nombreEntidad);
                PagosRealizados = entidadService.TotalizarPorEntidad(nombreEntidad).ToString();
                TotalRecaudos = entidadService.SumarPorEntidades(nombreEntidad).ToString();                
            }
            
        }
    }
}
