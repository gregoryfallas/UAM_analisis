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
using BLL;
namespace PL.Pantallas.Adicionales
{
    
    public partial class Frm_Preconsulta_PL : Form
    {


        private int idMascota = 0;


        public Frm_Preconsulta_PL()
        {
            InitializeComponent();
            cargarCitaEnCurso();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }


        private void cargarCitaEnCurso() {

            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();

            this.dataGridView1.DataSource = PreConsulta_BLL.consultarCitaEnCursoPantalla();
            
            this.dataGridView1.Refresh();

        }


        private void AgregarMascota_Click(object sender, EventArgs e)
        {
            this.Hide();
            PL.Pantallas.Adicionales.Frm_Animal_PL mascota = new Frm_Animal_PL();
            mascota.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarRecetabtn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            idMascota=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            nombretxt.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
    }
}
