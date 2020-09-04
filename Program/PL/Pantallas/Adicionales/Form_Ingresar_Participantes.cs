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
    public partial class Form_Ingresar_Participantes : Form
    {
        //public List<PARTICIPANTES> lstresultado { get; set; }
        //public bool EsError { get; set; }

        private int estado = 0;
        private int provincia_id = 0;
        private int canton_id = 0;

        //values
        private string id_Distritos;
        private string id_Canton;
        private string id_Provincia;
        private string Nombre_Provincia;

        private string nombrepuesto;
        private string nombreEstado;

        private string ced;
        private string provincia;
        private string canton;
        private string distrito;
        private string estadodgv;
        private string puestoreclutamiento;

        public Form_Ingresar_Participantes()
        {
            //lstresultado = new List<PARTICIPANTES>();
            InitializeComponent();

           
        }

        private void limpiar()
        {
            cboreclutamiento.SelectedIndex = 0;
            txtcedula.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtapellido1.Text = string.Empty;
            txtapellido2.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            txttelefono.Text = string.Empty;
            Provinciacbo.SelectedIndex = 0;
            Cantoncbo.SelectedIndex = 0;
            Distritocbo.SelectedIndex = 0;
            txtdireccion.Text = string.Empty;
            cboestado.SelectedIndex = 0;

        }

        private void CargarCombosEstados()
        {
            List<ESTADOS> lstresultado = R_Humanos.ConsultarTipoEstadoPostulantes();

            this.cboestado.DataSource = lstresultado;
            cboestado.ValueMember = "ID_Estados";
            cboestado.DisplayMember = "Nombre";
            cboestado.Refresh();
        }

        private void CargarComboIdReclutamiento()
        {
           

            try
            {
                List<RECLUTAMIENTO> lstresultado = R_Humanos.ConsultarIDReclutamiento();

                this.cboreclutamiento.DataSource = lstresultado;
                cboreclutamiento.ValueMember = "ID_Reclutamiento";
                cboreclutamiento.DisplayMember = "Nombre";
                cboreclutamiento.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("No hay reclutamientos creados");
            }
        }

        private void CargarCombosProvincias()
        {

            List<PROVINCIAS> lstresultado = R_Humanos.ConsultaProvincia();

            this.Provinciacbo.DataSource = lstresultado;
            Provinciacbo.ValueMember = "ID_Provincias";
            Provinciacbo.DisplayMember = "Nombre";
            Provinciacbo.Refresh();
            CargarCombosCantones();


        }

        private void CargarCombosCantones()
        {

            List<CANTONES> lstresultado = R_Humanos.ConsultaCantones(provincia_id);
            this.Cantoncbo.DataSource = lstresultado;
            Cantoncbo.ValueMember = "ID_Cantones";
            Cantoncbo.DisplayMember = "Nombre";
            Cantoncbo.Refresh();
            CargarCombosDistritos();
        }

        private void CargarCombosDistritos()
        {

            List<DISTRITOS> lstresultado = R_Humanos.ConsultaDistritos(canton_id);
            this.Distritocbo.DataSource = lstresultado;
            Distritocbo.ValueMember = "ID_Distritos";
            Distritocbo.DisplayMember = "Nombre";
            Distritocbo.Refresh();
        }

        private void nombreProvincia(int id)
        {
            Nombre_Provincia = "a";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                PARTICIPANTES p = new PARTICIPANTES();

                p.ID_Reclutamiento = Convert.ToInt32(nombrepuesto);

                /*********************************************************************************************/
                Formato objformato = new Formato();

                objformato.Texto = txtcedula.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronID;
                if (!R_Humanos.ValidarTexto(objformato))
                {
                    MessageBox.Show("El formato de la Cédula no es valido, corregir por favor");
                    return;
                }
                p.Cedula_ = txtcedula.Text.Trim();

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
                objformato = new Formato();
                objformato.Texto = txtcorreo.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronCORREO;

                if (!R_Humanos.ValidarTexto(objformato))
                {
                    MessageBox.Show("El formato del CORREO no es valido, corregir por favor");
                    return;
                }
                p.Correo = txtcorreo.Text.Trim();

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

                /*********************************************************************************************/
                p.ID_Provincia = provincia_id;
                p.ID_Canton = canton_id;
                p.ID_Distrito = Convert.ToInt32(id_Distritos);
                p.Direccion = txtdireccion.Text.Trim();
                p.Estado = Convert.ToInt32(nombreEstado);

                R_Humanos.AgregarPostulantes(p);
                MessageBox.Show("Postulante agregado correctamente");
                limpiar();
                cargarGridParticipantes();
                cboreclutamiento.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Provinciacbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.provincia_id = Convert.ToInt32(Provinciacbo.SelectedIndex) + 1;
                       
            CargarCombosCantones();
        }

        private void Cantoncbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Canton = Cantoncbo.SelectedValue.ToString();
            string nombreCanton = Cantoncbo.Text;
            List<CANTONES> ls = R_Humanos.ConsultarCanton(nombreCanton);
            CANTONES c = new CANTONES();
            foreach (CANTONES item in ls)
            {
                c.ID_Cantones = item.ID_Cantones;

            }

            canton_id = c.ID_Cantones;
            CargarCombosDistritos();
        }

        private void Distritocbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Distritos = Distritocbo.SelectedValue.ToString();
        }

        private void cboreclutamiento_SelectedValueChanged(object sender, EventArgs e)
        {
            nombrepuesto = cboreclutamiento.SelectedValue.ToString();
        }

        private void cboestado_SelectedValueChanged(object sender, EventArgs e)
        {
            nombreEstado = cboestado.SelectedValue.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                PARTICIPANTES p = new PARTICIPANTES();

                p.ID_Reclutamiento = Convert.ToInt32(nombrepuesto);
                p.Cedula_ = txtcedula.Text.Trim();
                p.Nombre = txtnombre.Text.Trim();
                p.Apellido_1 = txtapellido1.Text.Trim();
                p.Apellido_2 = txtapellido2.Text.Trim();
                p.Correo = txtcorreo.Text.Trim();
                p.Telefono = txttelefono.Text.Trim();
                p.ID_Provincia = provincia_id;
                p.ID_Canton = canton_id;
                p.ID_Distrito = Convert.ToInt32(id_Distritos);
                p.Direccion = txtdireccion.Text.Trim();
                p.Estado = Convert.ToInt32(nombreEstado);

                R_Humanos.ModificarPostulantes(p);
                MessageBox.Show("Postulante Modificado");
                limpiar();
                cargarGridParticipantes();
                cboreclutamiento.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cargarGridParticipantes()
        {

            try
            {
                this.dgvparticipantes.DataSource = null;
                this.dgvparticipantes.Refresh();

                this.dgvparticipantes.DataSource = R_Humanos.Obtener_Participantes(this.txtcedula.Text.Trim());
                // this.dataGridView1.DataSource = Clientes_BLL.ConsultarClientes(this.textBox6.Text.Trim());

                this.dgvparticipantes.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }

        private void dgvparticipantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvparticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Hizo click en una fila no permitida", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                puestoreclutamiento = dgvparticipantes.Rows[e.RowIndex].Cells[0].Value.ToString();
                cboreclutamiento.Text = puestoreclutamiento;
                puestoreclutamiento = dgvparticipantes.Rows[e.RowIndex].Cells[1].Value.ToString();
                cboreclutamiento.Text = puestoreclutamiento;

                txtcedula.Text = dgvparticipantes.Rows[e.RowIndex].Cells[2].Value.ToString();
                ced = dgvparticipantes.Rows[e.RowIndex].Cells[2].Value.ToString();

                txtnombre.Text = dgvparticipantes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtapellido1.Text = dgvparticipantes.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtapellido2.Text = dgvparticipantes.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtcorreo.Text = dgvparticipantes.Rows[e.RowIndex].Cells[6].Value.ToString();
                txttelefono.Text = dgvparticipantes.Rows[e.RowIndex].Cells[7].Value.ToString();

                provincia = dgvparticipantes.Rows[e.RowIndex].Cells[8].Value.ToString();
                Provinciacbo.Text = provincia;

                canton = dgvparticipantes.Rows[e.RowIndex].Cells[9].Value.ToString();
                Cantoncbo.Text = canton;

                distrito = dgvparticipantes.Rows[e.RowIndex].Cells[10].Value.ToString();
                Distritocbo.Text = distrito;

                txtdireccion.Text = dgvparticipantes.Rows[e.RowIndex].Cells[11].Value.ToString();

                estadodgv = dgvparticipantes.Rows[e.RowIndex].Cells[12].Value.ToString();
                cboestado.Text = estadodgv;
            }
        }

        private void Form_Ingresar_Participantes_Load(object sender, EventArgs e)
        {
            CargarCombosEstados();
            CargarCombosProvincias();
            cargarGridParticipantes();
            CargarCombosEstados();
            CargarComboIdReclutamiento();
            CargarCombosProvincias();
            CargarCombosCantones();
            CargarCombosDistritos();

            btnagregar.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void validarcampos()
        {
            var vr = !string.IsNullOrEmpty(txtdireccion.Text);
            btnagregar.Enabled = vr;
            btnmodificar.Enabled = vr;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }
    }
}
