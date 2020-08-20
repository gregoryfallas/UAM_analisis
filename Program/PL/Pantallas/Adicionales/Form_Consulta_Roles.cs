﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Entidades;

namespace PL.Pantallas.Adicionales
{
    public partial class Form_Consulta_Roles : Form
    {
        public Form_Consulta_Roles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Menu_Reclutamiento atras = new Adicionales.Form_Menu_Reclutamiento();
            atras.ShowDialog();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ROLES> lstresultados = R_Humanos.Obtener_Roles();

                this.dgvroles.DataSource = lstresultados;
                this.dgvroles.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
