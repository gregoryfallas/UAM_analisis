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
using DAL;

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

        //private void CargarDatos()
        //{
        //    Articulos_BLL Productos = new Articulos_BLL();

        //    List<ARTICULOS> LS = Articulos_BLL.ConsultarArticulos(txt_Codigo.Text.Trim());

        //    DataTable dt = new DataTable();

        //    dt.Columns.Add("ID_Articulo");
        //    dt.Columns.Add("Nombre");
        //    dt.Columns.Add("Descripcion");
        //    dt.Columns.Add("Precio");

        //    foreach (ARTICULOS item in LS)
        //    {
        //        dt.Rows.Add
        //            (
        //            item.ID_Articulos,
        //            item.Nombre,
        //            item.Descripcion,
        //            item.Precio
        //            );
        //    }

        //    dtg_Articulos.DataSource = null;
        //    dtg_Articulos.Refresh();
        //    dtg_Articulos.DataSource = dt;
        //    dtg_Articulos.Refresh();

        //}



        private void Cargar2()
        {
                                 
            try
            {
                
                this.dtg_Articulos.DataSource = null;
                this.dtg_Articulos.Refresh();
                string a = txt_Nombre.Text.Trim();                           
                this.dtg_Articulos.DataSource = Articulos_BLL.ConsultarInventarioArticulos(a);
                this.dtg_Articulos.Refresh();

            }
            catch (Exception)
            {
                               
                throw;
            }
                       


        }
                          


        private void tsb_Buscar_Click(object sender, EventArgs e)
        {
            Cargar2();
        }
    }
}
