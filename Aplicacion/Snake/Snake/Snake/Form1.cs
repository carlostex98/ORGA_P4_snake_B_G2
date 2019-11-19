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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            this.Hide();
            reg.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Byron"))
            {
                if (textBox2.Text.Equals("Admin123"))
                {
                    Tablero tab = new Tablero();
                    this.Hide();
                    tab.Show();
                }
            }
            else
            {
                MessageBox.Show("No estan bien sus datos :v");
            }
        }
    }
}
