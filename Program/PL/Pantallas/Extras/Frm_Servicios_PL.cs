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
using PL.Pantallas.Extras;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Servicios_PL : Form
    {
        ARTICULOS obj_Estados_DAL= new ARTICULOS();


        public Frm_Servicios_PL()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {

            Pantallas.Extras.Frm_Contado_PL Mod = new  Pantallas.Extras.Frm_Contado_PL();

            if (dtg_Articulos.Rows.Count>0)
            {
                obj_Estados_DAL.Precio = Convert.ToDecimal(dtg_Articulos.SelectedRows[0].Cells[3].Value.ToString());

            }

            Mod.txt_Precio.Text = (obj_Estados_DAL.Precio.ToString());
            this.Hide();

        }

        private void Frm_Servicios_PL_Load(object sender, EventArgs e)
        {
            Cargar2();
        }

        


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

        private void dtg_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

      
    }
}
