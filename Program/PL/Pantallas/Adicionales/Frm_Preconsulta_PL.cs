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
    public partial class Frm_Preconsulta_PL : Form
    {
        public Frm_Preconsulta_PL()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void AgregarMascota_Click(object sender, EventArgs e)
        {
            this.Hide();
            PL.Pantallas.Adicionales.Frm_Animal_PL mascota = new Frm_Animal_PL();
            mascota.ShowDialog();
        }


    }
}
