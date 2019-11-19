﻿using System;
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
        int puntaje = 0;
        public Juego()
        {
            InitializeComponent();
            cabeza = new Cola(10, 10);
            comida = new Comida();
           g = canvas.CreateGraphics();
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
        }
        public void choquePared() {
            if (cabeza.verX()<0 || cabeza.verX()>300 || cabeza.verY()<0 || cabeza.verY()>300) {
                findejuego();
            }
        }
        public void findejuego()
        {
            puntaje = 0;
            puntos.Text = "0";
            ejex = true;
            ejey = true;
            xdir = 0;
            ydir = 0;
            cabeza = new Cola(10,10);
            comida = new Comida();
            MessageBox.Show("Perdiste, te saluda tu amigo DromeTex");

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
                }
                if (e.KeyCode==Keys.Down)
                {
                    ydir = cuadro;
                    xdir = 0;
                    ejex = false;
                    ejey = true;
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
                }
                if (e.KeyCode==Keys.Left)
                {
                    ydir = 0;
                    xdir = -cuadro;
                    ejex = true;
                    ejey = false;
                }
            }
        }
    }
}
