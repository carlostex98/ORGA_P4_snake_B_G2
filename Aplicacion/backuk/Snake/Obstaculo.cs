using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snake
{
    class Obstaculo : objeto
    {
        int tamanio = 25;
        public Obstaculo()
        {
            this.x = tamanio;
            this.y = tamanio;
        }
        public void dibujar(Graphics g)
        {
            //  g.FillRectangle(new SolidBrush(Color.Red), this.x, this.y, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 50, 100, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 175, 100, this.ancho, this.ancho);
            
        }
        public void dibujar1(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), 0, 0, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 25, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 50, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 75, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 100, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 0, 125, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 275, 150, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 275, 175, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 275, 200, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 275, 225, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 275, 250, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 275, 275, this.ancho, this.ancho);
        }
        public void dibujar2(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Red), 125, 50, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 125, 75, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 125, 100, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 125, 125, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 125, 150, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 125, 175, this.ancho, this.ancho);
            g.FillRectangle(new SolidBrush(Color.Red), 125, 200, this.ancho, this.ancho);
        }
        public void colocar(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
    }
}
