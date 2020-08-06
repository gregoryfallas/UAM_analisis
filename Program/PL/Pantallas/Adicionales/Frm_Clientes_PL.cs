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

        private int estado = 0;
        private int provincia_id = 0;
        private int canton_id = 0;
        private int distrito_id = 0;



        public Frm_Clientes_PL()
        {
            InitializeComponent();
            
           
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

        private void cargarGridUsuarios()
        {
            Clientes_BLL c = new Clientes_BLL();
            try
            {
              
                

                List<CLIENTES> lstusuarios = Clientes_BLL.ConsultarClientesPantallaCliente(this.textBox6.Text.Trim());


                DataTable dt = new DataTable();


                dt.Columns.Add("ID");
                dt.Columns.Add("Cedula");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Primer_Apellido");
                dt.Columns.Add("Segundo_Apellido");
                dt.Columns.Add("Correo");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("Id Provincia");
                dt.Columns.Add("Id Canton");
                dt.Columns.Add("Id Distrito");
                dt.Columns.Add("Direccion");
                dt.Columns.Add("Credito");
                dt.Columns.Add("Estado");
                foreach (CLIENTES item in lstusuarios)
                {
                    dt.Rows.Add
                        (
                        item.ID_Cliente,
                        item.Cedula,
                        item.Nombre,
                        item.Apellido_1,
                        item.Apellido_2,
                        item.Correo,
                        item.Telefono,
                        item.ID_Provincias,
                        item.ID_Cantones,
                        item.ID_Distritos,
                        item.Direccion,
                        item.Credito,
                        item.Estado
                        );
                }


                this.dataGridView1.DataSource = null;
                this.dataGridView1.Refresh();
                this.dataGridView1.DataSource = dt;
                this.dataGridView1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }


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
            cargarGridUsuarios();
        }

        private void Provinciacbo_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.provincia_id = Convert.ToInt32(Provinciacbo.SelectedIndex)+1;
            CargarCombosCantones();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cantoncbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.canton_id  = Convert.ToInt32(Cantoncbo.SelectedIndex) + 1;
            CargarCombosDistritos();
        }

        private void estadoClientecbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            estado = Convert.ToInt32(this.estadoClientecbo.SelectedIndex) ;
        }

        private void Frm_Clientes_PL_Load(object sender, EventArgs e)
        {
            CargarCombosEstados();
            CargarCombosProvincias();
            cargarGridUsuarios();


        }
    }
}
