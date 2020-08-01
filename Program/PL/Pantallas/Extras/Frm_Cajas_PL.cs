using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Cajas_PL : Form
    {
        public Frm_Cajas_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caja abierta con Exito ","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            byte caja = 1;
        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Caja cerrada con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            byte caja = 2;
        }
    }
}
