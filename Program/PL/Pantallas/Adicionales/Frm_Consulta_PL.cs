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

        public Frm_Consulta_PL()
        {
            InitializeComponent();
            cargarServicios();

        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
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
            List<SERVICIOS> ls = new List<SERVICIOS>();
            ls = Consulta_BLL.ConsultaServicios(nomServ);
            servicosFacturar(ls);
            

        }

        private void servicosFacturar(List<SERVICIOS> ls )
        {
            //ENVIAR LA LISTA CON LOS SERVICIOS

        }


        private void otrosServicioscbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomServ = otrosServicioscbo.Text;
            textBox2.Text = nomServ;
        }
    }
}
