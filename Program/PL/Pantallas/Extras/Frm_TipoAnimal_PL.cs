using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace PL.Pantallas.Extras
{
    public partial class Frm_TipoAnimal_PL : Form
    {
        public Frm_TipoAnimal_PL()
        {
            InitializeComponent();
        }


        private void cargarResultados() {


        }





        private void AgregarTipobtn_Click(object sender, EventArgs e)
        {

        }



        private void cargarGriExameness()
        {

            try
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Refresh();
                this.dataGridView1.DataSource = Consulta_BLL.ConsultarExamenPorCIta();
                this.dataGridView1.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_TipoAnimal_PL_Load(object sender, EventArgs e)
        {
            cargarGriExameness();
        }
    }
}
