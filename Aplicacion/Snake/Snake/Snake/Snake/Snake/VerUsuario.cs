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
    public partial class VerUsuario : Form
    {
        public VerUsuario()
        {
            InitializeComponent();
        }

        private void VerUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Usuario", "Usuario");
            dataGridView1.Columns.Add("Contrasenia", "Contraseña");
            dataGridView1.Columns.Add("tiempo", "Tiempo");
            dataGridView1.Columns.Add("punteo", "Punteo");
            dataGridView1.Columns.Add("nivel", "Nivel");
            foreach (var item in Manejador.getInstancia().getUsuarios())
            {
                dataGridView1.Rows.Add(item.getUserName(),item.getContra(),item.getTiempo(),item.getPuntos(),item.getNivel());
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VerUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Administrador admi = new Administrador();
            admi.Show();
            this.Hide();
        }
    }
}
