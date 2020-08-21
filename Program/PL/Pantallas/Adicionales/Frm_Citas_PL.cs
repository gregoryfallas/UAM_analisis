using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL.Pantallas.Principales;
using DAL;
using DAL.Entidades;
using BLL;
namespace PL.Pantallas.Adicionales
{
    public partial class Frm_Citas_PL : Form
    {
        Citas_BLL objCitas_Bll;
        List<DateTime> hours = new List<DateTime>();
        List<CITAS> Citas_DAL;
        List<MOTIVO_CITA> Motivo_Dal;
        List<CONSULTORIO> Consultorio_Dal;
        List<DateTime> Lhoras = new List<DateTime>();

        public Frm_Citas_PL()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModificarCitabtn_Click(object sender, EventArgs e)
        {

        }

        private void buscarClientebtn_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Citas_PL_Load(object sender, EventArgs e)
        {
            objCitas_Bll = new Citas_BLL();
            Citas_DAL = new List<CITAS>();
            Motivo_Dal = new List<MOTIVO_CITA>();
            Consultorio_Dal = new List<CONSULTORIO>();

            LoadHoras();
            objCitas_Bll.load_hours(ref hours);
            Motivo_Dal = objCitas_Bll.loadmotivos();
            Consultorio_Dal = objCitas_Bll.load_consultorios();
            Citas_DAL = objCitas_Bll.load_citas();

            foreach (var item in Motivo_Dal)
            {
                cbx_Motivo.Items.Add(item.Nombre);
            }
            foreach (var item in Consultorio_Dal)
            {
                cbx_Consultorio.Items.Add(item.Nombre);
            }

            foreach (var item in Lhoras)
            {
                cbx_HoraIn.Items.Add(item.ToShortTimeString());
                cbx_HoraFin.Items.Add(item.ToShortTimeString());
            }
            
            load_monthCalendar();
            load_dgvCitas();
        }

        private void load_monthCalendar()
        {
            CITAS fecha_citas = new CITAS();
            DateTime[] dates = new DateTime[Citas_DAL.Count];
            for (int i = 0; i < dates.Length ;i++ )
            {
                fecha_citas = Citas_DAL[i];

                dates[i] = fecha_citas.Fecha_Inicio;
            }
            monthCalendar1.BoldedDates = dates;
        }

        private void load_dgvCitas()
        {
            dgv_Citas1.Columns.Add("0", "ID Cita");
            dgv_Citas1.Columns.Add("1", "ID Mascota");
            dgv_Citas1.Columns.Add("2", "Nombre Mascota");
            dgv_Citas1.Columns.Add("3", "ID Consultorio");
            dgv_Citas1.Columns.Add("4", "ID Motivo");
            dgv_Citas1.Columns.Add("5", "Motivo");
            dgv_Citas1.Columns.Add("6", "Fecha Inicio");
            dgv_Citas1.Columns.Add("7", "Hora Inicio");
            dgv_Citas1.Columns.Add("8", "Hora Fin");
            dgv_Citas1.Columns.Add("9", "ID Estado");
            dgv_Citas1.Columns.Add("10", "Estado");
            dgv_Citas1.Columns.Add("11", "Nombre");
        }

        private void load_Citas(DateTime date)
        {
            int count = 1;
            foreach (var item in Citas_DAL)
            {
                if (item.Fecha_Inicio.Date == date.Date){
                    DataGridViewRow row = (DataGridViewRow)dgv_Citas1.Rows[count].Clone();
                    row.Cells[0].Value = item.ID_Cita.ToString();
                    row.Cells[1].Value = item.ID_Mascota.ToString();
                    row.Cells[2].Value = item.Nombre_Mascota.ToString();
                    row.Cells[3].Value = item.ID_Consultorio.ToString();
                    row.Cells[4].Value = item.ID_Motivo_Cita.ToString();
                    row.Cells[5].Value = item.Motivo_Cita.ToString();
                    row.Cells[6].Value = item.Fecha_Inicio.ToString();
                    row.Cells[7].Value = item.Hora_Inicio.ToString();
                    row.Cells[8].Value = item.Hora_Fin.ToString();
                    row.Cells[9].Value = item.ID_Estado.ToString();
                    row.Cells[10].Value = item.Estado.ToString();
                    row.Cells[11].Value = item.Nombre.ToString();
                    if (item.ID_Estado != 35 || item.ID_Estado != 17)
                    {
                        dgv_Citas1.Rows.Add(row);
                    }
                }
                count++;
            }
        }
        

        public List<DateTime> LoadHoras()
        {
            DateTime date_horas = new DateTime(2020,01,01,07, 0, 0);

            do
            {
                Lhoras.Add(date_horas);
                date_horas = date_horas.AddMinutes(30);


            } while (date_horas.Hour < 17);
            return Lhoras;
        }

        private void chb_MostrarCitasCliente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_Activar_Cita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objCitas_Bll = new Citas_BLL();
            CITAS cita = new CITAS();
            cita.ID_Cita = Convert.ToInt32(dgv_Citas1.SelectedRows[0].Cells[0].ToString());
            cita.ID_Estado = 2;
            bool a = Citas_BLL.modificarEstadoCitas(cita);
        }

        private void labal_Cancelar_Cita_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            objCitas_Bll = new Citas_BLL();
            CITAS cita = new CITAS();
            cita.ID_Cita = Convert.ToInt32(dgv_Citas1.SelectedRows[0].Cells[0].ToString());
            cita.ID_Estado = 35;
            bool a = Citas_BLL.modificarEstadoCitas(cita);
        }

        private void reprogramarCitabtn_Click(object sender, EventArgs e)
        {

        }
    }
}
