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
using DAL;
using DAL.Entidades;
using BLL;

namespace PL.Pantallas.Adicionales
{
    public partial class Aprovacion : Form
    {
        public Aprovacion()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Aprovacion_Load(object sender, EventArgs e)
        {
            update();
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Suministros_BLL obj_bll = new Suministros_BLL();
            SOLICITUD_COMPRA soli = new SOLICITUD_COMPRA();
            soli.ID_Solicitud_Compra = Convert.ToInt32(dgvsolicitudes.SelectedRows[0].Cells[0].Value);
            soli.Estado = 20;
            bool a = Suministros_BLL.modificar_estado_solicitud(soli);

            if (a)
            {
                MessageBox.Show("Solicitud Aprovada");
                update();
            }
            else
            {
                MessageBox.Show("Error al aprovar la solicitud");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void update()
        {
            //dgvsolicitudes.Rows.Clear();
            Suministros_BLL obj_bll = new Suministros_BLL();
            dgvsolicitudes.DataSource = obj_bll.listar_solicitudes_para_aprovar();
        }
    }
}
