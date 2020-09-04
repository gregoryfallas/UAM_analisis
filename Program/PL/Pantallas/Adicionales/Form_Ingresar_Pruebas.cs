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
    public partial class Form_Ingresar_Pruebas : Form
    {
        private string IdPruebas;
        private string IdParticipantes;

        public List<PRUEBAS> lstresultado { get; set; }
        public Form_Ingresar_Pruebas()
        {
            InitializeComponent();
        }

        private void CargarComboIdPruebas()
        {
            try
            {
                List<PRUEBAS> lstresultado = R_Humanos.NotasIdPruebas();

                this.cbopruebas.DataSource = lstresultado;
                cbopruebas.ValueMember = "ID_Pruebas";
                cbopruebas.DisplayMember = "Nombre";
                cbopruebas.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("No hay pruebas agregadas");
            }
        }

        private void CargarComboIdParticipantes()
        {
            try
            {
                List<PARTICIPANTES> lstresultado = R_Humanos.NotasIdParticipantes();

                this.cboparticipantes.DataSource = lstresultado;
                cboparticipantes.ValueMember = "ID_Participantes";
                cboparticipantes.DisplayMember = "Cedula_";
                cboparticipantes.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("No hay participantes agregados");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                PRUEBAS p = new PRUEBAS();

                p.Nombre = txtnombre.Text.Trim();
                p.Descripcion = txtdescripcion.Text.Trim();
              
                R_Humanos.AgregarPruebas(p);
                MessageBox.Show("Prueba agregada correctamente");
                CargarComboIdPruebas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {

        }

        private void cbopruebas_SelectedValueChanged(object sender, EventArgs e)
        {
            // txtnota.Text = cbopruebas.SelectedValue.ToString();
            IdPruebas = cbopruebas.SelectedValue.ToString();
        }

        private void cboparticipantes_SelectedValueChanged(object sender, EventArgs e)
        {
            // txtnota.Text = cboparticipantes.SelectedValue.ToString();
            IdParticipantes = cboparticipantes.SelectedValue.ToString();
        }

        private void btnagregar2_Click(object sender, EventArgs e)
        {
            try
            {
                PRUEBAS_PARTICIPANTES p = new PRUEBAS_PARTICIPANTES();


                p.ID_Pruebas = Convert.ToInt32(IdPruebas);
                p.ID_Participantes = Convert.ToInt32(IdParticipantes);

                Formato objformato = new Formato();
                objformato = new Formato();
                objformato.Texto = txtnota.Text.Trim();
                objformato.PatronValidacion = Constantes.PatronTEL;

                if (!R_Humanos.ValidarTexto(objformato))
                {
                    MessageBox.Show("El formato de la NOTA no es valido, corregir por favor");
                    return;
                }
                p.Nota = Convert.ToInt32(txtnota.Text.Trim());

                R_Humanos.AgregarNotaPruebas(p);
                MessageBox.Show("Nota agregada correctamente");


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

        private void Form_Ingresar_Pruebas_Load(object sender, EventArgs e)
        {
            lstresultado = new List<PRUEBAS>();
            CargarComboIdPruebas();
            CargarComboIdParticipantes();

            btnagregar.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void validarcampos()
        {
            var vr = !string.IsNullOrEmpty(txtnombre.Text) &&
                !string.IsNullOrEmpty(txtdescripcion.Text);
            btnagregar.Enabled = vr;
            btnmodificar.Enabled = vr;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }
    }
}
