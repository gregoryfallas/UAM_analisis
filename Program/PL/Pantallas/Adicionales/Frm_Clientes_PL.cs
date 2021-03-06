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
using BLL;
using DAL.Entidades;

namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Clientes_PL : Form
    {

        private int estado = 0;
        private int provincia_id = 0;
        private int canton_id = 0;
        private string credito;


        //values
        private string id_Distritos;
        private string id_Canton;
       
        private string provincia;
        private string canton;
        private string distrito;
        private string id_Estado;
        private string est;
        private string ced;


        public Frm_Clientes_PL()
        {
            InitializeComponent();
            
           
        }
        
        private void CargarCombosProvincias()
        {
           
            List<PROVINCIAS> lstresultado = Clientes_BLL.ConsultaProvincia();
            this.Provinciacbo.DataSource = lstresultado;
            Provinciacbo.ValueMember = "ID_Provincias";
            Provinciacbo.DisplayMember = "Nombre";
            Provinciacbo.Refresh();
            CargarCombosCantones();
         

        }

        private void CargarCombosCantones()
        {
            
            List<CANTONES> lstresultado = Clientes_BLL.ConsultaCantones(provincia_id);
            this.Cantoncbo.DataSource = lstresultado;
            Cantoncbo.ValueMember = "ID_Cantones";
            Cantoncbo.DisplayMember = "Nombre";
            Cantoncbo.Refresh();
            CargarCombosDistritos();
        }

       

            private void cargarGridUsuarios()
                {
            
            try
            {
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Refresh();
               this.dataGridView1.DataSource = Clientes_BLL.ConsultarClientesPantallaCliente(this.textBox6.Text.Trim());
             this.dataGridView1.Refresh();

            }
            catch (Exception)
            {

                throw;
            }



        }

        
        private void CargarCombosDistritos()
        {

            List<DISTRITOS> lstresultado = Clientes_BLL.ConsultaDistritos(canton_id);
            this.Distritocbo.DataSource = lstresultado;
            Distritocbo.ValueMember = "ID_Distritos";
            Distritocbo.DisplayMember = "Nombre";
            Distritocbo.Refresh();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buscarClientebtn_Click(object sender, EventArgs e)
        {
            cargarGridUsuarios();
        }

        private void Provinciacbo_SelectedIndexChanged(object sender, EventArgs e)
        {
             this.provincia_id = Convert.ToInt32(Provinciacbo.SelectedIndex)+1;
             CargarCombosCantones();
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cantoncbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Canton = Cantoncbo.SelectedValue.ToString();
            string nombreCanton= Cantoncbo.Text;
            List<CANTONES> ls = Clientes_BLL.ConsultarCanton(nombreCanton);
            CANTONES c = new CANTONES();
            foreach (CANTONES item in ls)
            {
                c.ID_Cantones = item.ID_Cantones;
                
            }

            canton_id = c.ID_Cantones;
            CargarCombosDistritos();
        }

     
        private void Frm_Clientes_PL_Load(object sender, EventArgs e)
        {
            CargarCombosProvincias();
            cargarGridUsuarios();
         
        }

        

        private void Distritocbo_SelectedIndexChanged(object sender, EventArgs e)
        {

            id_Distritos=Distritocbo.SelectedValue.ToString();
          
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            bool c;

            CLIENTES cliente = new CLIENTES();

            cliente.Cedula = textBox2.Text.Trim();
            cliente.Nombre = textBox1.Text.Trim();
            cliente.Apellido_1 = Apellido1txt.Text.Trim();
            cliente.Apellido_2 = textBox7.Text.Trim();
            cliente.Correo = textBox5.Text.Trim();
            cliente.Telefono = textBox3.Text.Trim();
            cliente.ID_Provincias = provincia_id;
            cliente.ID_Cantones = canton_id;
            cliente.ID_Distritos = Convert.ToInt32(id_Distritos);
            cliente.Direccion = textBox4.Text.ToString();
         
            cliente.Estado = 5;
           
            Clientes_BLL.agregarCliente(cliente);
            MessageBox.Show("Cliente Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCampos();
            cargarGridUsuarios();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                CLIENTES cliente = new CLIENTES();
                cliente.Cedula = textBox2.Text.Trim();
                cliente.Nombre = textBox1.Text.Trim();
                cliente.Apellido_1 = Apellido1txt.Text.Trim();
                cliente.Apellido_2 = textBox7.Text.Trim();
                cliente.Correo = textBox5.Text.Trim();
                cliente.Telefono = textBox3.Text.Trim();
                cliente.ID_Provincias = provincia_id;
                cliente.ID_Cantones = canton_id;
                cliente.ID_Distritos = Convert.ToInt32(id_Distritos);
                cliente.Direccion = textBox4.Text;
                Clientes_BLL.modificarCliente(cliente);
                MessageBox.Show("Cliente Modificado","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimpiarCampos();
                cargarGridUsuarios();


            }
            catch (Exception)
            {

                throw;
            }


        }
        

        private void LimpiarCampos() {

            textBox2.Text=string.Empty;
            textBox1.Text=string.Empty;
            Apellido1txt.Text= string.Empty;
            textBox7.Text= string.Empty;
            textBox5.Text= string.Empty;
            textBox3.Text= string.Empty;
            textBox4.Text= string.Empty;
        }
             

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show("Hizo click en una fila no permitida", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //nombre
                textBox1.Text= dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                //ape1
                Apellido1txt.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                //ape2
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                //cedula
                textBox2.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                ced = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                //tel
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                //correo
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
               

               provincia= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
               Provinciacbo.Text = provincia;
               canton = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
               Cantoncbo.Text = canton;
               distrito = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
               Distritocbo.Text = distrito;

                //DIRECCION
                textBox4.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
                
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                Clientes_BLL.eliminarCliente(ced);
                MessageBox.Show("Usuario eliminado");
                cargarGridUsuarios();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cantoncbo_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
