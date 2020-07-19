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

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Servicio_Domicilio_PL : Form
    {
        public Frm_Servicio_Domicilio_PL()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
           PL.Pantallas.Adicionales.Frm_Clientes_PL cli = new Frm_Clientes_PL();
            cli.ShowDialog();
        }
    }
}
