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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        public void limpiar() {
            txtConfirmar.Text = "";
            txtContra.Text = "";
            txtUser.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtContra.Text == "" || txtConfirmar.Text == ""){
                MessageBox.Show("Dejo campos vacios");
                limpiar();
            }else {
                if (txtContra.Text == txtConfirmar.Text)
                {
                    Manejador.getInstancia().agregarUsuario(txtUser.Text, txtContra.Text);
                    MessageBox.Show("Usuario agregado correctamente");
                    limpiar();
                }else {
                    MessageBox.Show("Las contraseñas no coinciden.\nNo es posible agregar");
                    limpiar();
                }
            }
        }
    }
}
