﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Principales;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Campañas_PL : Form
    {
        public Frm_Campañas_PL()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }
    }
}
