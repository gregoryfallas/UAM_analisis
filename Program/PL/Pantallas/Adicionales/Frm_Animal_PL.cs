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
    public partial class Frm_Animal_PL : Form
    {
        public Frm_Animal_PL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void mascotalbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            PL.Pantallas.Adicionales.Frm_Clientes_PL clientes = new Frm_Clientes_PL ();
            clientes.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CedulaClienteBusquedabtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarTipoMascotabtn_Click(object sender, EventArgs e)
        {
            PL.Pantallas.Extras.Frm_TipoAnimal_PL ta = new Frm_TipoAnimal_PL();
            ta.ShowDialog();
        }
    }
}
