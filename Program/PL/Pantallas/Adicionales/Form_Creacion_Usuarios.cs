using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DAL.Entidades;
using DAL;
using System.Data.SqlClient;

namespace PL.Pantallas.Adicionales
{
    public partial class Form_Creacion_Usuarios : Form
    {

        private string cedula; 
        private string IdPersonal;
        private string EstadoUsuario;

        public Form_Creacion_Usuarios()
        {
            InitializeComponent();
            CargarCombosPersonal();
            CargarCombosEstado();
        }
        
        private void CargarCombosPersonal()
        {
            List<PERSONAL> lstresultado = R_Humanos.ConsultarIDPersonal();

            this.cbopersonal.DataSource = lstresultado;
            cbopersonal.ValueMember = "ID_Personal";
            cbopersonal.DisplayMember = "Cedula";
            cbopersonal.Refresh();
        }

        private void CargarCombosEstado()
        {
            List<ESTADOS> lstresultado = R_Humanos.ConsultarTipoEstadoUsuario();

            this.cboestado.DataSource = lstresultado;
            cboestado.ValueMember = "ID_Estados";
            cboestado.DisplayMember = "Nombre";
            cboestado.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adicionales.Form_Menu_Personal atras = new Adicionales.Form_Menu_Personal();
            atras.ShowDialog();
        }

        private void Form_Creacion_Usuarios_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void validarcampos()
        {
            var vr = !string.IsNullOrEmpty(cbopersonal.Text) &&
                !string.IsNullOrEmpty(txtusuario.Text) &&
                !string.IsNullOrEmpty(txtcontrasena.Text) &&
                !string.IsNullOrEmpty(cboestado.Text);
            button2.Enabled = vr;
            button3.Enabled = vr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIOS u = new USUARIOS();

                 u.ID_Personal = Convert.ToInt32(IdPersonal);
                 u.UserName = txtusuario.Text.Trim();
                 u.Pass = txtcontrasena.Text.Trim();
                 u.Estado = Convert.ToInt32(EstadoUsuario);
              
                R_Humanos.AgregarUsuario(u);
                MessageBox.Show("Usuario agregado correctamente");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbopersonal_SelectedValueChanged(object sender, EventArgs e)
        {
           // txtusuario.Text = cbopersonal.SelectedValue.ToString();
           IdPersonal = cbopersonal.SelectedValue.ToString();
        }

        private void cboestado_SelectedValueChanged(object sender, EventArgs e)
        {
            //txtusuario.Text = cboestado.SelectedValue.ToString();
            EstadoUsuario = cboestado.SelectedValue.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                USUARIOS u = new USUARIOS();

                u.ID_Personal = Convert.ToInt32(IdPersonal);
                u.UserName = txtusuario.Text.Trim();
                u.Pass = txtcontrasena.Text.Trim();
                u.Estado = Convert.ToInt32(EstadoUsuario);

                R_Humanos.ModificarUsuario(u);
                MessageBox.Show("Usuario Modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void consultarcedulapersonal()
        {

        }

        private void cbopersonal_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcampos();
            cedula = cbopersonal.SelectedText;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {
            validarcampos();
        }

        private void cboestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarcampos();
        }
    }
}
