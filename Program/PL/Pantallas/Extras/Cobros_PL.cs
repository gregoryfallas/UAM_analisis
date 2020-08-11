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
using DAL;
using BLL;

namespace PL.Pantallas.Extras
{
    public partial class Cobros_PL : Form
    {
        int EnviarFecha = 0;

        public Cobros_PL()
        {
            InitializeComponent();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {

        }

        private void Cobros_PL_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();

            Cargar2();

        }

        private void Cargar2()
        {

            try
            {

                this.dtg_Cobros.DataSource = null;
                this.dtg_Cobros.Refresh();
                string a = txt_Cliente.Text.Trim();
                this.dtg_Cobros.DataSource = Cls_Cobros_BLL.ConsultarCobros(a);
                this.dtg_Cobros.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cargar2();
        }

        private void CapturarFechaSistema()
        {
            txt_Fecha.Text = DateTime.Now.ToShortDateString();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (EnviarFecha)
            {
                case 0: CapturarFechaSistema(); break;
            }
        }
    }
}
