using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Usuario
    {
        string userName;
        string contra;
        float tiempo;
        int puntos;
        int nivel;
        public Usuario() { }
        public Usuario(string userName,string contra) {
            this.userName = userName;
            this.contra = contra;
            tiempo = 0;
            puntos = 0;
            nivel = 1;
        }

        public void setUserName(string userName) { this.userName = userName; }
        public void setContra(string contra) { this.contra = contra; }
        public void setTiempo(float tiempo) { this.tiempo = tiempo; }
        public void setPuntos(int puntos) { this.puntos = puntos; }
        public void setNivel(int nivel) { this.nivel = nivel; }
        public string getUserName() { return userName; }
        public string getContra() { return contra; }
        public float getTiempo() { return tiempo; }
        public int getPuntos() { return puntos; }
        public int getNivel() { return nivel; }


    }
}
