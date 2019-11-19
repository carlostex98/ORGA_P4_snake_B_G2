using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            this.Hide();
            reg.Show();
        }
        public void limpiar() {
            txtUser.Text = "";
            txtContra.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text==""||txtContra.Text=="")
            {
                MessageBox.Show("Hay campos vacios");
                limpiar();
            }
            else {
                if (Manejador.getInstancia().login(txtUser.Text, txtContra.Text))
                {
                    MessageBox.Show("Bienvenido " + txtUser.Text);
                    Manejador.getInstancia().setUsuario(Manejador.getInstancia().buscarUsuario(txtUser.Text));
                    Informacion informacion = new Informacion();
                    this.Hide();
                    limpiar();
                    informacion.Show();
                }
                else if (txtUser.Text == "Admin_ORGA" && txtContra.Text == "12345")
                {
                    MessageBox.Show("Bienvenido Admin_ORGA");
                    Administrador administrador = new Administrador();
                    limpiar();
                    administrador.Show();
                    this.Hide();
                }
                else
                {
                    limpiar();
                    MessageBox.Show("Datos Erroneos");
                }
            }
        }
    }
}
