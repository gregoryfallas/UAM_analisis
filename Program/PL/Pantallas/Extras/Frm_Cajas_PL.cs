using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Entidades;
using DAL;




namespace PL.Pantallas.Extras
{
    public partial class Frm_Cajas_PL : Form
    {
        DA Obj_DAL = new DA();



        public Frm_Cajas_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {

            this.Close();
            
        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
           
          

            btn_AbrirCaja.Enabled = false;

            if (MessageBox.Show("¿Desea abrir Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                
                MessageBox.Show("Caja abierta con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

              
                btn_CerrarCaja.Enabled = true;


            }
            else
            {
                
            }

        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {

           
            btn_CerrarCaja.Enabled = false;

            if (MessageBox.Show("¿Desea Cerrar Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                MessageBox.Show("Caja cerrada con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                MessageBox.Show("El total de las ventas fue por: ");

                btn_CerrarCaja.Enabled = false;
                btn_AbrirCaja.Enabled = true;

            }
            else
            {
                
            }



        }






        private void Frm_Cajas_PL_Load(object sender, EventArgs e)
        {
           
            //if ()
            //{
            //    btn_CerrarCaja.Enabled = false;
            //    btn_AbrirCaja.Enabled = true;
            //}
            //else
            //{
            //    btn_CerrarCaja.Enabled = true;
            //    btn_AbrirCaja.Enabled = false;
            //}
            




            //if (Obj_DAL.iCaja == 0)
            //{
            //    if (MessageBox.Show("¿Desea abrir Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        Obj_DAL.iPrueba = 1;
            //        Obj_DAL.iCaja = 1;
            //        MessageBox.Show("Caja abierta con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //        btn_AbrirCaja.Enabled = false;
            //        btn_CerrarCaja.Enabled = true;


            //    }
            //    else
            //    {
            //        Obj_DAL.iPrueba = 0;
            //    }
            //}
            //else
            //{
            //    Obj_DAL.iCaja = 0;
            //}




            //if (Obj_DAL.iCaja == 1)
            //{
            //    if (MessageBox.Show("¿Desea cerrar Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        Obj_DAL.iPrueba = 0;
            //        Obj_DAL.iCaja = 0;

            //        MessageBox.Show("Caja cerrada con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //        MessageBox.Show("El total de las ventas fue por: ");

            //        btn_CerrarCaja.Enabled = false;
            //        btn_AbrirCaja.Enabled = true;


            //    }
            //    else
            //    {
            //        Obj_DAL.iPrueba = 1;
            //    }
            //}
            //else
            //{
            //    Obj_DAL.iCaja = 1;
            //}

            


        }
    }
    }

