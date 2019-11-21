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
    public partial class TopPuntos : Form
    {
        public TopPuntos()
        {
            InitializeComponent();
        }

        private void TopPuntos_Load(object sender, EventArgs e)
        {
            IEnumerable<Usuario> top = Manejador.getInstancia().getUsuarios().OrderByDescending(usuario => usuario.getTiempo());
            dataGridView1.Columns.Add("usuario", "Usuario");
            dataGridView1.Columns.Add("tiempo", "Tiempo");
            dataGridView1.Columns.Add("punteo", "Punteo");
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(top.ElementAt(i).getUserName(), top.ElementAt(i).getTiempo(), top.ElementAt(i).getPuntos());
            }
        }

        private void TopPuntos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Administrador admi = new Administrador();
            admi.Show();
            this.Hide();
        }
    }
}
