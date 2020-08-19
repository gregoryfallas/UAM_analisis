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
using PL.Pantallas.Extras;
using DAL.Entidades;
using BLL;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Consulta_PL : Form
    {

        private string nomServ;
        private string nomExamen;

        public static List<SERVICIOS> listaExamenes = new List<SERVICIOS>();
        
        public static List<SERVICIOS> listaServicios=new List<SERVICIOS>();
        public static int idCita=0;
        
        public static bool alertadeFacturacion = false;
        public static bool alertadeExamen = false;
        private bool confirmarcionExamen;




        // SERVICIOS servicios = new SERVICIOS();



        public Frm_Consulta_PL()
        {
            InitializeComponent();
           // cargarServicios();


        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {



            this.Hide();
        }



        private void cargarServicios() {

            List<SERVICIOS> lstresultado = Consulta_BLL.ConsultaServicios_IDNOMBRE();
            otrosServicioscbo.DataSource = lstresultado;
            otrosServicioscbo.ValueMember = "ID_Servicios";
            otrosServicioscbo.DisplayMember = "Nombre";
            otrosServicioscbo.Refresh();
        }

        private void cargarVacunas()
        {

            List<SERVICIOS> lstresultado = Consulta_BLL.ConsultaServiciosVacunacion_IDNOMBRE();
            comboBox2.DataSource = lstresultado;
            comboBox2.ValueMember = "ID_Servicios";
            comboBox2.DisplayMember = "Nombre";
            comboBox2.Refresh();
        }

        private void cargarCirujías()
        {

            List<SERVICIOS> lstresultado = Consulta_BLL.ConsultaServiciosCirujia_IDNOMBRE();
            comboBox3.DataSource = lstresultado;
            comboBox3.ValueMember = "ID_Servicios";
            comboBox3.DisplayMember = "Nombre";
            comboBox3.Refresh();
        }

        private void cargarExamenes()
        {

            List<SERVICIOS> lstresultado = Consulta_BLL.ConsultaServiciosExamenes_IDNOMBRE();
            comboBox1.DataSource = lstresultado;
            comboBox1.ValueMember = "ID_Servicios";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Refresh();
        }


        

        private void btn_Recetas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Recetas_PL Recetas = new Frm_Recetas_PL();
            Recetas.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Frm_Recetas_PL Recetas = new Frm_Recetas_PL();
            Recetas.ShowDialog();
        }

        private void Frm_Consulta_PL_Load(object sender, EventArgs e)
        {
            cargarServicios();
            cargarExamenes();
            cargarVacunas();
            cargarCirujías();
            CargarObservacionesPreConsulta();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {




        }

        private void AgregarOtroServiciosbtn_Click(object sender, EventArgs e)
        {
            SERVICIOS servicios = new SERVICIOS();
              List<SERVICIOS> ls = new List<SERVICIOS>();
            List<SERVICIOS> srv = new List<SERVICIOS>(Consulta_BLL.ConsultaServicios(nomServ));
            // srv= Consulta_BLL.ConsultaServicios(nomServ);
            // miLista = Consulta_BLL.ConsultaServicios(nomServ);
            

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






        private void retornaServicio(SERVICIOS s) {
            //ENVIAR LA LISTA CON LOS SERVICIOS
            listaServicios.Add(s);
          }

        


        private void otrosServicioscbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SERVICIOS s = new SERVICIOS();
            nomServ = otrosServicioscbo.Text;
         //   textBox2.Text = nomServ;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            //alertar que hay una lista de servicios
            alertadeFacturacion = true;
            //limpiar lista de examenes
            listaExamenes.Clear();
            
        }


        private void CargarObservacionesPreConsulta() {
            List<OBSERVACIONES> lo = new List<OBSERVACIONES>();
            lo = Consulta_BLL.consultarObservaciones();
            OBSERVACIONES observaciones = new OBSERVACIONES();
            foreach (OBSERVACIONES o in lo)
            {

                observaciones.ID_Cita = o.ID_Cita;
                observaciones.Descripcion = o.Descripcion;
                Observaciones.Text = observaciones.Descripcion;
                idCita = observaciones.ID_Cita;
                textBox2.Text = idCita.ToString();
            }




        }


        private void button2_Click(object sender, EventArgs e)
        {
             SERVICIOS servicios = new SERVICIOS();
            //  List<SERVICIOS> ls = new List<SERVICIOS>();
            List<SERVICIOS> srv = new List<SERVICIOS>(Consulta_BLL.ConsultaServicios(nomServ));
            // srv= Consulta_BLL.ConsultaServicios(nomServ);
            // miLista = Consulta_BLL.ConsultaServicios(nomServ);


            foreach (SERVICIOS s in srv)
            {

                servicios.ID_Servicios = s.ID_Servicios;
                servicios.Nombre = s.Nombre;
                servicios.Descripcion = s.Descripcion;
                servicios.Precio = s.Precio;
                retornaServicio(servicios);



            }

            MessageBox.Show("Vacuna Agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        //vacunas
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SERVICIOS s = new SERVICIOS();
            nomServ = comboBox2.Text;
            //textBox2.Text = nomServ;
        }
        

        //agregar examen
        private void agregarExamenesbtn_Click(object sender, EventArgs e)
        {
            SERVICIOS servicios = new SERVICIOS();
            //  List<SERVICIOS> ls = new List<SERVICIOS>();
            List<SERVICIOS> srv = new List<SERVICIOS>(Consulta_BLL.ConsultaServicios(nomExamen));
            //enviar a area de examenes
            listaExamenes = srv;
            // srv= Consulta_BLL.ConsultaServicios(nomServ);
            // miLista = Consulta_BLL.ConsultaServicios(nomServ);
            
            foreach (SERVICIOS s in srv)
            {

                servicios.ID_Servicios = s.ID_Servicios;
                servicios.Nombre = s.Nombre;
                servicios.Descripcion = s.Descripcion;
                servicios.Precio = s.Precio;
                retornaServicio(servicios);



            }


            //mandar el id o nombre de la prueba

            MessageBox.Show("Examen  Agregado y Solicitado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            alertadeExamen = true;


        }
        //examenes
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomExamen = comboBox1.Text;


        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomServ = comboBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SERVICIOS servicios = new SERVICIOS();
            //  List<SERVICIOS> ls = new List<SERVICIOS>();
            List<SERVICIOS> srv = new List<SERVICIOS>(Consulta_BLL.ConsultaServicios(nomServ));
            // srv= Consulta_BLL.ConsultaServicios(nomServ);
            // miLista = Consulta_BLL.ConsultaServicios(nomServ);


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
    }
}
