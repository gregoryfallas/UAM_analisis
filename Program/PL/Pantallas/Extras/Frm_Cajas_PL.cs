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
            
            this.Hide();
            
        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
                      
                
                if (MessageBox.Show("¿Desea abrir Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_DAL.iPrueba = 1;
                    MessageBox.Show("Caja abierta con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                btn_AbrirCaja.Enabled = false;
                btn_CerrarCaja.Enabled = true;
               
                
            }
                else
                {
                   Obj_DAL.iPrueba = 2;
                }
                          
            


           
        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("¿Desea cerrar Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Obj_DAL.iPrueba = 2;

                    MessageBox.Show("Caja cerrada con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    MessageBox.Show("El total de las ventas fue por: ");

                btn_CerrarCaja.Enabled = false;
                btn_AbrirCaja.Enabled = true;
               

            }
                else
                {
                    Obj_DAL.iPrueba = 1;
                }
            }

        private void Frm_Cajas_PL_Load(object sender, EventArgs e)
        {
            btn_CerrarCaja.Enabled = false;
        }
    }
    }

