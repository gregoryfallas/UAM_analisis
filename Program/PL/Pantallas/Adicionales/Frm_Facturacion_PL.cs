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
using DAL.Entidades;
using DAL;
using BLL;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Facturacion_PL : Form
    {
        DA Obj_Dal = new DA();
        CAJAS caja = new CAJAS();
        Articulos_BLL Obj_BLL = new Articulos_BLL();

       

        public Frm_Facturacion_PL()
        {
            InitializeComponent();
            
        }

     

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
          
        }
            
       
        private void Frm_Facturacion_PL_Load(object sender, EventArgs e)
        {


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

        private void tsb_Credito_Click(object sender, EventArgs e)
        {
            Frm_Credito_PL Credito = new Frm_Credito_PL();
            Credito.ShowDialog();
        }
    }
}
