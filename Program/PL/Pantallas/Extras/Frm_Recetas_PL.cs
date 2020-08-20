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
using PL.Pantallas.Adicionales;
using DAL.Entidades;
using BLL;
namespace PL.Pantallas.Extras
{
    public partial class Frm_Recetas_PL : Form
    {
        public Frm_Recetas_PL()
        {
            InitializeComponent();
        }



        private void cargarMedicamentos()
        {

            List<ARTICULOS> lstresultado = Consulta_BLL.consultarArticulosMedicos();
            comboBox1.DataSource = lstresultado;
            comboBox1.ValueMember = "ID_Articulos";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Refresh();
        }








        private void btn_inicio_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            this.Hide();
        }

        private void AgregarReceta_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Recetas_PL_Load(object sender, EventArgs e)
        {
            cargarMedicamentos();
        }
    }
}
