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
using BLL;
using PL.Pantallas.Adicionales;




namespace PL.Pantallas.Extras
{
    public partial class Frm_Cajas_PL : Form
    {
        DA Obj_Dal = new DA();
        Articulos_BLL Obj_BLL = new Articulos_BLL();        
        CAJAS Cajas = new CAJAS();
        

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
            
            Obj_Dal.IPrueba = 1;

            Obj_BLL.Cajas(ref Obj_Dal);

            MetodoCajas();            
            
        }

        private void btn_CerrarCaja_Click(object sender, EventArgs e)
        {
                       
            Obj_Dal.IPrueba = 0;

            Obj_BLL.Cajas(ref Obj_Dal);

            MetodoCajas();
            
        }






        private void Frm_Cajas_PL_Load(object sender, EventArgs e)
        {
            
            CAJAS CAJITA = new CAJAS();
            List<CAJAS> resultado = new List<CAJAS>();
            resultado= Articulos_BLL.ConsultarCajas(1);

            foreach (var li in resultado) {
                CAJITA.ID_Caja = li.ID_Caja;
                CAJITA.Estado = li.Estado;
            }


            if (CAJITA.Estado==22)
            {
                btn_AbrirCaja.Enabled = true;
                btn_CerrarCaja.Enabled = false;
            }
            else
            {
                btn_AbrirCaja.Enabled = false;
                btn_CerrarCaja.Enabled = true;
            }

        }



        public void MetodoCajas()
        {
                        

            Obj_BLL.Cajas(ref Obj_Dal);

            if (Obj_Dal.ITemporal== 1)
            {
                if (MessageBox.Show("¿Desea abrir Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Caja abierta con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    btn_CerrarCaja.Enabled = true;
                    btn_AbrirCaja.Enabled = false;

                    Articulos_BLL.ModificarCajas(1, 38);
                    
                }   
            }
            else
            {
                if (MessageBox.Show("¿Desea Cerrar Caja?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    MessageBox.Show("Caja cerrada con Exito ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    MessageBox.Show("El total de las ventas fue por: ");

                    btn_CerrarCaja.Enabled = false;
                    btn_AbrirCaja.Enabled = true;                    
                    Obj_Dal.IPrueba = Obj_Dal.ITemporal;

                    Articulos_BLL.ModificarCajas(1, 22);
                   
                }
            }


        }




    }
    }

