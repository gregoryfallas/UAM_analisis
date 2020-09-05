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

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Compras_PL : Form
    {
        public Frm_Compras_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
           
           
            if (MessageBox.Show("¿Desea registrar la compra?", "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show ("Registro Realizado con Exito","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }



        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea editar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }

        private void btn_Agre_Art_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Compras_PL_Load(object sender, EventArgs e)
        {
            Suministros_BLL obj_bll = new Suministros_BLL();
            dtg_Proveedor.DataSource = obj_bll.listar_solicitudes_aprovar();
        }

        private void dtg_Proveedor_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dtg_Proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_solicitud.Text = dtg_Proveedor.SelectedRows[0].Cells[0].Value.ToString();
            txt_NombreProv.Text = dtg_Proveedor.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
