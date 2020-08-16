using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Principales;
using BLL;
using DAL.Entidades;

namespace PL.Pantallas.Adicionales
{
    
    public partial class Frm_Preconsulta_PL : Form
    {


        private int idMascota = 0;
        private int estado = 0;
        private int idCita = 0;

        private string id_estado ;


        public Frm_Preconsulta_PL()
        {
            InitializeComponent();
            cargarCitaEnCurso();
            cargarComboEstados();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
        }


        private void cargarCitaEnCurso() {

            this.dataGridView1.DataSource = null;
            this.dataGridView1.Refresh();

            this.dataGridView1.DataSource = PreConsulta_BLL.consultarCitaEnCursoPantalla();
            
            this.dataGridView1.Refresh();

        }


        private void AgregarMascota_Click(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }




        private void AgregarRecetabtn_Click(object sender, EventArgs e)
        {
            
            //modificar Mascota
            MASCOTAS mascota = new MASCOTAS();
            mascota.ID_Mascota = idMascota;
            mascota.Tamaño = Convert.ToDecimal(tamaniotxt.Text, System.Globalization.CultureInfo.InvariantCulture);
            mascota.Estado = Convert.ToInt32(id_estado);

            mascota.Edad=Convert.ToInt32(edadtxt.Text);

            mascota.Peso= Convert.ToDecimal(pesotxt.Text, System.Globalization.CultureInfo.InvariantCulture);
//            mascota.Estado = Convert.ToInt32(id_estado);


            PreConsulta_BLL.ModificarMascotaPreConsulta(mascota);

            //Agregar observaciones a la cita 
            OBSERVACIONES observaciones = new OBSERVACIONES();
            observaciones.ID_Cita = idCita;
            observaciones.Descripcion = observacionestxt.Text;
            PreConsulta_BLL.agregarObservaciones(observaciones);
            MessageBox.Show("Preconsulta agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCita= Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            idtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            idMascota=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
             nombretxt.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

        private void cargarComboEstados() {
            List<ESTADOS> lstresultado = PreConsulta_BLL.consultarEstadosMascota();
            this.comboBox1.DataSource = lstresultado;
            comboBox1.ValueMember = "ID_Estados";
            comboBox1.DisplayMember = "Nombre";
            comboBox1.Refresh();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            estado = Convert.ToInt32(this.comboBox1.SelectedIndex);
            //textBox7.Text = estadoClientecbo.SelectedValue.ToString();
            id_estado = comboBox1.SelectedValue.ToString();

        }
    }
}
