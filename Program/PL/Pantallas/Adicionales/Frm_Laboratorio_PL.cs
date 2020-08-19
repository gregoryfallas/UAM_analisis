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
using BLL;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Laboratorio_PL : Form
    {

        List<SERVICIOS> listita = new List<SERVICIOS>();
        private int idEstado;
        private int idServicio;
        private int idPrueba;

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
            bandera = false;

            listita.Clear();

            this.Hide();
        }

        private void servicioAExamen() {

            switch (idServicio)
            {
                case 13:
                    idPrueba = 1;
                    break;
                case 14:
                    idPrueba = 2;
                    break;
                case 15:
                    idPrueba = 3;
                    break;
                case 16:
                    idPrueba = 4;
                    break;
                case 17:
                    idPrueba = 5;
                    break;
                case 18:
                    idPrueba = 6;
                    break;
                



                default:
                    break;
            }


        }




        private void enviarbtn_Click(object sender, EventArgs e)
        {
            int ee=0;
            //         bandera = false;
            //           listita.Clear();
            citaEnCurso(); 
            listita.RemoveAll(x => x.Nombre==textBox1.Text);
            this.cargarGrid();


            if (idEstado == 0)
                ee = 23;
            if (idEstado == 1)
                ee = 24;
            else if(idEstado == 2)
                ee = 25;

            servicioAExamen();



            Laboratorio_BLL.agregarResultadoLaboratorio(idPrueba,cita,textBox2.Text,ee);
            

            MessageBox.Show("Resultados de las pruebas agregadas", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            CargarCombosEstadosExamenes();
            
            //bandera=false;
        }


        private void CargarCombosEstadosExamenes()
        {
            List<ESTADOS> lstresultado =Laboratorio_BLL.ConsultaEstadosExamenes();

            this.comboBox1.DataSource = lstresultado;
            comboBox1.ValueMember = "ID_Estados";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Refresh();
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
            idServicio= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEstado = comboBox1.SelectedIndex;

            //textBox1.Text = comboBox1.SelectedIndex.ToString();
        }
    }
}
