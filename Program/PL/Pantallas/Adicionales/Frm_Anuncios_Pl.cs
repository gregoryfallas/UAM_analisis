using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL.Entidades;
using PL.Pantallas.Principales;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Anuncios_Pl : Form
    {
        public Frm_Anuncios_Pl()
        {
            ANUNCIOS anuncios = new ANUNCIOS();
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            // textBox_id // dataGridView_anuncios
            if (textBox_id.Text != "")
            {
                dataGridView_anuncios.DataSource = Anuncios_BLL.consultar_anuncios(Convert.ToInt32(textBox_id.Text)).Copy();
            }
            else
            {
                dataGridView_anuncios.DataSource = Anuncios_BLL.consultar_anuncios().Copy();
            }
        }
    }
}
