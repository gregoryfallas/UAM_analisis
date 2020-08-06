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
        private string id_Provincia;
        private string id_Estado;

        public Frm_Clientes_PL()
        {
            InitializeComponent();
            
           
        }


        private void CargarCombosEstados()
        {
            List<ESTADOS> lstresultado = Clientes_BLL.ConsultaEstadosCliente();

            this.estadoClientecbo.DataSource = lstresultado;
            estadoClientecbo.ValueMember = "ID_Estados";
            estadoClientecbo.DisplayMember = "Nombre";
            estadoClientecbo.Refresh();
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
            Clientes_BLL c = new Clientes_BLL();
            try
            {
              
                

                List<CLIENTES> lstusuarios = Clientes_BLL.ConsultarClientesPantallaCliente(this.textBox6.Text.Trim());


                DataTable dt = new DataTable();


                dt.Columns.Add("ID");
                dt.Columns.Add("Cedula");
                dt.Columns.Add("Nombre");
                dt.Columns.Add("Primer_Apellido");
                dt.Columns.Add("Segundo_Apellido");
                dt.Columns.Add("Correo");
                dt.Columns.Add("Telefono");
                dt.Columns.Add("Id Provincia");
                dt.Columns.Add("Id Canton");
                dt.Columns.Add("Id Distrito");
                dt.Columns.Add("Direccion");
                dt.Columns.Add("Credito");
                dt.Columns.Add("Estado");
                foreach (CLIENTES item in lstusuarios)
                {
                    dt.Rows.Add
                        (
                        item.ID_Cliente,
                        item.Cedula,
                        item.Nombre,
                        item.Apellido_1,
                        item.Apellido_2,
                        item.Correo,
                        item.Telefono,
                        item.ID_Provincias,
                        item.ID_Cantones,
                        item.ID_Distritos,
                        item.Direccion,
                        item.Credito,
                        item.Estado
                        );
                }


                this.dataGridView1.DataSource = null;
                this.dataGridView1.Refresh();
                this.dataGridView1.DataSource = dt;
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


        private void CargarComboCredito()
        {

               List<string> lista = new List<string>();
               lista.Add("Si");
               lista.Add("No");
               comboBox1.DataSource = lista;
         //    Distritocbo.ValueMember = "ID_Distritos";
         //    Distritocbo.DisplayMember = "Nombre";
         //    Distritocbo.Refresh();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Frm_Inicio_PL inicio = new Frm_Inicio_PL();
            inicio.ShowDialog();
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
          //  id_Provincia = Cantoncbo.SelectedValue.ToString();

            //    textBox1.Text = provincia_id.ToString();
            CargarCombosCantones();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Cantoncbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.canton_id  = Convert.ToInt32(Cantoncbo.SelectedIndex) + 1;
            id_Canton = Cantoncbo.SelectedValue.ToString();

           

            // id_Canton = Convert.ToInt32(Cantoncbo.SelectedValue.ToString());

            CargarCombosDistritos();
        }

        private void estadoClientecbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            estado = Convert.ToInt32(this.estadoClientecbo.SelectedIndex) ;
            //textBox7.Text = estadoClientecbo.SelectedValue.ToString();
            id_Estado=estadoClientecbo.SelectedValue.ToString();


        }



        private void Frm_Clientes_PL_Load(object sender, EventArgs e)
        {
            CargarCombosEstados();
            CargarCombosProvincias();
            cargarGridUsuarios();
            CargarComboCredito();


        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            bool c ;
            CLIENTES cliente = new CLIENTES();
            cliente.Cedula = textBox2.Text.Trim();
            cliente.Nombre = textBox1.Text.Trim();
            cliente.Apellido_1 = Apellido1txt.Text.Trim();
            cliente.Apellido_2 = textBox7.Text.Trim();
            cliente.Correo = textBox5.Text.Trim();
            cliente.Telefono = textBox3.Text.Trim();
            cliente.ID_Provincias = provincia_id;
            cliente.ID_Cantones = Convert.ToInt32(id_Canton);
            cliente.ID_Distritos = Convert.ToInt32(id_Distritos);
            cliente.Direccion = textBox4.Text;
            // cliente.Credito = false;
            if (credito.ToString().Equals("Si"))
                c = true;
            else
                c = false;
            cliente.Credito = c;
            cliente.Estado = Convert.ToInt32(id_Estado);
            Clientes_BLL.agregarCliente(cliente);
            MessageBox.Show("Cliente Agregado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarGridUsuarios();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            credito = comboBox1.SelectedValue.ToString();

           
        }

        private void Distritocbo_SelectedIndexChanged(object sender, EventArgs e)
        {

            // distrito_id = Convert.ToInt32(Distritocbo.SelectedIndex) + 1;
            id_Distritos=Distritocbo.SelectedValue.ToString();
            // textBox7.Text = Distritocbo.SelectedValue.ToString();
            // id_Distritos = Convert.ToInt32(Distritocbo.SelectedValue.ToString());
        }
    }
}
