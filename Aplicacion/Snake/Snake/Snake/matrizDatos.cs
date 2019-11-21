using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class matrizDatos
    {
        int posX;
        int posY;
        public matrizDatos(int posX,int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
        public matrizDatos()
        {
            this.posY = 0;
            this.posX = 0;
        }
        public int getX()
        {
            return posX;
        }
        public int getY()
        {
            return posY;
        }
        public void setX(int x)
        {
            this.posX = x;
        }
        public void setY(int y)
        {
            this.posY = y;
        }
    }
}
