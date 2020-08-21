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
using BLL;
using DAL.Entidades;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Cirujias_PL : Form
    {
        List<SERVICIOS> listita = new List<SERVICIOS>();


        public static bool alertadeFacturacion = false;

        public static int idCita = 0;
        private string nomServ;
        private int idEstado;
        private int cita;
        public bool bandera = false;
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



        private void CargarObservacionesPreConsulta()
        {
            List<OBSERVACIONES> lo = new List<OBSERVACIONES>();
            lo = Consulta_BLL.consultarObservaciones();
            OBSERVACIONES observaciones = new OBSERVACIONES();
            foreach (OBSERVACIONES o in lo)
            {

                observaciones.ID_Cita = o.ID_Cita;
                observaciones.Descripcion = o.Descripcion;
                textBox5.Text = observaciones.Descripcion;
                idCita = observaciones.ID_Cita;
                textBox1.Text = idCita.ToString();
            }
            
        }
        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {


            listita.RemoveAll(x => x.Nombre == textBox1.Text);
            alertadeFacturacion = true;
            //Agregar observaciones a la cita 
            OBSERVACIONES observaciones = new OBSERVACIONES();
            observaciones.ID_Cita = idCita;
            observaciones.Descripcion = textBox2.Text;
            PreConsulta_BLL.agregarObservaciones(observaciones);
            MessageBox.Show("Datos Agregados agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //limpiar lista de examenes
            listita.Clear();

        }

        private void citaEnCurso()
        {

            cita = Frm_Consulta_PL.idCita;

        }


        private bool verificarSolicitudDeLAB()
        {
            bandera = Frm_Consulta_PL.alertadeCirujia;
            return bandera;

        }

        private void Frm_Cirujias_PL_Load(object sender, EventArgs e)
        {

            // listita = Frm_Consulta_PL.listaServicios;
             listita = Frm_Consulta_PL.listaCirugia;
            citaEnCurso();
            CargarObservacionesPreConsulta();
            cargarGrid();



          
          
            
          

        }





        private void cargarGrid() {

            if(verificarSolicitudDeLAB())
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

       

        private void retornaServicio(SERVICIOS servicios)
        {

            listita.Add(servicios);
        }



        


        private void button1_Click_1(object sender, EventArgs e)
        {

            SERVICIOS servicios = new SERVICIOS();
            List<SERVICIOS> srv = new List<SERVICIOS>(Consulta_BLL.ConsultaServicios(nomServ));
            

            foreach (SERVICIOS s in srv)
            {

                servicios.ID_Servicios = s.ID_Servicios;
                servicios.Nombre = s.Nombre;
                servicios.Descripcion = s.Descripcion;
                servicios.Precio = s.Precio;
                retornaServicio(servicios);



            }

            MessageBox.Show("Servicio Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            


}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
