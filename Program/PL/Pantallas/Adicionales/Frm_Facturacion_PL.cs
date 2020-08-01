using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using PL.Pantallas.Principales;
using PL.Pantallas.Extras;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Facturacion_PL : Form
    {
        public Frm_Facturacion_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
          
        }
                    

        
       
        private void Frm_Facturacion_PL_Load(object sender, EventArgs e)
        {
            byte caja=1;
            if (caja==1)
            {
                tsb_Contado.Enabled = true;
                tsb_Credito.Enabled = true;
                tsb_Express.Enabled = true;
            }
            else
            {
                tsb_Contado.Enabled = false;
                tsb_Credito.Enabled = false;
                tsb_Express.Enabled = false;
            }
        }

        private void tsb_Contado_Click(object sender, EventArgs e)
        {
            Frm_Contado_PL Contado = new Frm_Contado_PL();
            Contado.ShowDialog();
        }

        private void tsb_Cajas_Click(object sender, EventArgs e)
        {
            Frm_Cajas_PL Cajas = new Frm_Cajas_PL();
            Cajas.ShowDialog();
        }
    }
}
