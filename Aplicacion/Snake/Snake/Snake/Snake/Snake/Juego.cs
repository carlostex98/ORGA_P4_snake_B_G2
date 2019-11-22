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
    public partial class Juego : Form
    {
        Graphics g;
        int xdir = 0;
        int ydir = 0;
        int cuadro = 10;
        Boolean ejex = true, ejey = true;
        Cola cabeza;
        Comida comida;
        int puntaje;
        int arriba = 0;
        int abajo = 0;
        int derecha = 0;
        int izquierda = 0;
        public Juego()
        {
            InitializeComponent();
            cabeza = new Cola(10, 10);
            comida = new Comida();
            puntaje = Manejador.getInstancia().getUsuario().getPuntos();
            g = canvas.CreateGraphics();
            puntos.Text = puntaje.ToString();
        }
        public void movimiento()
        {
            cabeza.setXY(cabeza.verX() + xdir, cabeza.verY() + ydir);
        }
        private void Bucle_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            cabeza.dibujar(g);
            comida.dibujar(g);
            movimiento();
            choquecuerpo();
            choquePared();
            if (cabeza.interseccion(comida))
            {
                comida.colocar();
                cabeza.meter();
                puntaje += 10;
                puntos.Text = puntaje.ToString();
            }
            for (int i = 0; i < 12; i++)
            {

            }
        }
        public void choquePared() {
            if (cabeza.verX()<0 || cabeza.verX()>=300 || cabeza.verY()<0 || cabeza.verY()>=300) {
                findejuego();
            }
        }
        public void findejuego()
        {
            Manejador.getInstancia().getUsuario().setPuntos(puntaje);
            puntaje = 0;
            puntos.Text = "0";
            ejex = true;
            ejey = true;
            xdir = 0;
            ydir = 0;
            cabeza = new Cola(10,10);
            comida = new Comida();
            MessageBox.Show("Perdiste, te saluda tu amigo DromeTex");
            Informacion info = new Informacion();
            info.Show();
            this.Hide();

        }
        public void choquecuerpo() {
            Cola temp;
            try
            {
                temp = cabeza.verSiguiente().verSiguiente();
            }
            catch (Exception error)
            {
                temp = null;
              //  MessageBox.Show("este es el error xd " + error);
            }
            while(temp != null)
            {
                if (cabeza.interseccion(temp))
                {
                    findejuego();
                }
                else
                {
                    temp = temp.verSiguiente();
                }
            }
        }

        private void Juego_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void Juego_KeyDown(object sender, KeyEventArgs e)
        {
            if (ejex)
            {
                if (e.KeyCode== Keys.Up)
                {
                    ydir = -cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                    abajo = 0;
                    izquierda = 0;
                    derecha = 0;
                    arriba = 1;
                    Console.WriteLine(arriba + " " + abajo + " " + izquierda + " " + derecha);
                }
                if (e.KeyCode==Keys.Down)
                {
                    ydir = cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
                    arriba = 0;
                    izquierda = 0;
                    derecha = 0;
                    abajo = 1;
                    Console.WriteLine(arriba + " " + abajo + " " + izquierda + " " + derecha);
                }
            }
            if (ejey)
            {
                if (e.KeyCode==Keys.Right)
                {
                    ydir = 0;
                    xdir = cuadro;
                    ejex = true;
                    ejey = false;
                    arriba = 0;
                    abajo = 0;
                    izquierda = 0;
                    derecha = 1;
                    Console.WriteLine(arriba+" "+abajo+" "+izquierda+" "+derecha);
                }
                if (e.KeyCode==Keys.Left)
                {
                    ydir = 0;
                    xdir = -cuadro;
                    ejex = true;
                    ejey = false;
                    arriba = 0;
                    abajo = 0;
                    derecha = 0;
                    izquierda = 1;
                    Console.WriteLine(arriba + " " + abajo + " " + izquierda + " " + derecha);
                }
            }
        }
    }
}
