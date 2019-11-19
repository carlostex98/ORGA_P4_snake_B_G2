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
            if (textBox1.Text.Equals("B"))
            {
                if (textBox2.Text.Equals("3"))
                {
                    Juego juego = new Juego();
                    this.Hide();
                    juego.Show();
                }
            }
            else
            {
                MessageBox.Show("No estan bien sus datos :v");
            }
        }
    }
}
