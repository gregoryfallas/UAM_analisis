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
using PL.Pantallas.Adicionales;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Servicios_PL : Form
    {

        List<SERVICIOS> ls = new List<SERVICIOS>();
        public static int idServicio;
        public static string Servicio;
        public static int cantidad;
        public static decimal precio;
        public static bool bandera = false;

        public Frm_Servicios_PL()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_Contado_PL contado = new Frm_Contado_PL();

            contado.CargarServicios();

            bandera = true;
            this.Hide();
        }

        private void Frm_Servicios_PL_Load(object sender, EventArgs e)
        {


            ls = Frm_Consulta_PL.listaServicios;
            Cargar();



        }


        private void Cargar()
        {
            try
            {

                this.dtg_Servicios.DataSource = null;
                this.dtg_Servicios.Refresh();
                this.dtg_Servicios.DataSource = ls;
                this.dtg_Servicios.Refresh();

            }
            catch (Exception)
            {

                throw;
            }




        }

        private void dtg_Servicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            idServicio = Convert.ToInt32(dtg_Servicios.SelectedRows[0].Cells[0].Value.ToString());
            Servicio = dtg_Servicios.SelectedRows[0].Cells[1].Value.ToString();
            cantidad = Convert.ToInt32(dtg_Servicios.SelectedRows[0].Cells[2].Value.ToString());
            precio = Convert.ToDecimal(dtg_Servicios.SelectedRows[0].Cells[3].Value.ToString());

        }
    }
}