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

        public static string Username = "hola";



        public static List<SERVICIOS> listaServicios=new List<SERVICIOS>();
        public static bool alertadeFacturacion = false;


        public Frm_Consulta_PL()
        {
            InitializeComponent();
            cargarServicios();

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





        private void btn_Recetas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Recetas_PL Recetas = new Frm_Recetas_PL();
            Recetas.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Recetas_PL Recetas = new Frm_Recetas_PL();
            Recetas.ShowDialog();
        }

        private void Frm_Consulta_PL_Load(object sender, EventArgs e)
        {

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
            ls = Consulta_BLL.ConsultaServicios(nomServ);




            foreach (SERVICIOS s in ls)
            {
                servicios.ID_Servicios = s.ID_Servicios;
                servicios.Nombre = s.Nombre;
                servicios.Descripcion = s.Descripcion;
                servicios.Precio = s.Precio;               
                retornaServicio(servicios);


            }


        }
        private void retornaServicio(SERVICIOS servicios)
        {

            listaServicios.Add(servicios);
    }




        private void otrosServicioscbo_SelectedIndexChanged(object sender, EventArgs e)
        {
             SERVICIOS s = new SERVICIOS();
            // s = otrosServicioscbo.SelectedItem;

            nomServ = otrosServicioscbo.Text;
            //textBox2.Text = nomServ;
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            alertadeFacturacion = true;
        }
    }
}





        






        

