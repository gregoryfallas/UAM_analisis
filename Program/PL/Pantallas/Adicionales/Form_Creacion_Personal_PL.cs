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
            InitializeComponent();
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

                p.Salario_Hora = Convert.ToDecimal(txtsalariohora.Text.Trim());
                p.Salario_Mensual = Convert.ToDecimal(txtsalariomes.Text.Trim());
                p.Fecha_Contratacion = Convert.ToDateTime(dtpfecha.Text.Trim());
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

                objformato = new Formato();
                objformato.Texto = txttelefono.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronTEL;

                if (!R_Humanos.ValidarTexto(objformato))
                {
                    MessageBox.Show("El formato del TELÉFONO no es valido, corregir por favor");
                    return;
                }
                p.Telefono = txttelefono.Text.Trim();
                
        
                R_Humanos.AgregarPersonal(p);
                MessageBox.Show("Personal agregado correctamente");
                cargarGridPersonal();
                txtcedula.Focus();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //private bool ValidarCampos()
        //{
        //    bool ok = true;

        //    if (cboidpuesto.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(cboidpuesto, "Dato Obligatorio");
        //    }

        //    if (txtcedula.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtcedula, "Dato Obligatorio");
        //    }

        //    if (txtnombre.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtnombre, "Dato Obligatorio");
        //    }

        //    if (txtapellido1.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtapellido1, "Dato Obligatorio");
        //    }

        //    if (txtapellido2.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtapellido2, "Dato Obligatorio");
        //    }

        //    if (txtsalariohora.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtsalariohora, "Dato Obligatorio");
        //    }

        //    if (txtsalariomes.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtsalariomes, "Dato Obligatorio");
        //    }

        //    if (dtpfecha.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(dtpfecha, "Dato Obligatorio");
        //    }

        //    if (cboestado.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(cboestado, "Dato Obligatorio");
        //    }

        //    if (txtdireccion.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtdireccion, "Dato Obligatorio");
        //    }

        //    if (txtcorreo.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txtcorreo, "Dato Obligatorio");
        //    }

        //    if (txttelefono.Text == "")
        //    {
        //        ok = false;
        //        errorProvider1.SetError(txttelefono, "Dato Obligatorio");
        //    }


        //    return ok;
        //}

        //private void BorrarMensajeError()
        //{
        //    errorProvider1.SetError(cboidpuesto, "");
        //    errorProvider1.SetError(txtcedula, "");
        //    errorProvider1.SetError(txtnombre, "");
        //    errorProvider1.SetError(txtapellido1, "");
        //    errorProvider1.SetError(txtapellido2, "");
        //    errorProvider1.SetError(txtsalariohora, "");
        //    errorProvider1.SetError(txtsalariomes, "");
        //    errorProvider1.SetError(dtpfecha, "");
        //    errorProvider1.SetError(cboestado, "");
        //    errorProvider1.SetError(txtdireccion, "");
        //    errorProvider1.SetError(txtcorreo, "");
        //    errorProvider1.SetError(txttelefono, "");
        //}

        private void cboidpuesto_SelectedValueChanged(object sender, EventArgs e)
        {
            // txtprueba.Text = cboidpuesto.Text.ToString();
          //  txtprueba.Text = cboidpuesto.SelectedValue.ToString();
              nombrepuesto = cboidpuesto.SelectedValue.ToString();
        }

        private void cboidpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcampos();
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
            CargarCombos();
            CargarCombos3();
            lstresultado = new List<PERSONAL>();

            btnagregar.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void validarcampos()
        {
            var vr = !string.IsNullOrEmpty(cboidpuesto.Text) &&
                !string.IsNullOrEmpty(txtcedula.Text) &&
                !string.IsNullOrEmpty(txtnombre.Text) &&
                !string.IsNullOrEmpty(txtapellido1.Text) &&
                !string.IsNullOrEmpty(txtapellido2.Text) &&
                !string.IsNullOrEmpty(txtsalariohora.Text) &&
                !string.IsNullOrEmpty(txtsalariomes.Text) &&
                !string.IsNullOrEmpty(dtpfecha.Text) &&
                !string.IsNullOrEmpty(cboestado.Text) &&
                !string.IsNullOrEmpty(txtdireccion.Text) &&
                !string.IsNullOrEmpty(txtcorreo.Text) &&
                !string.IsNullOrEmpty(txttelefono.Text);
            btnagregar.Enabled = vr;
            btnmodificar.Enabled = vr;
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

        private void txttelefono_Validating(object sender, CancelEventArgs e)
        {
            //int num;
            //if(!int.TryParse(txttelefono.Text, out num))
            //{
            //    errorProvider1.SetError(txttelefono, "Ingrese el valor en números");
            //}
            //else
            //{
            //    errorProvider1.SetError(txttelefono, "");
            //}
        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtapellido1_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtapellido2_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtsalariohora_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtsalariomes_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtcorreo_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txttelefono_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }
    }
}
