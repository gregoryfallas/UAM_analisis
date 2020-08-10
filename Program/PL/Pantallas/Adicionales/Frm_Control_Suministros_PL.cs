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
            Cargar2();
        }

        private void Cargar2()
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

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void dataGridV_controlsuministros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridV_controlsuministros = 
          
        }

        private void dataGrid_controlmeosdediez_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGrid_controlmeosdediez = 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridV_controlsuministros =
          
        }
    }
}
