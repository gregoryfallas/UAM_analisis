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
    public partial class Frm_Clientes_PL : Form
    {

        private int provincia_id = 0;
        private int canton_id = 0;


        public Frm_Clientes_PL()
        {
            InitializeComponent();
            CargarCombosEstados();
             CargarCombosProvincias();
           
        }


        private void CargarCombosEstados()
        {
            List<ESTADOS> lstresultado = Clientes_BLL.ConsultaEstadosCliente();

            this.estadoClientecbo.DataSource = lstresultado;
            estadoClientecbo.ValueMember = "ID_Estados";
            estadoClientecbo.DisplayMember = "Nombre";
            estadoClientecbo.Refresh();
        }

        private void CargarCombosProvincias()
        {
           
            List<PROVINCIAS> lstresultado = Clientes_BLL.ConsultaProvincia();
            
            this.Provinciacbo.DataSource = lstresultado;
            Provinciacbo.ValueMember = "ID_Provincias";
            Provinciacbo.DisplayMember = "Nombre";
            Provinciacbo.Refresh();

            CargarCombosCantones();
         

        }

        private void CargarCombosCantones()
        {
            
            List<CANTONES> lstresultado = Clientes_BLL.ConsultaCantones(provincia_id);
            this.Cantoncbo.DataSource = lstresultado;
            Cantoncbo.ValueMember = "ID_Cantones";
            Cantoncbo.DisplayMember = "Nombre";
            Cantoncbo.Refresh();
            CargarCombosDistritos();
        }


        private void CargarCombosDistritos()
        {

            List<DISTRITOS> lstresultado = Clientes_BLL.ConsultaDistritos(canton_id);
            this.Distritocbo.DataSource = lstresultado;
            Distritocbo.ValueMember = "ID_Distritos";
            Distritocbo.DisplayMember = "Nombre";
            Distritocbo.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarClientebtn_Click(object sender, EventArgs e)
        {

        }

        private void Provinciacbo_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.provincia_id = Convert.ToInt32(Provinciacbo.SelectedIndex)+1;
           // textBox5.Text = provincia_id.ToString();

            CargarCombosCantones();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cantoncbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.canton_id  = Convert.ToInt32(Cantoncbo.SelectedIndex) + 1;
          //  textBox4.Text = canton_id.ToString();

            CargarCombosDistritos();
        }
    }
}
