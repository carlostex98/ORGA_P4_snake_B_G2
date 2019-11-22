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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            VerUsuario verUsuario = new VerUsuario();
            verUsuario.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TopTiempo topTiempo = new TopTiempo();
            topTiempo.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TopPuntos top = new TopPuntos();
            top.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Eliminar eli = new Eliminar();
            eli.Show();
            this.Hide();
        }
    }
}
