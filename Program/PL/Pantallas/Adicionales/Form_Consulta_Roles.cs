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
    public partial class Form_Consulta_Roles : Form
    {
        public Form_Consulta_Roles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Menu_Personal atras = new Adicionales.Form_Menu_Personal();
            atras.ShowDialog();
        }
    }
}
