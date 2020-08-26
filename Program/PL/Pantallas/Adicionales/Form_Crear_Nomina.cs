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
     
        public bool EsError { get; set; }

        public Form_Crear_Nomina()
        {
            lstresultado = new List<PERSONAL>();
          
            InitializeComponent();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
