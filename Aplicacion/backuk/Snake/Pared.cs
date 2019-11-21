using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Pared : objeto
    {
        public Pared()
        {
            //dimensiones de la pantalla/25 en las que se genera la comida
            this.x = generarpared(25);
            this.y = generarpared(25);
        }
        public void dibujarpared(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color.Blue), this.x, this.y, this.ancho, this.ancho);
        }
        public int generarpared(int n)
        {
            Random random = new Random();
            int num = random.Next(0, n) * 25;
            return num;
        }

        public void colocarpared()
        {
            this.x = generarpared(25);
            this.y = generarpared(25);
        }
    }
}