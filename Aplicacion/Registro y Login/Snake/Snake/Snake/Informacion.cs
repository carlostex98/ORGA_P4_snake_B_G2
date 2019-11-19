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
    public partial class Informacion : Form
    {
        public Informacion()
        {
            InitializeComponent();

            txtNivel.Text = Manejador.getInstancia().getUsuario().getNivel().ToString();
            txtPuntos.Text = Manejador.getInstancia().getUsuario().getPuntos().ToString();
            txtTiempo.Text = Manejador.getInstancia().getUsuario().getTiempo().ToString();
            txtUsuario.Text = Manejador.getInstancia().getUsuario().getUserName();
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo 2\n" +
                "Adrian Byron Ernesto Alvarado Alfaro 201700308\n" +
                "Carlos ALejandro Tenes Mejia 201700317\n" +
                "Ludwing Gabriel Paz Hernández 201700521\n" +
                "Byron Antonio Orellana Alburez 201700733\n" +
                "Jackeline Alexandra Benitez Benitez 201709166\n" +
                "Organizacion Computacional B", "Acerca de",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Usuario user =Manejador.getInstancia().buscarUsuario(txtUsuario.Text);
            user.setNivel(0);
            user.setPuntos(0);
            user.setTiempo(0);
            Manejador.getInstancia().setUsuario(null);
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void BtnDocu_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Manejador.getInstancia().setUsuario(null);
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {

        }

        private void Informacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
