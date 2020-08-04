using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Adicionales;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Reporte_Ventas : Form
    {
        public Frm_Reporte_Ventas()
        {
            InitializeComponent();
        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
