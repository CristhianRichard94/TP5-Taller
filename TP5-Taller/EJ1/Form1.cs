using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 1","Cuadro 1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 2", "Cuadro 2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 3", "Cuadro 3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 4", "Cuadro 4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 5", "Cuadro 5");
        }
    }
}
