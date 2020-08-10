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
using BLL;
namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Control_Suministros_PL : Form
    {
        Articulos Articulos = new Articulos();
        
        public Frm_Control_Suministros_PL()
        {
            InitializeComponent();
        }

      
        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void dataGridV_controlsuministros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridV_controlsuministros = Articulos.ConsultarArticulos();
        }
    }
}
