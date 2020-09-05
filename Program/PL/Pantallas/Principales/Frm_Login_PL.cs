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
using BLL;
using DAL.Entidades;

namespace PL.Pantallas.Principales
{
    public partial class Frm_Login_PL : Form
    {
        public Frm_Login_PL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_BLL login = new Login_BLL();
            List<USUARIOS> list = login.ConsultaUsuarios();
            
            //do
            //{
                if (string.IsNullOrEmpty(textBox1.Text.ToString().Trim()) || string.IsNullOrEmpty(textBox2.Text.ToString().Trim())){
                    MessageBox.Show("Debe llenar los campos de usuario y contraseña", "Campos vacios");
                }
                else
                {
                    USUARIOS user = login.Validar_Usuario(ref list, textBox1.Text.ToString().Trim(), textBox2.Text.ToString().Trim());
                    if (user != null)
                    {
                       
                        Frm_Inicio_PL inicio = new Frm_Inicio_PL();
                        inicio.user = user;
                        this.Hide();
                        inicio.ShowDialog();
                    this.Close();
                }
                    else
                    {
                         MessageBox.Show("Usuario o contraseña incorrectos", "Login Fallido");
                    }
                }
           // } while (a);

            
        }
    }
}
