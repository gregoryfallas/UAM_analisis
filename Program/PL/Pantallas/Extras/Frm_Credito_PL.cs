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

namespace PL.Pantallas.Extras
{
    public partial class Frm_Credito_PL : Form
    {

        CLIENTES clientes = new CLIENTES();
        DA Obj_Dal = new DA();
        string nombre;
        string cedula;
        string correo;
        string telefono;

        public Frm_Credito_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre.Text == string.Empty)
            {
                cb_Credito.Enabled = false;
            }
            else
            {
                cb_Credito.Enabled = true;
            }
        }
               

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cargar();

            txt_Cedula.Text = string.Empty;
            txt_Nombre.Text = string.Empty;
            txt_Correo.Text = string.Empty;
            txt_Telefono.Text = string.Empty;
            cb_Deshabilitar.Checked = false;
        }

        private void Cargar()
        {
            

            List<CLIENTES> LS = Factura_BLL.ConsultarClientesFactura(txt_Cliente.Text.Trim());

            DataTable dt = new DataTable();

            dt.Columns.Add("Cedula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Primer_Apellido");
            dt.Columns.Add("Segundo_Apellido");
            dt.Columns.Add("Correo");
            dt.Columns.Add("Teléfono");
            dt.Columns.Add("Credito");



            foreach (CLIENTES item in LS)
            {
                dt.Rows.Add
                    (
                    item.Cedula,
                    item.Nombre,
                    item.Apellido_1,
                    item.Apellido_2,
                    item.Correo,
                    item.Telefono,
                    item.Credito             
                    );
            }

            dtg_Clientes.DataSource = null;
            dtg_Clientes.Refresh();
            dtg_Clientes.DataSource = dt;
            dtg_Clientes.Refresh();

        }
        

        private void Frm_Credito_PL_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }

        private void dtg_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre = dtg_Clientes.CurrentRow.Cells[1].Value.ToString() + " " + dtg_Clientes.CurrentRow.Cells[2].Value.ToString() + " " + dtg_Clientes.CurrentRow.Cells[3].Value.ToString();
            txt_Nombre.Text = nombre;

            cedula = dtg_Clientes.CurrentRow.Cells[0].Value.ToString();
            txt_Cedula.Text = cedula;

            correo= dtg_Clientes.CurrentRow.Cells[4].Value.ToString();
            txt_Correo.Text = correo;

            telefono = dtg_Clientes.CurrentRow.Cells[5].Value.ToString();
            txt_Telefono.Text = telefono;
        }

        private void txt_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cb_Credito_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Habilitar el crédito?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Se ha habilitado el crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Cedula.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Correo.Text = string.Empty;
                txt_Telefono.Text = string.Empty;
                cb_Credito.Checked = false;
                
                CLIENTES Credito = new CLIENTES();

                Credito.Cedula = dtg_Clientes.CurrentRow.Cells[0].Value.ToString();
                Credito.Credito = 1;
                
                Credito_BLL.ModificaCreditos(Credito);
                Cargar();
            }

        }

        private void cb_Deshabilitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Deshabilitar el crédito?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Se ha deshabilitado el crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_Cedula.Text = string.Empty;
                txt_Nombre.Text = string.Empty;
                txt_Correo.Text = string.Empty;
                txt_Telefono.Text = string.Empty;
               cb_Deshabilitar.Checked = false;


                CLIENTES Credito = new CLIENTES();

                Credito.Cedula = dtg_Clientes.CurrentRow.Cells[0].Value.ToString();
                Credito.Credito = 0;


                Credito_BLL.ModificaCreditos(Credito);
                Cargar();

            }



                
        }
    }
    }
