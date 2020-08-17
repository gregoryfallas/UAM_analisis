using System;
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

        //variables para el DataGrid
        public static string ID_Participantes;
        public static string ID_Reclutamiento;
        public static string Cedula_;
        public static string Nombre;
        public static string Apellido_1;
        public static string Apellido_2;
        public static string Correo;
        public static string Telefono;
        public static string ID_Provincia;
        public static string ID_Canton;
        public static string ID_Distrito;
        public static string Direccion;
        public static string Estado;


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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<PARTICIPANTES> Istclientes = R_Humanos.Obtener_Participantes();

                this.dgvparticipantes.DataSource = Istclientes;
                this.dgvparticipantes.Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvparticipantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID_Participantes = dgvparticipantes.Rows[e.RowIndex].Cells["ID_Participantes"].Value.ToString();
            ID_Reclutamiento = dgvparticipantes.Rows[e.RowIndex].Cells["ID_Reclutamiento"].Value.ToString();
            Cedula_ = dgvparticipantes.Rows[e.RowIndex].Cells["Cedula_"].Value.ToString();
            Nombre = dgvparticipantes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            Apellido_1 = dgvparticipantes.Rows[e.RowIndex].Cells["Apellido_1"].Value.ToString();
            Apellido_2 = dgvparticipantes.Rows[e.RowIndex].Cells["Apellido_2"].Value.ToString();
            Correo = dgvparticipantes.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
            Telefono = dgvparticipantes.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            ID_Provincia = dgvparticipantes.Rows[e.RowIndex].Cells["ID_Provincia"].Value.ToString();
            ID_Canton = dgvparticipantes.Rows[e.RowIndex].Cells["ID_Canton"].Value.ToString();
            ID_Distrito = dgvparticipantes.Rows[e.RowIndex].Cells["ID_Distrito"].Value.ToString();
            Direccion = dgvparticipantes.Rows[e.RowIndex].Cells["Direccion"].Value.ToString();
            Estado = dgvparticipantes.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (ID_Reclutamiento == "")
                MessageBox.Show("Seleccione una fila a editar", "Atecion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                cboreclutamiento.Text = ID_Participantes;
                cboreclutamiento.Text = ID_Reclutamiento;
                txtcedula.Text = Cedula_;
                txtnombre.Text = Nombre;
                txtapellido1.Text = Apellido_1;
                txtapellido2.Text = Apellido_2;
                txtcorreo.Text = Correo;
                txttelefono.Text = Telefono;
                Provinciacbo.Text = ID_Provincia;
                Cantoncbo.Text = ID_Canton;
                Distritocbo.Text = ID_Distrito;
                txtdireccion.Text = Direccion;
                cboestado.Text = Estado;
            }
        }
    }
}
