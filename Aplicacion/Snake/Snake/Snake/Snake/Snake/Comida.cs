﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Comida : objeto
    {
        public Comida()
        {
            //dimensiones de la pantalla/10 en las que se genera la comida
            this.x = generar(30);
            this.y = generar(30);
        }
        public void dibujar(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.ancho, this.ancho);
        }
        public int generar(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n)*10;
            return num;
        }
        public void colocar()
        {
            this.x = generar(30);
            this.y = generar(30);
        }
    }
}
