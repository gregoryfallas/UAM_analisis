﻿using System;
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
    public partial class Form_Ingresar_Participantes : Form
    {
        public List<PARTICIPANTES> lstresultado { get; set; }
        public bool EsError { get; set; }

        private int estado = 0;
        private int provincia_id = 0;
        private int canton_id = 0;

        //values
        private string id_Distritos;
        private string id_Canton;
        private string id_Provincia;
        private string Nombre_Provincia;

        private string nombrepuesto;
        private string nombreEstado;

        public Form_Ingresar_Participantes()
        {
            lstresultado = new List<PARTICIPANTES>();
            InitializeComponent();
            CargarCombosEstados();
            CargarComboIdReclutamiento();
            CargarCombosProvincias();
            CargarCombosCantones();
            CargarCombosDistritos();
        }

        private void CargarCombosEstados()
        {
            List<ESTADOS> lstresultado = R_Humanos.ConsultarTipoEstadoPostulantes();

            this.cboestado.DataSource = lstresultado;
            cboestado.ValueMember = "ID_Estados";
            cboestado.DisplayMember = "Nombre";
            cboestado.Refresh();
        }

        private void CargarComboIdReclutamiento()
        {
            List<RECLUTAMIENTO> lstresultado = R_Humanos.ConsultarIDReclutamiento();

            this.cboreclutamiento.DataSource = lstresultado;
            cboreclutamiento.ValueMember = "ID_Reclutamiento";
            cboreclutamiento.DisplayMember = "Nombre";
            cboreclutamiento.Refresh();
        }

        private void CargarCombosProvincias()
        {

            List<PROVINCIAS> lstresultado = R_Humanos.ConsultaProvincia();

            this.Provinciacbo.DataSource = lstresultado;
            Provinciacbo.ValueMember = "ID_Provincias";
            Provinciacbo.DisplayMember = "Nombre";
            Provinciacbo.Refresh();
            CargarCombosCantones();


        }

        private void CargarCombosCantones()
        {

            List<CANTONES> lstresultado = R_Humanos.ConsultaCantones(provincia_id);
            this.Cantoncbo.DataSource = lstresultado;
            Cantoncbo.ValueMember = "ID_Cantones";
            Cantoncbo.DisplayMember = "Nombre";
            Cantoncbo.Refresh();
            CargarCombosDistritos();
        }

        private void CargarCombosDistritos()
        {

            List<DISTRITOS> lstresultado = R_Humanos.ConsultaDistritos(canton_id);
            this.Distritocbo.DataSource = lstresultado;
            Distritocbo.ValueMember = "ID_Distritos";
            Distritocbo.DisplayMember = "Nombre";
            Distritocbo.Refresh();
        }

        private void nombreProvincia(int id)
        {
            Nombre_Provincia = "a";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                PARTICIPANTES p = new PARTICIPANTES();

                p.ID_Reclutamiento = Convert.ToInt32(nombrepuesto);
                p.Cedula_ = txtcedula.Text.Trim();
                p.Nombre = txtnombre.Text.Trim();
                p.Apellido_1 = txtapellido1.Text.Trim();
                p.Apellido_2 = txtapellido2.Text.Trim();
                p.Correo = txtcorreo.Text.Trim();
                p.Telefono = txttelefono.Text.Trim();
                p.ID_Provincia = provincia_id;
                p.ID_Canton = canton_id;
                p.ID_Distrito = Convert.ToInt32(id_Distritos);
                p.Direccion = txtdireccion.Text.Trim();
                p.Estado = Convert.ToInt32(nombreEstado);

                R_Humanos.AgregarPostulantes(p);
                MessageBox.Show("Postulante agregado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Provinciacbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.provincia_id = Convert.ToInt32(Provinciacbo.SelectedIndex) + 1;
                       
            CargarCombosCantones();
        }

        private void Cantoncbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Canton = Cantoncbo.SelectedValue.ToString();
            string nombreCanton = Cantoncbo.Text;
            List<CANTONES> ls = R_Humanos.ConsultarCanton(nombreCanton);
            CANTONES c = new CANTONES();
            foreach (CANTONES item in ls)
            {
                c.ID_Cantones = item.ID_Cantones;

            }

            canton_id = c.ID_Cantones;
            CargarCombosDistritos();
        }

        private void Distritocbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_Distritos = Distritocbo.SelectedValue.ToString();
        }

        private void cboreclutamiento_SelectedValueChanged(object sender, EventArgs e)
        {
            nombrepuesto = cboreclutamiento.SelectedValue.ToString();
        }

        private void cboestado_SelectedValueChanged(object sender, EventArgs e)
        {
            nombreEstado = cboestado.SelectedValue.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                PARTICIPANTES p = new PARTICIPANTES();

                p.ID_Reclutamiento = Convert.ToInt32(nombrepuesto);
                p.Cedula_ = txtcedula.Text.Trim();
                p.Nombre = txtnombre.Text.Trim();
                p.Apellido_1 = txtapellido1.Text.Trim();
                p.Apellido_2 = txtapellido2.Text.Trim();
                p.Correo = txtcorreo.Text.Trim();
                p.Telefono = txttelefono.Text.Trim();
                p.ID_Provincia = provincia_id;
                p.ID_Canton = canton_id;
                p.ID_Distrito = Convert.ToInt32(id_Distritos);
                p.Direccion = txtdireccion.Text.Trim();
                p.Estado = Convert.ToInt32(nombreEstado);

                R_Humanos.ModificarPostulantes(p);
                MessageBox.Show("Postulante Modificado");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
