using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }
        /// <summary>
        /// Agrega una línea con el nombre del botón que seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Boton 1";
            textBox1.Text += Environment.NewLine;
        }
        /// <summary>
        /// Agrega una línea con el nombre del botón que seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Boton 2";
            textBox1.Text += Environment.NewLine;
        }
        /// <summary>
        /// Agrega una línea con el nombre del botón que seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Boton 3";
            textBox1.Text += Environment.NewLine;
        }
        /// <summary>
        /// Agrega una línea con el nombre del botón que seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Boton 4";
            textBox1.Text += Environment.NewLine;
        }
        /// <summary>
        /// Agrega una línea con el nombre del botón que seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Boton 5";
            textBox1.Text += Environment.NewLine;
        }
        /// <summary>
        /// Agrega una línea con el nombre del botón que seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Boton 6";
            textBox1.Text += Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
