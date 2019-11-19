using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Manejador
    {
        List<Usuario> usuarios;
        Usuario usuarioLogeado;
        private static Manejador instancia;
        public static Manejador getInstancia() {
            if (instancia==null)
            {
                instancia = new Manejador();
                
            }
            return instancia;
        }
        public Manejador() {
            usuarios = new List<Usuario>();
            usuarioLogeado = new Usuario();
        }
        public Usuario getUsuario() { return usuarioLogeado; }
        public void setUsuario(Usuario usuarioLogeado) { this.usuarioLogeado = usuarioLogeado; }
        public void agregarUsuario(string userName, string contra) {
            Usuario nuevo = new Usuario(userName,contra);
            usuarios.Add(nuevo);
        }
        public Usuario buscarUsuario(string userName) {
            foreach (var item in usuarios)
            {
                if (item.getUserName()==userName)
                {
                    return item;
                }
            }
            return null;
        }
        public void eliminarUsuario(Usuario usuario) {
            if (usuarios.Contains(usuario))
            {
                usuarios.Remove(usuario);
            }else {
                
            }
        }
        public bool login(string userName,string contra) {
            foreach (var item in usuarios)
            {
                if (item.getUserName().Equals(userName)&&item.getContra().Equals(contra))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Usuario> getUsuarios() { return usuarios; }
    }
}
