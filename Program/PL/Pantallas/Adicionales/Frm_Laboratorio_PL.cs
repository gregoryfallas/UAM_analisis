using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entidades;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Laboratorio_PL : Form
    {

        List<SERVICIOS> listita = new List<SERVICIOS>();
        public bool bandera=false;
        public int cita ;


        public Frm_Laboratorio_PL()
        {
            InitializeComponent();
        }



        private void cargarGrid()
        {

            if (verificarSolicitudDeLAB())
               
                this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();
            //  string a = txt_Nombre.Text.Trim();
            this.dataGridView1.DataSource = listita;
            this.dataGridView1.Refresh();


        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void enviarbtn_Click(object sender, EventArgs e)
        {
            bandera = false;
            listita.Clear();
        }

        private bool verificarSolicitudDeLAB(){
                bandera = Frm_Consulta_PL.alertadeExamen;
            return bandera;

        }


        private void citaEnCurso() {
            cita = Frm_Consulta_PL.idCita;

        }


        private void Frm_Laboratorio_PL_Load(object sender, EventArgs e)
        {
            listita = Frm_Consulta_PL.listaServicios;
            citaEnCurso();
            cargarGrid();
            
            //bandera=false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            citaEnCurso();
            cargarGrid();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
    }
}
