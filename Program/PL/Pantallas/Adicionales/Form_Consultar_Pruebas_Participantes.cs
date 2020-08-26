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

namespace PL.Pantallas.Adicionales
{
    public partial class Form_Consultar_Pruebas_Participantes : Form
    {
        public Form_Consultar_Pruebas_Participantes()
        {
            InitializeComponent();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<PRUEBAS_PARTICIPANTES> lstresultados = R_Humanos.ObtenerPruebasParticipantes();

                this.dgvpruebas.DataSource = lstresultados;
                this.dgvpruebas.Refresh();
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
