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
    public partial class Frm_Despacho_Suministros_PL : Form
    {
        DataTable dtestados;
        Suministros_BLL Suministros_BLL = new Suministros_BLL();
        public Frm_Despacho_Suministros_PL()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Despacho_Suministros_PL_Load(object sender, EventArgs e)
        {
            dataGridV_resumen.DataSource = Suministros_BLL.ConsultarDespacho().Copy();

            dtestados = Suministros_BLL.ConsultarEstados().Copy();

            foreach (DataRow i in dtestados.Rows)
            {
                cb_estado.Items.Add(i.ItemArray[1].ToString());
            }

            cb_estado.SelectedIndex = 0;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DESPACHO despacho = new DESPACHO();
            despacho.ID_Factura = Convert.ToInt32(txt_id_factura.Text);
            despacho.Fecha = Convert.ToDateTime(txt_fecha.Text);
            despacho.Estado = cb_estado.SelectedIndex +1;

            Suministros_BLL.agregarDespacho(despacho);

            MessageBox.Show("Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridV_resumen.DataSource = Suministros_BLL.ConsultarDespacho().Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_buscar.Text != "")
            {
                dataGridV_resumen.DataSource = Suministros_BLL.consulta_despacho_id(Convert.ToInt32(txt_buscar.Text)).Copy();
            }
            else
            {
                dataGridV_resumen.DataSource = Suministros_BLL.ConsultarDespacho().Copy();
            }
        }

        private void dataGridV_resumen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_despacho.Text = dataGridV_resumen.CurrentRow.Cells[0].Value.ToString();
            txt_id_factura.Text = dataGridV_resumen.CurrentRow.Cells[1].Value.ToString();
            txt_fecha.Text = dataGridV_resumen.CurrentRow.Cells[2].Value.ToString();
            cb_estado.SelectedIndex = Convert.ToInt32(dataGridV_resumen.CurrentRow.Cells[3].Value.ToString());
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            DESPACHO despacho = new DESPACHO();
            despacho.ID_Despacho = Convert.ToInt32(txt_id_despacho.Text);
            despacho.ID_Factura = Convert.ToInt32(txt_id_factura.Text);
            despacho.Fecha = Convert.ToDateTime(txt_fecha.Text);
            despacho.Estado = cb_estado.SelectedIndex + 1;

            Suministros_BLL.modificardespacho(despacho);

            MessageBox.Show("Modificado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridV_resumen.DataSource = Suministros_BLL.ConsultarDespacho().Copy();
        }
    }
}
