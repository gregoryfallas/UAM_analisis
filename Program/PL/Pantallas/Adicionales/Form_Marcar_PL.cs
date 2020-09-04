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
    public partial class Form_Marcar_PL : Form
    {
        public List<TIPO_MARCA> lstresultado { get; set; }

        int EnviarFecha = 0;

        TIPO_MARCA p = new TIPO_MARCA();

        MARCAS m = new MARCAS();

        private string marca;

        public Form_Marcar_PL()
        {
            lstresultado = new List<TIPO_MARCA>();
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                m.ID_Personal = Convert.ToInt32(txtidpersonal.Text.Trim());
                m.Tipo = p.ID_Tipo;
                txthora.Text = DateTime.Now.ToString("hh:mm:ss");
                txtfecha.Text = DateTime.Now.ToShortDateString();
                m.Hora = TimeSpan.Parse(txthora.Text.Trim());
                m.Fecha = Convert.ToDateTime(txtfecha.Text.Trim());
               

                R_Humanos.AgregarMarcaTodos(m);
                MessageBox.Show("Marca agregada correctamente");
                txtidpersonal.Text = "";
                cboturno.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboturno_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (EnviarFecha)
            {
                case 0: CapturarFechaSistema(); break;
            }

        }

        private void CapturarFechaSistema()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form_Marcar_PL_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void cboturno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboturno.SelectedIndex == 0)
            {
                p.ID_Tipo = 1;
            }
            else
            {
                p.ID_Tipo = 2;
            }
        }
    }
}
