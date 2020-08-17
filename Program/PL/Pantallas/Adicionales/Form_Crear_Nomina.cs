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
    public partial class Form_Crear_Nomina : Form
    {
        private SqlConnection  objconexion;

        public List<PERSONAL> lstresultado { get; set; }
     //   public List<NOMINA> lstresultado { get; set; }
        public bool EsError { get; set; }

        public Form_Crear_Nomina()
        {
            lstresultado = new List<PERSONAL>();
           // lstresultado = new List<NOMINA>();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Pago_Nomina atras = new Adicionales.Form_Pago_Nomina();
            atras.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                NOMINA p = new NOMINA();

                p.Nombre = txtnombre.Text.Trim();
                p.Fecha_Inicio = Convert.ToDateTime(dtpfechainicio.Text.Trim());
                p.Fecha_Fin = Convert.ToDateTime(dtpfechafinal.Text.Trim());
                p.Descripcion = txtdescripcion.Text.Trim();



                R_Humanos.AgregarNomina(p);
                MessageBox.Show("Nómina Creada");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void btnmostrar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        List<PERSONAL> lstresultado = R_Humanos.ConsultarTablaPersonal();

        //        this.dgvpersonal.DataSource = lstresultado;
        //        this.dgvpersonal.Refresh();
        //    }
        //    catch (Exception ex)
        //    {

        //        MessageBox.Show(ex.Message);
        //    }

            //SqlCommand comando = new SqlCommand("Select * from PERSONAL", objconexion);
            //SqlDataAdapter adaptador = new SqlDataAdapter();
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //dgvpersonal.DataSource = tabla;
        //}
    }
}
