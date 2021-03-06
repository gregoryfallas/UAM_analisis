﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Adicionales;
using PL.Pantallas.Principales;
using DAL.Entidades;

namespace PL.Pantallas.Principales
{
    public partial class Frm_Inicio_PL : Form
    {
        public USUARIOS user;

        int EnviarFecha = 0;
        public Frm_Inicio_PL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
             {
            

        }

        private void ts_Facturacion_Click(object sender, EventArgs e)
        {
            Frm_Facturacion_PL Factura = new Frm_Facturacion_PL();        
           
           Factura.ShowDialog();

        }

        private void ts_Compras_Click(object sender, EventArgs e)
        {
             Frm_Compras_PL compras = new Frm_Compras_PL();
            compras.ShowDialog();

        }

        private void ts_Tesoreria_Click(object sender, EventArgs e)
        {
           
            Frm_Tesoreria_PL tesoreria = new Frm_Tesoreria_PL();
            tesoreria.ShowDialog();

        }

        private void btnmarcar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Adicionales.Form_Marcar_PL logueo = new Adicionales.Form_Marcar_PL();
            logueo.user = user;
            logueo.ShowDialog();
        }

        private void ts_Personal_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Adicionales.Form_Menu_Personal Creacion_Personal = new Adicionales.Form_Menu_Personal();
            Creacion_Personal.ShowDialog();
        }

        private void ts_Reclutamiento_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Adicionales.Form_Menu_Reclutamiento reclutamiento = new Adicionales.Form_Menu_Reclutamiento();
            reclutamiento.ShowDialog();
        }

        private void ts_Nomina_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Adicionales.Form_Pago_Nomina marcas = new Adicionales.Form_Pago_Nomina();
            marcas.ShowDialog();
        }

        private void ts_Vacaciones_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Adicionales.Form_Vacaciones_PL vacaciones = new Adicionales.Form_Vacaciones_PL();
            vacaciones.ShowDialog();
        }

        private void ts_Promociones_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Frm_Promociones_PL Promociones = new Frm_Promociones_PL();
            Promociones.ShowDialog();
        }

        private void ts_Campañas_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Frm_Campañas_PL Campañas = new Frm_Campañas_PL();
            Campañas.ShowDialog();
        }

        private void ts_Anuncios_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Frm_Anuncios_Pl Anuncios = new Frm_Anuncios_Pl();
            Anuncios.ShowDialog();
        }

        

        private void ts_Control_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Frm_Control_Suministros_PL ControlSuministros = new Frm_Control_Suministros_PL();
            ControlSuministros.ShowDialog();
           
        }

        private void ts_Ingreso_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Frm_Ingreso_Suministros_PL IngresoSuministros = new Frm_Ingreso_Suministros_PL();
            IngresoSuministros.ShowDialog();
        }

        private void ts_Despacho_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Frm_Despacho_Suministros_PL DespachoSuministros = new Frm_Despacho_Suministros_PL();
            DespachoSuministros.ShowDialog();
        }

        private void ts_Cirugias_Click(object sender, EventArgs e)
        {
            Frm_Cirujias_PL Cirujias = new Frm_Cirujias_PL();
            Cirujias.ShowDialog();
        }

        private void ts_Preconsulta_Click(object sender, EventArgs e)
        {
                       Frm_Preconsulta_PL Preconsulta = new Frm_Preconsulta_PL();
            Preconsulta.ShowDialog();
        }

        private void ts_Consulta_Click(object sender, EventArgs e)
        {
           
            Frm_Consulta_PL Consulta = new Frm_Consulta_PL();
            Consulta.ShowDialog();
        }

        private void ts_Express_Click(object sender, EventArgs e)
        {
            
        }

        private void ts_Domicilio_Click(object sender, EventArgs e)
        {
                    }

        private void ts_Cliente_Click(object sender, EventArgs e)
        {
          
            Frm_Clientes_PL Clientes = new Frm_Clientes_PL();
            Clientes.ShowDialog();
        }

        private void ts_Cita_Click(object sender, EventArgs e)
        {
         
            Frm_Citas_PL Citas = new Frm_Citas_PL();
            Citas.ShowDialog();
        }

        private void ts_Animal_Click(object sender, EventArgs e)
        {
           Frm_Animal_PL Animal = new Frm_Animal_PL();
            Animal.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (EnviarFecha)
            {
                case 0: CapturarFechaSistema(); break;
            }
        }

        private void CapturarFechaSistema()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void Frm_Inicio_PL_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void ts_Servicios_Click(object sender, EventArgs e)
        {
            Frm_Laboratorio_PL Laboratorio = new Frm_Laboratorio_PL();
            Laboratorio.ShowDialog();
        }

        private void apropacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aprovacion aprov = new Aprovacion();
            aprov.ShowDialog();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
