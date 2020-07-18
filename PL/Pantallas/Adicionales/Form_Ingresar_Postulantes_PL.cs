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
    public partial class Form_Ingresar_Postulantes_PL : Form
    {
        public Form_Ingresar_Postulantes_PL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Menu_Reclutamiento atras = new Adicionales.Form_Menu_Reclutamiento();
            atras.ShowDialog();
        }
    }
}
