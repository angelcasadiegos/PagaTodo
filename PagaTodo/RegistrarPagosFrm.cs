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
    public partial class RegistrarPagosFrm : Form
    {
        EntidadService entidadService = new EntidadService();
        public RegistrarPagosFrm()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Entidad entidad = MapearEntidad();
            string mensaje = entidadService.Guardar(entidad);
            MessageBox.Show(mensaje);

        }

        private Entidad MapearEntidad()
        {
            Entidad entidad;
            
            if (NombreEntidadCmb.SelectedIndex == 0)
            {
                entidad = new Entidad();
            }
            else if(NombreEntidadCmb.SelectedIndex==1)
            {
                entidad = new Entidad();
            }
            else
            {
                entidad = new Entidad();
            }

            entidad.NombreEntidad = NombreEntidadCmb.Text;
            entidad.NumeroRecibo = NumeroReciboTxt.Text;
            entidad.FechadePago = dateTimePicker1.Value.Date;
            entidad.ValorPagado = decimal.Parse(ValorPagadoTxt.Text);
            return entidad;

        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            NombreEntidadCmb.Text = "";
            NumeroReciboTxt.Text = "";
            ValorPagadoTxt.Text = "";
        }
    }

}
