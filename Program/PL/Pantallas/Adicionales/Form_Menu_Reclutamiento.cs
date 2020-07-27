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
    public partial class Form_Menu_Reclutamiento : Form
    {
        public Form_Menu_Reclutamiento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principales.Frm_Inicio_PL inicio = new Principales.Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Agregar_Nueva_Vacante_PL agregar = new Adicionales.Form_Agregar_Nueva_Vacante_PL();
            agregar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Ingresar_Postulantes_PL reclu = new Adicionales.Form_Ingresar_Postulantes_PL();
            reclu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Consultar_Postulantes consultar = new Adicionales.Form_Consultar_Postulantes();
            consultar.ShowDialog();
        }
    }
}
