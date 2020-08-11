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
using BLL;
using DAL.Entidades;
namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Control_Suministros_PL : Form
    {
        public Frm_Control_Suministros_PL()
        {
            InitializeComponent();
            CARGAR_INVENTARIO_TOTAL();
            CARGAR_INVENTARIO_MENOR_CANTIDAD();
        }

        private void CARGAR_INVENTARIO_TOTAL()
        {
    
            try
            {
                this.dataGridV_controlsuministros.DataSource = null;
                this.dataGridV_controlsuministros.Refresh();
                
                this.dataGridV_controlsuministros.DataSource = Suministros_BLL.ConsultarInventarioArticulos();
                this.dataGridV_controlsuministros.Refresh();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CARGAR_INVENTARIO_MENOR_CANTIDAD()
        {
            try
            {
                this.dataGrid_controlmeosdediez.DataSource = null;
                this.dataGrid_controlmeosdediez.Refresh();

                this.dataGrid_controlmeosdediez.DataSource = Suministros_BLL.SP_CONSULTAR_INVENTARIO_MENOR_CANTIDAD();
                this.dataGrid_controlmeosdediez.Refresh();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CARGAR_INVENTARIO_MENOR_CANTIDAD();
            CARGAR_INVENTARIO_TOTAL();
          
        }
    }
}
