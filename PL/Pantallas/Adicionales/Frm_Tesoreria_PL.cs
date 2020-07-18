using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Principales;
using PL.Pantallas.Extras;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Tesoreria_PL : Form
    {
        public Frm_Tesoreria_PL()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void tsb_Cobros_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Cuentas_Cobrar_PL Cobros = new Frm_Cuentas_Cobrar_PL();
            Cobros.ShowDialog();

        }

        

        private void tsb_Planilla_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Revision_Planilla_PL Planilla = new Frm_Revision_Planilla_PL();
            Planilla.ShowDialog();          
            
        }

        private void tsb_Ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Reporte_Ventas Ventas = new Frm_Reporte_Ventas();
            Ventas.ShowDialog();      

        }

        private void tsb_Compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Reporte_Compras_PL Compras = new Frm_Reporte_Compras_PL();
            Compras.ShowDialog();
          
        }

        
    }
}
