﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Adicionales;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Cuentas_Cobrar_PL : Form
    {
        public Frm_Cuentas_Cobrar_PL()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Tesoreria_PL Tesoreria = new Frm_Tesoreria_PL();
            Tesoreria.ShowDialog();
           
        }
    }
}
