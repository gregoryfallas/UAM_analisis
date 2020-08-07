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
   // public List<RECLUTAMIENTO> lstresultado { get; set; }
    //public bool EsError { get; set; }


    public partial class Form_Crear_Reclutamiento : Form
    {
        public Form_Crear_Reclutamiento()
        {
            InitializeComponent();
         //   lstresultado = new List<RECLUTAMIENTO>();
            CargarCombos();
            CargarCombos2();
        }

        private void limpiar()
        {

           // txtid.Text = string.Empty;
            cboidpuestos.Text = string.Empty;
           // txtnombre.Text = string.Empty;
           txtdescripcion.Text = string.Empty;
            cboestado.Text = string.Empty;

        }
        private void CargarCombos()
        {
            List<ESTADOS> lstresultado = R_Humanos.ConsultaEstados();

            this.cboestado.DataSource = lstresultado;
            cboestado.ValueMember = "ID_Estados";
            cboestado.DisplayMember = "Nombre";
            cboestado.Refresh();
        }

        private void CargarCombos2()
        {
            List<PUESTOS> lstresultado = R_Humanos.ConsultaPuesto();

            this.cboidpuestos.DataSource = lstresultado;
            cboidpuestos.ValueMember = "ID_Puestos";
            cboidpuestos.DisplayMember = "Nombre";
            cboidpuestos.Refresh();
        }

        //private bool VerificarExistenciaCodigo()
        //{
        //    bool L_resultado = false;

        //    try
        //    {
        //        foreach (PUESTOS item in lstresultado)
        //        {
        //            if (item.ID_Puestos == Convert.ToInt32(txtid.Text.Trim()))
        //            {
        //                L_resultado = true; // Es igual a encontro el codigo
        //                break;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return L_resultado;
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Menu_Reclutamiento atras = new Adicionales.Form_Menu_Reclutamiento();
            atras.ShowDialog();
        }

        //private void btnmostrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        List<PUESTOS> lstresultado = R_Humanos.Consultar_Puestos();

        //        this.dgvpuestos.DataSource = lstresultado;
        //        this.dgvpuestos.Refresh();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btncrear_Click(object sender, EventArgs e)
        {
           
            try
            {
               

                RECLUTAMIENTO m = new RECLUTAMIENTO();

           
                  m.Nombre = cboidpuestos.Text.Trim();
                m.Descripcion = txtdescripcion.Text.Trim();
            m.Estado = Convert.ToInt32(cboestado.Text.Trim());


            R_Humanos.AgregarReclutamiento(m);
            MessageBox.Show("Reclutamiento Creado");
            limpiar();

            cboidpuestos.Focus();

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnenviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enviado a Marketing para lanzar vacante.");
        }
    }
}
