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
    //public List<PUESTOS> lstresultado { get; set; }
    //public bool EsError { get; set; }


    public partial class Form_Crear_Reclutamiento : Form
    {
        public Form_Crear_Reclutamiento()
        {
            InitializeComponent();
            //lstresultado = new List<PUESTOS>();
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

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            try
            {
                List<PUESTOS> lstresultado = R_Humanos.Consultar_Puestos();

                this.dgvpuestos.DataSource = lstresultado;
                this.dgvpuestos.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                //if (!EsError)
                //{
                //    if (VerificarExistenciaCodigo())
                //    {
                //        MessageBox.Show("El código digitado ya existe en base de datos, por favor cambiarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //        return;
                //    }
                
                    RECLUTAMIENTO m = new RECLUTAMIENTO();

                   m.ID_Reclutamiento = Convert.ToInt32(txtid.Text.Trim());
                    m.ID_Puestos = Convert.ToInt32(txtidpuesto.Text.Trim());
                    m.Nombre = txtnombre.Text.Trim();
                    m.Descripcion = txtdescripcion.Text.Trim();
                    m.Estado = Convert.ToInt32(txtestado.Text.Trim());


                    R_Humanos.AgregarReclutamiento(m);
                    MessageBox.Show("Reclutamiento Creado");
                   // limpiar();

                    txtid.Focus();
                
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
