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
using DAL.Entidades;
using DAL;
using System.Data.SqlClient;

namespace PL.Pantallas.Adicionales
{
    public partial class Form_Buscar_Nomina : Form
    {
        public Form_Buscar_Nomina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Pago_Nomina atras = new Adicionales.Form_Pago_Nomina();
            atras.ShowDialog();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<NOMINA> lstresultados = R_Humanos.Obtener_Nomina();

                this.dgvnomina.DataSource = lstresultados;
                this.dgvnomina.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
