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
using PL.Pantallas.Principales;



namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Ingreso_Suministros_PL : Form
    {
        DataTable dtproveedor = new DataTable();
        private int ID_Articulo_Proveedor = 0;
        private int ID_Solicitud_Compra = 0;
        private int Cantidad = 0;
        private String Descripcion = " ";

        public List<Suministros_BLL> listingreso_suministros { get; set; }
        public bool esError { get; set; }

        public Frm_Ingreso_Suministros_PL()
        {
            DAL.Entidades.SOLICITUD_ARTICULOS sa = new SOLICITUD_ARTICULOS();
            InitializeComponent();
            cargarGridingreso_Suministros();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
            
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            SOLICITUD_ARTICULOS lstresultados = new SOLICITUD_ARTICULOS();
            lstresultados.ID_Articulo_Proveedor = Convert.ToInt32(dtproveedor.Rows[cb_proveedor.SelectedIndex].ItemArray[0].ToString());
            lstresultados.ID_Solicitud_Compra = Convert.ToInt32(txt_id_compra.Text);
            lstresultados.Descripcion = txt_descripcion.Text.ToString();
            lstresultados.Cantidad = Convert.ToDecimal(txt_cantidad.Text);
            lstresultados.encabezado = tb_descrip.Text.ToString().Trim();
            lstresultados.estado = 1;

            Suministros_BLL.agregarSuministros(lstresultados);

            MessageBox.Show("Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cargarGridingreso_Suministros();
        }

        private void cargarGridingreso_Suministros()
        {
            try
            {
                this.dataGrid_ingresosumi.DataSource = null;
                this.dataGrid_ingresosumi.DataSource = Suministros_BLL.consulta_suministros().Copy();

                dtproveedor = Suministros_BLL.consulta_proveedores_suministros().Copy();

                foreach (DataRow i in dtproveedor.Rows)
                {
                    cb_proveedor.Items.Add(i.ItemArray[1].ToString());
                }

                cb_proveedor.SelectedIndex = 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dataGrid_ingresosumi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_articulo.Text = dataGrid_ingresosumi.CurrentRow.Cells[0].Value.ToString();
            txt_descripcion.Text = dataGrid_ingresosumi.CurrentRow.Cells[3].Value.ToString();
            txt_cantidad.Text = dataGrid_ingresosumi.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            SOLICITUD_ARTICULOS lstresultados = new SOLICITUD_ARTICULOS();

            lstresultados.ID_Solicitud_Articulos = Convert.ToInt32(txt_id_articulo.Text);
            lstresultados.ID_Articulo_Proveedor = Convert.ToInt32(dtproveedor.Rows[cb_proveedor.SelectedIndex].ItemArray[0].ToString());
            lstresultados.ID_Solicitud_Compra = Convert.ToInt32(txt_id_compra.Text);
            lstresultados.Descripcion = txt_descripcion.Text.ToString();
            lstresultados.Cantidad = Convert.ToDecimal(txt_cantidad.Text);

            Suministros_BLL.modificarSuministros(lstresultados);

            MessageBox.Show("Modificado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cargarGridingreso_Suministros();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_idformulario.Text != "")
                {
                    this.dataGrid_ingresosumi.DataSource = null;
                    this.dataGrid_ingresosumi.DataSource = Suministros_BLL.consulta_suministros_id(Convert.ToInt32(tb_idformulario.Text)).Copy();
                }
                else
                {
                    this.dataGrid_ingresosumi.DataSource = null;
                    this.dataGrid_ingresosumi.DataSource = Suministros_BLL.consulta_suministros().Copy();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
