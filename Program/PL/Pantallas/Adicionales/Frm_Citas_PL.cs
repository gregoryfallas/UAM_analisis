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

            objCitas_Bll.load_hours(ref hours);
            Motivo_Dal = objCitas_Bll.loadmotivos();
            Consultorio_Dal = objCitas_Bll.load_consultorios();
            Citas_DAL = objCitas_Bll.load_citas();

            cbx_Motivo.DataSource = Motivo_Dal;
            cbx_Consultorio.DataSource = Consultorio_Dal;
            load_monthCalendar();




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
            dgv_Citas1.Columns.Add("0","");
            foreach (var item in Consultorio_Dal)
            {
                dgv_Citas1.Columns.Add(item.ID_Consultorio.ToString(), item.Nombre.ToString());
            }

            for (int i = 1; i< hours.Count-1; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dgv_Citas1.Rows[i].Clone();
                row.Cells[1].Value = hours[i] + " - " + hours[i+1];
                dgv_Citas1.Rows.Add(row);
            }
        }

        private void load_Citas(DateTime date)
        {
            foreach (var item in Citas_DAL)
            {
                if (item.Fecha_Inicio.Date == date.Date){
                    for(int i = 0; i < hours.Count -1; i++)
                    if (item.Hora_Inicio.ToString(@"hh\:mm") == (hours[i].Hour + ":" + hours[i].Minute))
                    {
                        DataGridViewRow row = (DataGridViewRow)dgv_Citas1.Rows[i].Clone();
                    }
                }
            }
        }
    }
}
