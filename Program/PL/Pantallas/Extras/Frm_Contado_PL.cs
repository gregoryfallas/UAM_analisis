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

namespace PL.Pantallas.Extras
{
    public partial class Frm_Contado_PL : Form
    {
        public Frm_Contado_PL()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            Frm_Servicios_PL servicios = new Frm_Servicios_PL();
            servicios.ShowDialog();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea continuar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Total_Factura_PL factura = new Frm_Total_Factura_PL();
                factura.ShowDialog();
            }
        }

        private void btn_Orden_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea Cargar orden de Médico ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string orden;
                orden = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el número de orden:", "Orden de Médico");
                MessageBox.Show("Orden Cargada con Exito: " + orden, "Orden", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txt_Orden.Text = orden;

            }
        }

        private void Frm_Contado_PL_Load(object sender, EventArgs e)
        {
            txt_Fecha_Doc.Text = DateTime.Now.ToShortDateString();

            Cargar();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Cargar();



        }
       
        private void Cargar ()
        {

            Clientes_BLL Clientes = new Clientes_BLL();

            CLIENTES Persona = new CLIENTES();

            List<CLIENTES> LS = Clientes_BLL.ConsultarClientes(txt_Cliente.Text.Trim());

            DataTable dt = new DataTable();

            dt.Columns.Add("Cedula");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Primer_Apellido");
            dt.Columns.Add("Segundo_Apellido");           

            foreach (CLIENTES item in LS)
            {
                dt.Rows.Add
                    (
                    item.Cedula,
                    item.Nombre,
                    item.Apellido_1,
                    item.Apellido_2              
                    );
            }

            dtg_Clientes.DataSource = null;
            dtg_Clientes.Refresh();
            dtg_Clientes.DataSource = dt;
            dtg_Clientes.Refresh();

          


        }

        private void dtg_Clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Nombre.Text = dtg_Clientes.CurrentRow.Cells[1].Value.ToString()+" "+ dtg_Clientes.CurrentRow.Cells[2].Value.ToString()+" "+ dtg_Clientes.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
