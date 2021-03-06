﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Principales;
using PL.Pantallas.Extras;
using DAL.Entidades;
using BLL;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Animal_PL : Form
    {

        private int idTipoAnimal = 0;
        private int idCliente = 0;
        private int idMascota = 0;

        private int estadoInicial = 29;

        private string sexo;



        public Frm_Animal_PL()
        {
            InitializeComponent();
            CargarCombos();
            // SexoMascota();
        }

        private void CargarCombos()
        {
            List<TIPO_ANIMAL> lstresultado = Mascota_BLL.ConsultaTipoAnimal();

            this.comboBox1.DataSource = lstresultado;
            comboBox1.ValueMember = "ID_Tipo_Animal";
            comboBox1.DisplayMember = "Tipo";
            comboBox1.Refresh();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void mascotalbl_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AgregarUsuario_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CedulaClienteBusquedabtn_TextChanged(object sender, EventArgs e)
        {

        }


        private void cargarGridMascotas() {
            try
            {


                this.dataGridView1.DataSource = null;
                this.dataGridView1.Refresh();
              

                this.dataGridView1.DataSource = Mascota_BLL.ConsultarMascota(this.buscarAnimaltxt.Text.Trim());
                this.dataGridView1.Refresh();

                //List<MASCOTAS> lstusuarios = Mascota_BLL.ConsultarMascota(this.buscarAnimaltxt.Text.Trim());


                //DataTable dt = new DataTable();


                //dt.Columns.Add("ID");
                //dt.Columns.Add("ID CLIENTEa");
                //dt.Columns.Add("Nombre");
                //dt.Columns.Add("TIPO");
                //dt.Columns.Add("RAZA");
                //dt.Columns.Add("SEXO");
                //foreach (MASCOTAS item in lstusuarios)
                //{
                //    dt.Rows.Add
                //        (
                //        item.ID_Mascota,
                //        item.ID_Cliente,
                //        item.Nombre,
                //        item.Tipo_Animal,
                //        item.Raza,
                //        item.Sexo
                //        );
                //}
                //this.dataGridView1.DataSource = null;
                //this.dataGridView1.Refresh();
                //this.dataGridView1.DataSource = dt;
                //this.dataGridView1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }




        }


        private void cargarGridClientes()
        {
            try
            {
                List<CLIENTES> lstusuarios = Clientes_BLL.ConsultarClientes(CedulaClienteBusquedabtn.Text);


                DataTable dt = new DataTable();



                dt.Columns.Add("ID CLIENTES");
                dt.Columns.Add("CEDULA");
                dt.Columns.Add("Nombre");
                // dt.Columns.Add("RAZA");
                //dt.Columns.Add("SEXO");
                foreach (CLIENTES item in lstusuarios)
                {
                    dt.Rows.Add
                        (
                        item.ID_Cliente,
                        item.Cedula,
                        item.Nombre
                        //item.Raza,
                        //item.Sexo
                        );
                }
                this.dataGridView2.DataSource = null;
                this.dataGridView2.Refresh();
                this.dataGridView2.DataSource = dt;
                this.dataGridView2.Refresh();
            }
            catch (Exception)
            {

                throw;
            }




        }


        private void SexoMascota()
        {
            if (radioButton1.Checked)
                sexo = "Hembra";
            else if (radioButton2.Checked)
                sexo = "Macho";

        }







        private void AgregarTipoMascotabtn_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarAnimalbtn_Click(object sender, EventArgs e)
        {

            this.cargarGridMascotas();
          

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // animaltxt.Text = comboBox1.SelectedIndex;
            idTipoAnimal = comboBox1.SelectedIndex + 1;
            // animaltxt.Text = idTipoAnimal.ToString();
        }









        private void buscarClientebtn_Click(object sender, EventArgs e)
        {

            cargarGridClientes();

            //Clientes_BLL c = new Clientes_BLL();
            //try
            //{



            //    List<CLIENTES> lstusuarios = Clientes_BLL.ConsultarClientesPantallaCliente(this.CedulaClienteBusquedabtn.Text.Trim());


            //    DataTable dt = new DataTable();


            //    dt.Columns.Add("ID");
            //    dt.Columns.Add("Cedula");
            //    dt.Columns.Add("Nombre");
            //    foreach (CLIENTES item in lstusuarios)
            //    {
            //        dt.Rows.Add
            //            (
            //            item.ID_Cliente,
            //            item.Cedula,
            //            item.Nombre

            //            );
            //    }


            //    this.dataGridView2.DataSource = null;
            //    this.dataGridView2.Refresh();
            //    this.dataGridView2.DataSource = dt;
            //    this.dataGridView2.Refresh();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}


        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            razaAnimaltxt.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox1.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            idCliente = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
        }


        private void limpiarDatos()
        {

            animaltxt.Text = string.Empty; ;
            tipoAnimaltxt.Text = string.Empty;
            razaAnimaltxt.Text = string.Empty;
            textBox1.Text = string.Empty;
            CargarCombos();

        }


        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            MASCOTAS mascota = new MASCOTAS();
            mascota.ID_Cliente = idCliente;
            mascota.Nombre = animaltxt.Text;
            mascota.Tipo_Animal = idTipoAnimal;
            mascota.Raza = tipoAnimaltxt.Text;
            SexoMascota();
            mascota.Sexo = sexo;
            mascota.Estado = estadoInicial;

            Mascota_BLL.agregarMascota(mascota);

            MessageBox.Show("Mascota Agregada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarDatos();
            // cargarGridUsuarios();


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Mascota_BLL.eliminarMascota(idMascota);
                MessageBox.Show("Mascota eliminado");
                cargarGridMascotas();
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMascota = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            animaltxt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tipoAnimaltxt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(); 

        }
    }
}
