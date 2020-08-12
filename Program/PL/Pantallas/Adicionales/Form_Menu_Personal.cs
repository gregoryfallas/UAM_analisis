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
    public partial class Form_Menu_Personal : Form
    {
        public Form_Menu_Personal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principales.Frm_Inicio_PL inicio = new Principales.Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void creaciónDePersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Creacion_Personal_PL personal = new Adicionales.Form_Creacion_Personal_PL();
            personal.ShowDialog();
        }

        private void creaciónDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Creacion_Usuarios usuario = new Adicionales.Form_Creacion_Usuarios();
            usuario.ShowDialog();
        }

        private void creaciónDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Creacion_Roles roles = new Adicionales.Form_Creacion_Roles();
            roles.ShowDialog();
        }

        private void consultaDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionales.Form_Consulta_Roles croles = new Adicionales.Form_Consulta_Roles();
            croles.ShowDialog();
        }
    }
}
