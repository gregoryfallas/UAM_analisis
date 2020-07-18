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
    public partial class Form_Vacaciones_PL : Form
    {
        public Form_Vacaciones_PL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principales.Frm_Inicio_PL inicio = new Principales.Frm_Inicio_PL();
            inicio.ShowDialog();
        }
    }
}
