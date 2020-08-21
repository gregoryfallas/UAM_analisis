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

        private void crearReclutamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Crear_Reclutamiento agregar = new Adicionales.Form_Crear_Reclutamiento();
            agregar.ShowDialog();
        }

        private void ingresarParticipantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Ingresar_Participantes reclu = new Adicionales.Form_Ingresar_Participantes();
            reclu.ShowDialog();
        }

        private void ingresarPruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Ingresar_Pruebas pruebas = new Adicionales.Form_Ingresar_Pruebas();
            pruebas.ShowDialog();
        }

        private void consultarPruebasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Consultar_Pruebas_Participantes consultar = new Adicionales.Form_Consultar_Pruebas_Participantes();
            consultar.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
