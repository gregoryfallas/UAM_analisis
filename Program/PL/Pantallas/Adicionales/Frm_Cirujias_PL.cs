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
using DAL.Entidades;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Cirujias_PL : Form
    {
        List<SERVICIOS> listita = new List<SERVICIOS>();


        public string mensajee;

        public Frm_Cirujias_PL()
        {
            InitializeComponent();
       
        }
        

        private void agregaMensajito() {

               // frm.ShowDialog();
            }
        

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {


        }

        private void Frm_Cirujias_PL_Load(object sender, EventArgs e)
        {
            //string _UserName = Frm_Consulta_PL.Username;
            //textBox1.Text = _UserName;

            //List<SERVICIOS> ls = new List<SERVICIOS>();

              listita = Frm_Consulta_PL.listaServicios;
             cargarGrid();
        }





        private void cargarGrid() {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();
          //  string a = txt_Nombre.Text.Trim();
            this.dataGridView1.DataSource = listita;
            this.dataGridView1.Refresh();


        }

        private void EliminarCirujíabtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
