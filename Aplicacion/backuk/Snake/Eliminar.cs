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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Usuario", "Usuario");
            dataGridView1.Columns.Add("Contrasenia", "Contraseña");
            dataGridView1.Columns.Add("Eliminar", "Eliminar");
            foreach (var item in Manejador.getInstancia().getUsuarios())
            {
                RadioButton radio = new RadioButton();
                dataGridView1.Rows.Add(item.getUserName(), item.getContra());
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentCell.RowIndex;
            Manejador.getInstancia().eliminarUsuario(indice);
            //MessageBox.Show("la fila seleccionada es " + indice);
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Administrador admi = new Administrador();
            admi.Show();
            this.Hide();
        }

        private void Eliminar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
