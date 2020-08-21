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

        private string estadodgv;
        private string puestopersonal;
        private string ced;

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
                /*********************************************************************************************/

                Formato objformato = new Formato();

                objformato.Texto = txtcedula.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronID;
                if (!R_Humanos.ValidarTexto(objformato))
                {
                    MessageBox.Show("El formato de la Cédula no es valido, corregir por favor");
                    return;
                }
                p.Cedula = txtcedula.Text.Trim();
                /*********************************************************************************************/

                objformato = new Formato();
                objformato.Texto = txtnombre.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronNOMBRE;
                if (!R_Humanos.ValidarTexto(objformato) || objformato.Texto.Length == 0)
                {
                    MessageBox.Show("El formato del Nombre no es valido, corregir por favor");
                    return;
                }
                p.Nombre = txtnombre.Text.Trim();
                /*********************************************************************************************/

                objformato = new Formato();
                objformato.Texto = txtapellido1.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronNOMBRE;
                if (!R_Humanos.ValidarTexto(objformato) || objformato.Texto.Length == 0)
                {
                    MessageBox.Show("El formato del Apellido no es valido, corregir por favor");
                    return;
                }
                p.Apellido_1 = txtapellido1.Text.Trim();
                /*********************************************************************************************/

                objformato = new Formato();
                objformato.Texto = txtapellido2.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronNOMBRE;
                if (!R_Humanos.ValidarTexto(objformato) || objformato.Texto.Length == 0)
                {
                    MessageBox.Show("El formato del Apellido no es valido, corregir por favor");
                    return;
                }
                p.Apellido_2 = txtapellido2.Text.Trim();
                /*********************************************************************************************/

                //objformato.Texto = txtsalariohora.Text.Trim();
                //objformato.PatronValidacion = Constantes.PatronID;
                //if (!R_Humanos.ValidarTexto(objformato))
                //{
                //    MessageBox.Show("El formato del Salario no es valido, no utilizar punto ni coma, corregir por favor");
                //    return;
                //}
                p.Salario_Hora = Convert.ToDecimal(txtsalariohora.Text.Trim());
                /*********************************************************************************************/

                //objformato.Texto = txtsalariomes.Text.Trim();
                //objformato.PatronValidacion = Constantes.PatronID;
                //if (!R_Humanos.ValidarTexto(objformato))
                //{
                //    MessageBox.Show("El formato del Salario no es valido, NO utilizar punto NI coma, corregir por favor");
                //    return;
                //}
                p.Salario_Mensual = Convert.ToDecimal(txtsalariomes.Text.Trim());
                /*********************************************************************************************/

                p.Fecha_Contratacion = Convert.ToDateTime(dtpfecha.Text.Trim());
                // p.Estado = Convert.ToInt32(cboestado.Text.Trim());
                p.Estado = Convert.ToInt32(nombreEstado);
                p.Direccion = txtdireccion.Text.Trim();
                /*********************************************************************************************/

                objformato = new Formato();
                objformato.Texto = txtcorreo.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronCORREO;

                if (!R_Humanos.ValidarTexto(objformato))
                {
                    MessageBox.Show("El formato del CORREO no es valido, corregir por favor");
                    return;
                }
                p.Correo_Electronico = txtcorreo.Text.Trim();
                /*********************************************************************************************/

                //objformato.Texto = txttelefono.Text.Trim();
                //objformato.PatronValidacion = Constantes.PatronID;
                //if (!R_Humanos.ValidarTexto(objformato))
                //{
                //    MessageBox.Show("El formato del número telefónico no es valido, corregir por favor");
                //    return;
                //}
                p.Telefono = txttelefono.Text.Trim();



                R_Humanos.AgregarPersonal(p);
                MessageBox.Show("Personal agregado");
                cargarGridPersonal();

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
                cargarGridPersonal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Form_Creacion_Personal_PL_Load(object sender, EventArgs e)
        {
            cargarGridPersonal();
        }

        private void cargarGridPersonal()
        {

            try
            {
                this.dgvpersonal.DataSource = null;
                this.dgvpersonal.Refresh();

                this.dgvpersonal.DataSource = R_Humanos.Obtener_PersonalDGV(this.txtcedula.Text.Trim());
          
                this.dgvpersonal.Refresh();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgvpersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Hizo click en una fila no permitida", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                puestopersonal = dgvpersonal.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboidpuesto.Text = puestopersonal;
                puestopersonal = dgvpersonal.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboidpuesto.Text = puestopersonal;

                txtcedula.Text = dgvpersonal.Rows[e.RowIndex].Cells[2].Value.ToString();
                ced = dgvpersonal.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtnombre.Text = dgvpersonal.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtapellido1.Text = dgvpersonal.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtapellido2.Text = dgvpersonal.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtsalariohora.Text = dgvpersonal.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtsalariomes.Text = dgvpersonal.Rows[e.RowIndex].Cells[7].Value.ToString();
                dtpfecha.Text = dgvpersonal.Rows[e.RowIndex].Cells[8].Value.ToString();

                estadodgv = dgvpersonal.Rows[e.RowIndex].Cells[9].Value.ToString();
                cboestado.Text = estadodgv;

                txtdireccion.Text = dgvpersonal.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtcorreo.Text = dgvpersonal.Rows[e.RowIndex].Cells[11].Value.ToString();
                txttelefono.Text = dgvpersonal.Rows[e.RowIndex].Cells[12].Value.ToString();
               

               
            }
        }
    }
}
