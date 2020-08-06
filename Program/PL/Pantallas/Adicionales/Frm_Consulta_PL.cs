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
    public partial class Frm_Consulta_PL : Form
    {
        public Frm_Consulta_PL()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void btn_Recetas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Recetas_PL Recetas = new Frm_Recetas_PL();
            Recetas.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Recetas_PL Recetas = new Frm_Recetas_PL();
            Recetas.ShowDialog();
        }

        private void Frm_Consulta_PL_Load(object sender, EventArgs e)
        {

        }
    }
}
