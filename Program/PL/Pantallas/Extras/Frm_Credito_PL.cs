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
    public partial class Frm_Credito_PL : Form
    {
        public Frm_Credito_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre.Text==string.Empty)
            {
                cb_Credito.Enabled = false;
            }
            else
            {
                cb_Credito.Enabled = true;
            }
        }
    }
}
