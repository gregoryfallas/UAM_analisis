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
using PL.Pantallas.Adicionales;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Recetas_PL : Form
    {
        public Frm_Recetas_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Hide();
        }
    }
}
