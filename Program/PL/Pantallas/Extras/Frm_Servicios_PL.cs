using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Adicionales;
using BLL;
using DAL.Entidades;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Servicios_PL : Form
    {
        public Frm_Servicios_PL()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
           
        }

        private void Frm_Servicios_PL_Load(object sender, EventArgs e)
        {
            Cargar2();
        }

        private void Cargar()
        {
            Articulos articulos = new Articulos();

           
            List<ARTICULOS> LS = Articulos.ConsultarArticulos(tsb_Buscar.Text.Trim());

            dtg_Articulos.DataSource = null;
            dtg_Articulos.Refresh();
            dtg_Articulos.DataSource = LS;
            dtg_Articulos.Refresh();


         
        }


        private void Cargar2()
        {
           

            try
            {

                this.dtg_Articulos.DataSource = null;
                this.dtg_Articulos.Refresh();
                string a = buscaArticulostxt.Text.Trim();


                this.dtg_Articulos.DataSource = Articulos.ConsultarInventarioArticulos(a);
                this.dtg_Articulos.Refresh();
                
            }
            catch (Exception)
            {

                throw;
            }



        }



        private void tsb_Buscar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void tsb_Codigo_Click(object sender, EventArgs e)
        {

        }

        private void buscar_btn_Click(object sender, EventArgs e)
        {
            Cargar2();
        }
    }
}
