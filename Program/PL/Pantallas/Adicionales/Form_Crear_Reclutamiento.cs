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
using System.Data.SqlClient;

namespace PL.Pantallas.Adicionales
{
    public partial class Form_Crear_Reclutamiento : Form
    {
        private int puestos = 0;
        private string nombrepuesto;
        private string nombreEstado;
        
        public List<RECLUTAMIENTO> lstresultado { get; set; }
        public bool EsError { get; set; }

        public Form_Crear_Reclutamiento()
        {
            lstresultado = new List<RECLUTAMIENTO>();
            InitializeComponent();
            CargarCombos();
         
            CargarCombos3();
        }
        
        private void CargarCombos()
        {
            List<ESTADOS> lstresultado = R_Humanos.ConsultaTipoEstado();

            this.cboestado.DataSource = lstresultado;
            cboestado.ValueMember = "ID_Estados";
            cboestado.DisplayMember = "Nombre";
            cboestado.Refresh();
        }

        private void CargarCombos3()
        {
            List<PUESTOS> lstresultado = R_Humanos.ConsultaTipoCargo();

            this.cbonombre.DataSource = lstresultado;
            cbonombre.ValueMember = "ID_Puestos";
            cbonombre.DisplayMember = "Nombre";
            cbonombre.Refresh();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                    RECLUTAMIENTO p = new RECLUTAMIENTO();

                // p.ID_Puestos = Convert.ToInt32(cboidpuesto.Text.Trim());
                p.ID_Puestos = puestos;
                p.Nombre = nombrepuesto;
                    p.Descripcion = txtdescripcion.Text.Trim();
                //  p.Estado = Convert.ToInt32(cboestado.Text.Trim());
                p.Estado = Convert.ToInt32(nombreEstado);
                
                R_Humanos.AgregarReclutamiento(p);
                    MessageBox.Show("Reclutamiento creado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Información enviada a Marketing para lanzar vacante.");
        }

        private void cbonombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            // textBox1.Text = cbonombre.SelectedIndex.ToString(); 
            puestos = Convert.ToInt32(cbonombre.SelectedIndex) + 1;
            // textBox1.Text = puestos.ToString();
            //  nombrepuesto = cbonombre.;
            // txtdescripcion.Text = cbonombre.SelectedValue.ToString();
            // txtdescripcion.Text = cbonombre.DisplayMember.ToString();
            // txtdescripcion.Text = cbonombre.SelectedText.ToString();
            validarcampos();
        }

        private void cbonombre_SelectedValueChanged(object sender, EventArgs e)
        {
            // nombrepuesto
            // txtdescripcion.Text = cbonombre.Text.ToString();
            nombrepuesto = cbonombre.Text.ToString();
        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcampos();
            //textBox1.Text = cboestado.SelectedValue.ToString();
            //textBox1.Text = cboestado.SelectedValue.ToString();
        }

        private void cboestado_SelectedValueChanged(object sender, EventArgs e)
        {
            //textBox1.Text = cboestado.SelectedValue.ToString();
            nombreEstado = cboestado.SelectedValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_Crear_Reclutamiento_Load(object sender, EventArgs e)
        {
            btncrear.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void validarcampos()
        {
            var vr = !string.IsNullOrEmpty(cbonombre.Text) &&
                !string.IsNullOrEmpty(txtdescripcion.Text)&&
            !string.IsNullOrEmpty(cboestado.Text);
            btncrear.Enabled = vr;
            btnmodificar.Enabled = vr;
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                RECLUTAMIENTO p = new RECLUTAMIENTO();

                // p.ID_Puestos = Convert.ToInt32(cboidpuesto.Text.Trim());
                p.ID_Puestos = puestos;
                p.Nombre = nombrepuesto;
                p.Descripcion = txtdescripcion.Text.Trim();
                //  p.Estado = Convert.ToInt32(cboestado.Text.Trim());
                p.Estado = Convert.ToInt32(nombreEstado);

                R_Humanos.ModificarReclutamiento(p);
                MessageBox.Show("Reclutamiento modificado con éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
