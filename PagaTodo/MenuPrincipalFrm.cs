﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagaTodo
{
    public partial class MenuPrincipalFrm : Form
    {
        public MenuPrincipalFrm()
        {
            InitializeComponent();
        }

        private void registroDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPagosFrm registrarPagosFrm = new RegistrarPagosFrm();
            registrarPagosFrm.Show();
        }
    }
}
