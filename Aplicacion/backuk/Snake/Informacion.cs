using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Informacion : Form
    {
        PuertoParalelo puertito = new PuertoParalelo();
        public Informacion()
        {
            InitializeComponent();
            txtNivel.Text = Manejador.getInstancia().getUsuario().getNivel().ToString();
            txtPuntos.Text = Manejador.getInstancia().getUsuario().getPuntos().ToString();
            txtTiempo.Text = Manejador.getInstancia().getUsuario().getTiempo().ToString();
            txtUsuario.Text = Manejador.getInstancia().getUsuario().getUserName();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Juego.sigueJugando = true;
            Juego juego = new Juego();
            juego.Show();
            this.Hide();
           
             
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            Manejador.getInstancia().setUsuario(null);
            log.Show();
            this.Hide();
        }

        private void Informacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grupo 2\n" +
                "Adrian Byron Ernesto Alvarado Alfaro 201700308\n" +
                "Carlos Alejandro Tenes Mejia 201700317\n" +
                "Ludwing Gabriel Paz Hernandez 201700521\n" +
                "Byron Antonio Orellana Alburez 201700733\n" +
                "Jackeline Alexandra Benitez Benitez 201709166\n" +
                "Organizacion Computacional B","Acerca de",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Usuario user = Manejador.getInstancia().buscarUsuario(txtUsuario.Text);
            user.setNivel(1);
            user.setPuntos(0);
            user.setTiempo(0);
            Manejador.getInstancia().setUsuario(null);
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
    }
}
