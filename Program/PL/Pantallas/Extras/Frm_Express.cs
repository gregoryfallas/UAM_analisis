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
using BLL;

namespace PL.Pantallas.Extras
{
    public partial class Frm_Express : Form
    {


        private int estado;

        public Frm_Express()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Express_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_Estado.Text = cmb_Estado.SelectedIndex.ToString();
            estado = cmb_Estado.SelectedIndex+1;
            Cargar();

        }


        private void Cargar()
        {


            try
            {

                this.dtg_Express.DataSource = null;
                this.dtg_Express.Refresh();
                int a = estado;
                this.dtg_Express.DataSource = Express_BLL.ConsultarExpress(a);
                this.dtg_Express.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtg_Express_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Nombre.Text= dtg_Express.CurrentRow.Cells[5].Value.ToString() + " " + dtg_Express.CurrentRow.Cells[6].Value.ToString() + " " + dtg_Express.CurrentRow.Cells[7].Value.ToString();
            txt_Factura.Text = dtg_Express.CurrentRow.Cells[1].Value.ToString();
           txt_Estado.Text= dtg_Express.CurrentRow.Cells[3].Value.ToString();
            txt_Fecha_Doc.Text= dtg_Express.CurrentRow.Cells[4].Value.ToString();


        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cambiar el estado del envío?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SERVICIOS_EXPRESS express = new SERVICIOS_EXPRESS();

                express.ID_Factura = Convert.ToInt32(txt_Factura.Text);
                if (cmb_envio.SelectedIndex==1)
                {
                    express.Estado = 2;
                }
                else if (cmb_envio.SelectedIndex == 2)
                {
                    express.Estado = 3;
                }
                else if (cmb_envio.SelectedIndex == 3)
                {
                    express.Estado = 4;
                }
                else if (cmb_envio.SelectedIndex == 0)
                {
                    express.Estado = 1;
                }


                Express_BLL.ModificarEstadosExpress(express);                

                MessageBox.Show("Cambio realizado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txt_Estado.Text = "";
            txt_Factura.Text = "";
            txt_Fecha_Doc.Text = "";
            txt_Nombre.Text = "";
            dtg_Express.DataSource = null;
            cmb_envio.DataSource = null;


        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cargar();
        }
    }
}
