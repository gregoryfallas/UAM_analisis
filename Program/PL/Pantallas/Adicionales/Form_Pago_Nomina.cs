using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Pantallas.Adicionales
{
    public partial class Form_Pago_Nomina : Form
    {
        public Form_Pago_Nomina()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principales.Frm_Inicio_PL inicio = new Principales.Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void crearNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Crear_Nomina crear = new Adicionales.Form_Crear_Nomina();
            crear.ShowDialog();
        }

        private void buscarNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Buscar_Nomina buscar = new Adicionales.Form_Buscar_Nomina();
            buscar.ShowDialog();
        }

        private void ingresoDeMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Ingreso_Marcas_Manuales marcar = new Adicionales.Form_Ingreso_Marcas_Manuales();
            marcar.ShowDialog();
        }
    }
}
