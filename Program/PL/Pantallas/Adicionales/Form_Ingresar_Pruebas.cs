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
        public List<PRUEBAS> lstresultado { get; set; }
        public Form_Ingresar_Pruebas()
        {
            InitializeComponent();
            lstresultado = new List<PRUEBAS>();
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
    }
}
