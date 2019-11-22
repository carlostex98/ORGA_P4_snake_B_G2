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
        public static Boolean sigueJugando = false;
        Graphics g;
        int xdir = 0;
        int ydir = 0;
        int cuadro = 25;
        Boolean ejex = true, ejey = true;
        Cola cabeza;
        Comida comida;
        int puntaje;
        Obstaculo obstaculos;
        float tiempo;
        int arriba = 0;
        int abajo = 0;
        int derecha = 0;
        PuertoParalelo puertito = new PuertoParalelo();
        int izquierda = 0;
        matrizDatos[,] matriz = new matrizDatos[12, 12];
        bool ganar;
        int nivel;
        public Juego()
        {
            InitializeComponent();
            cabeza = new Cola(25, 25);
            obstaculos = new Obstaculo();
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
                    Console.WriteLine(datoX+" "+datoY);
                }
            }
            nivel = Manejador.getInstancia().getUsuario().getNivel();
            ganar = false;
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
        private void validarObstaculos()
        {
            if (puntaje < 100)
            {
                obstaculos.dibujar(g);
            }
            else if (puntaje >= 100 && puntaje < 200)
            {
                obstaculos.dibujar1(g);
            }
            else if (puntaje >= 200 && puntaje < 300)
            {
                obstaculos.dibujar2(g);
            }      
        }
        private void Bucle_Tick(object sender, EventArgs e)
        {
            //setVelocidad();
            g.Clear(Color.White);
            cabeza.dibujar(g);
            comida.dibujar(g);
            validarObstaculos();

            choquePared();
            // mandarDatos();
            // Console.WriteLine(comida.getX()+",,,,,"+comida.getY());
            if (cabeza.interseccion(comida))
            {

                verificarComida();
                cabeza.meter();
                puntaje += 10;
                aumentarNivel();
                puntos.Text = puntaje.ToString();
            }
            movimiento();
            choquecuerpo(); 
        }
        public void setVelocidad() {
            if (nivel == 1)
            {
                bucle.Interval = 500;
            } else if (nivel == 2) { bucle.Interval = 300; } else if (nivel ==3) { bucle.Interval = 100; }
        }
        public void verificarComida()
        {
            comida.colocar();
            if (comida.getX() == verificarX && comida.getY() == verificarY)
            {
                comida.colocar();
                verificarComida();
            }
        }
        private void aumentarNivel()
        {
           if (puntaje >= 100 && puntaje < 200)
            {
                //MessageBox.Show("Has superado el nivel 1 de Drome Tex");
                bucle.Interval = 300;
                Manejador.getInstancia().getUsuario().setNivel(2);
                label6.Text= Manejador.getInstancia().getUsuario().getNivel().ToString();
            }
            else if(puntaje >= 200 && puntaje < 300)
            {
                //MessageBox.Show("Has superado el nivel 1 de Drome Tex");
                bucle.Interval = 100;
                Manejador.getInstancia().getUsuario().setNivel(3);
                label6.Text = Manejador.getInstancia().getUsuario().getNivel().ToString();
            }
            else if (puntaje == 300)
            {
                ganarnivel();
            }
        }
        public void ganarnivel() {
            ganar = true;
            MessageBox.Show("Usted a ganado SIIIUUUUU , drome tex se despide");
            Manejador.getInstancia().getUsuario().setNivel(1);
            Manejador.getInstancia().getUsuario().setPuntos(0);
            Manejador.getInstancia().getUsuario().setTiempo(0);
            Form1 log = new Form1();
            log.Show();
            this.Hide();
        }
        int verificarX;
        int verificarY;

        public void choquePared() {
            if (cabeza.verX()<0 || cabeza.verX()>=300 || cabeza.verY()<0 || cabeza.verY()>=300) {
                Console.WriteLine(obstaculos.getX());
                Console.WriteLine(obstaculos.getX());
                findejuego();
            }
            if (puntaje < 100)
            {
                if (cabeza.verX()==50 && cabeza.verY()==100)
                {
                    findejuego();
                }
                else if (cabeza.verX()==175 && cabeza.verY()==100)
                {
                    findejuego();
                }
                verificarX = cabeza.verX();
                verificarY = cabeza.verY();
            }
            else if (puntaje >= 100 && puntaje < 200)
            {
                if (cabeza.verX() == 0 && cabeza.verY() == 0)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 0 && cabeza.verY() == 25)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 0 && cabeza.verY() == 50)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 0 && cabeza.verY() == 75)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 0 && cabeza.verY() == 100)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 0 && cabeza.verY() == 125)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 275 && cabeza.verY() == 150)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 275 && cabeza.verY() == 175)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 275 && cabeza.verY() == 200)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 275 && cabeza.verY() == 225)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 275 && cabeza.verY() == 250)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 275 && cabeza.verY() == 275)
                {
                    findejuego();
                }
                verificarX = cabeza.verX();
                verificarY = cabeza.verY();
            }
            else if (puntaje >= 200 && puntaje < 300)
            {
                 if (cabeza.verX() == 125 && cabeza.verY() == 50)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 125 && cabeza.verY() == 75)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 125 && cabeza.verY() == 100)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 125 && cabeza.verY() == 125)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 125 && cabeza.verY() == 150)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 125 && cabeza.verY() == 175)
                {
                    findejuego();
                }
                else if (cabeza.verX() == 125 && cabeza.verY() == 200)
                {
                    findejuego();
                }
                verificarX = cabeza.verX();
                verificarY = cabeza.verY();
            }
        }
        public void findejuego()
        {
            if (!ganar)
            {
                Juego.sigueJugando = false;
                Manejador.getInstancia().getUsuario().setPuntos(puntaje);
                Manejador.getInstancia().getUsuario().setTiempo(tiempo);
                puntaje = 0;
                tiempo = 0;
                puntos.Text = "0";
                ejex = true;
                ejey = true;
                xdir = 0;
                ydir = 0;
                cabeza = new Cola(10, 10);
                comida = new Comida();
                MessageBox.Show("Perdiste, te saluda tu amigo DromeTex");
                Informacion info = new Informacion();
                info.Show();
                this.Hide();
            }

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
            setVelocidad();
            label6.Text = Manejador.getInstancia().getUsuario().getNivel().ToString();
            Console.WriteLine(arriba + " " + abajo + " " + izquierda + " " + derecha);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            mandarDatos();
           
        }
        private void mandarDatos()
        {
            String prueba = "";
            puertito.clock(1);
            try
            {
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        int datoX = matriz[j, i].getX();
                        int datoY = matriz[j, i].getY();
                        if (datoX == cabeza.verX() && datoY == cabeza.verY())
                        {
                            puertito.clock(1);
                            puertito.activaD0();
                            puertito.clock(0);
                            prueba = prueba + " 1 ";
                        }
                        else if (datoX == cabeza.verSiguiente().verX() && datoY == cabeza.verSiguiente().verY())
                        {
                            prueba = prueba + " 1 ";
                        }
                        else if (datoX == comida.getX() && datoY == comida.getY())
                        {
                            puertito.activaD0();
                            prueba = prueba + " 1 ";
                        }
                        else
                        {
                            puertito.desactivaD0();
                            prueba = prueba + " 0 ";
                        }
                    }
                    prueba = prueba + "\n";
                }
            }
            catch (Exception ex)
            {

            }
            puertito.clock(0);
            Console.WriteLine(prueba);
        }

        private void Puntos_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
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
