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
            lstresultado = new List<PRUEBAS>();
            CargarComboIdPruebas();
            CargarComboIdParticipantes();
        }

        private void CargarComboIdPruebas()
        {
            List<PRUEBAS> lstresultado = R_Humanos.NotasIdPruebas();

            this.cbopruebas.DataSource = lstresultado;
            cbopruebas.ValueMember = "ID_Pruebas";
            cbopruebas.DisplayMember = "Nombre";
            cbopruebas.Refresh();
        }

        private void CargarComboIdParticipantes()
        {
            List<PARTICIPANTES> lstresultado = R_Humanos.NotasIdParticipantes();

            this.cboparticipantes.DataSource = lstresultado;
            cboparticipantes.ValueMember = "ID_Participantes";
            cboparticipantes.DisplayMember = "Cedula_";
            cboparticipantes.Refresh();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                PRUEBAS p = new PRUEBAS();

               
                p.Nombre = txtnombre.Text.Trim();
                p.Descripcion = txtdescripcion.Text.Trim();
               


                R_Humanos.AgregarPruebas(p);
                MessageBox.Show("Prueba agregado");


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
                p.Nota = Convert.ToDecimal(txtnota.Text.Trim());

                R_Humanos.AgregarNotaPruebas(p);
                MessageBox.Show("Nota agregada");


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
    }
}
