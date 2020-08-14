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

namespace PL.Pantallas.Adicionales
{
    public partial class Form_Creacion_Personal_PL : Form
    {
        private string nombrepuesto;
        private string nombreEstado;


        public List<PERSONAL> lstresultado { get; set; }
        public bool EsError { get; set; }

        public Form_Creacion_Personal_PL()
        {
            lstresultado = new List<PERSONAL>();
            InitializeComponent();
            CargarCombos();
            CargarCombos3();
        }

        private void CargarCombos()
        {
            List<ESTADOS> lstresultado = R_Humanos.ConsultaTipoEstadoPersonal();

            this.cboestado.DataSource = lstresultado;
            cboestado.ValueMember = "ID_Estados";
            cboestado.DisplayMember = "Nombre";
            cboestado.Refresh();
        }

        private void CargarCombos3()
        {
            List<PUESTOS> lstresultado = R_Humanos.ConsultaTipoCargo();

            this.cboidpuesto.DataSource = lstresultado;
            cboidpuesto.ValueMember = "ID_Puestos";
            cboidpuesto.DisplayMember = "Nombre";
            cboidpuesto.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Menu_Personal atras = new Adicionales.Form_Menu_Personal();
            atras.ShowDialog();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                PERSONAL p = new PERSONAL();

                //p.ID_Puesto = Convert.ToInt32(cboidpuesto.Text.Trim());
                p.ID_Puesto = Convert.ToInt32(nombrepuesto);
                p.Cedula = txtcedula.Text.Trim();
                p.Nombre = txtnombre.Text.Trim();
                p.Apellido_1 = txtapellido1.Text.Trim();
                p.Apellido_2 = txtapellido2.Text.Trim();
                p.Salario_Hora = Convert.ToDecimal(txtsalariohora.Text.Trim());
                p.Salario_Mensual = Convert.ToDecimal(txtsalariomes.Text.Trim());
                p.Fecha_Contratacion = Convert.ToDateTime(dtpfecha.Text.Trim());
                 // p.Estado = Convert.ToInt32(cboestado.Text.Trim());
                p.Estado = Convert.ToInt32(nombreEstado);
                p.Direccion = txtdireccion.Text.Trim();
                p.Correo_Electronico = txtcorreo.Text.Trim();
                p.Telefono = txttelefono.Text.Trim();



                R_Humanos.AgregarPersonal(p);
                MessageBox.Show("Personal agregado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboidpuesto_SelectedValueChanged(object sender, EventArgs e)
        {
            // txtprueba.Text = cboidpuesto.Text.ToString();
          //  txtprueba.Text = cboidpuesto.SelectedValue.ToString();
              nombrepuesto = cboidpuesto.SelectedValue.ToString();
        }

        private void cboidpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtprueba.Text = cboidpuesto.Text.ToString();
        }

        private void cboestado_SelectedValueChanged(object sender, EventArgs e)
        {
            //textBox1.Text = cboestado.SelectedValue.ToString();
            // txtprueba.Text = cboestado.Text.ToString();
            //  txtprueba.Text = cboestado.SelectedValue.ToString();
            nombreEstado = cboestado.SelectedValue.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                PERSONAL p = new PERSONAL();

                //p.ID_Puesto = Convert.ToInt32(cboidpuesto.Text.Trim());

                p.ID_Puesto = Convert.ToInt32(nombrepuesto);
                p.Cedula = txtcedula.Text.Trim();
                p.Nombre = txtnombre.Text.Trim();
                p.Apellido_1 = txtapellido1.Text.Trim();
                p.Apellido_2 = txtapellido2.Text.Trim();
                p.Salario_Hora = Convert.ToDecimal(txtsalariohora.Text.Trim());
                p.Salario_Mensual = Convert.ToDecimal(txtsalariomes.Text.Trim());
                p.Fecha_Contratacion = Convert.ToDateTime(dtpfecha.Text.Trim());
                // p.Estado = Convert.ToInt32(cboestado.Text.Trim());
                p.Estado = Convert.ToInt32(nombreEstado);
                p.Direccion = txtdireccion.Text.Trim();
                p.Correo_Electronico = txtcorreo.Text.Trim();
                p.Telefono = txttelefono.Text.Trim();

                R_Humanos.ModificarPersonal(p);
                MessageBox.Show("Personal Modificado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
