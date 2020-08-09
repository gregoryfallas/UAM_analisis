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
using PL.Pantallas.Extras;
using DAL.Entidades;
using BLL;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Animal_PL : Form
    {
        public Frm_Animal_PL()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            List<TIPO_ANIMAL> lstresultado = Mascota_BLL.ConsultaTipoAnimal();
        
            this.comboBox1.DataSource = lstresultado;
            comboBox1.ValueMember = "ID_Tipo_Animal";
            comboBox1.DisplayMember = "Tipo";
            comboBox1.Refresh();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }

        private void mascotalbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
            PL.Pantallas.Adicionales.Frm_Clientes_PL clientes = new Frm_Clientes_PL ();
            clientes.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CedulaClienteBusquedabtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarTipoMascotabtn_Click(object sender, EventArgs e)
        {
            PL.Pantallas.Extras.Frm_TipoAnimal_PL ta = new Frm_TipoAnimal_PL();
            ta.ShowDialog();
        }

        private void buscarAnimalbtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscarClientebtn_Click(object sender, EventArgs e)
        {
            Clientes_BLL c = new Clientes_BLL();
            try
            {



                List<CLIENTES> lstusuarios = Clientes_BLL.ConsultarClientesPantallaCliente(this.CedulaClienteBusquedabtn.Text.Trim());


                DataTable dt = new DataTable();


                dt.Columns.Add("ID");
                dt.Columns.Add("Cedula");
                dt.Columns.Add("Nombre");
                foreach (CLIENTES item in lstusuarios)
                {
                    dt.Rows.Add
                        (
                        item.ID_Cliente,
                        item.Cedula,
                        item.Nombre
                        
                        );
                }


                this.dataGridView2.DataSource = null;
                this.dataGridView2.Refresh();
                this.dataGridView2.DataSource = dt;
                this.dataGridView2.Refresh();
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            razaAnimaltxt.Text= dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text= dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();

        }
    }
}
