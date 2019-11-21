using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace Snake
{
    public partial class Juego : Form
    {
        Graphics g;
        int xdir = 0;
        int ydir = 0;
        int cuadro = 25;
        Boolean ejex = true, ejey = true;
        Cola cabeza;
        Comida comida;
        int puntaje;
        float tiempo;
        int arriba = 0;
        int abajo = 0;
        int derecha = 0;
        int izquierda = 0;
        matrizDatos[,] matriz = new matrizDatos[12, 12];
        public Juego()
        {
            InitializeComponent();
            cabeza = new Cola(25, 25);
            Jugador.Text = Manejador.getInstancia().getUsuario().getUserName();
            comida = new Comida();
            puntaje = Manejador.getInstancia().getUsuario().getPuntos();
            tiempo = Manejador.getInstancia().getUsuario().getTiempo();
            g = canvas.CreateGraphics();
            puntos.Text = puntaje.ToString();
            label3.Text = tiempo.ToString();
            for (int i =0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matriz[i, j] = new matrizDatos();
                    matriz[i, j].setX(i * 25);
                    matriz[i, j].setY(j * 25);
                    int datoX = matriz[i, j].getX();
                    int datoY = matriz[i, j].getY();
                   // Console.WriteLine(datoX+" "+datoY);
                }
            }
        }
        public void masTiempo() {
            //Thread.Sleep(1000);
            tiempo+=1;
            label3.Text = tiempo.ToString();
        }
        public void movimiento()
        {
            
            cabeza.setXY(cabeza.verX() + xdir, cabeza.verY() + ydir);
           // masTiempo();
        }
        int contadormovimiento = 0;
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
            String prueba = "";
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        int datoX = matriz[i, j].getX();
                        int datoY = matriz[i, j].getY();
                        if (datoX == cabeza.verX() && datoY == cabeza.verY())
                        {
                            prueba = prueba + "1";
                        }
                        else if (datoX == cabeza.verSiguiente().verX() && datoY == cabeza.verSiguiente().verY())
                        {
                            prueba = prueba + "1";
                        }
                        else
                        {
                            prueba = prueba + "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            Console.WriteLine("\n");
            Console.WriteLine(prueba);
        }
        public void choquePared() {
            if (cabeza.verX()<0 || cabeza.verX()>=300 || cabeza.verY()<0 || cabeza.verY()>=300) {
                findejuego();
            }

        }
        public void findejuego()
        {
            Manejador.getInstancia().getUsuario().setPuntos(puntaje);
            Manejador.getInstancia().getUsuario().setTiempo(tiempo);
            puntaje = 0;
            tiempo = 0;
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
            ydir = 0;
            xdir = cuadro;
            ejex = true;
            ejey = false;
            arriba = 0;
            abajo = 0;
            izquierda = 0;
            derecha = 1;
            Console.WriteLine(arriba + " " + abajo + " " + izquierda + " " + derecha);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tiempo++;
            label3.Text = tiempo.ToString();
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
