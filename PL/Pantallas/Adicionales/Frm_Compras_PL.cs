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
    public partial class Frm_Compras_PL : Form
    {
        public Frm_Compras_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
           
           
            if (MessageBox.Show("¿Desea registrar la compra?", "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show ("Registro Realizado con Exito","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea editar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }

        private void btn_Agre_Art_Click(object sender, EventArgs e)
        {

        }
    }
}
