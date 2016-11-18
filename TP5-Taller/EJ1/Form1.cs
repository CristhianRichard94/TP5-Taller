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
        /// <summary>
        /// Seleccionando este botón devuelve un mensaje con el nombre del mismo
        /// y el titulo de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 1","Cuadro 1");
        }
        /// <summary>
        /// Seleccionando este botón devuelve un mensaje con el nombre del mismo
        /// y el titulo de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 2", "Cuadro 2");
        }
        /// <summary>
        /// Seleccionando este botón devuelve un mensaje con el nombre del mismo
        /// y el titulo de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 3", "Cuadro 3");
        }
        /// <summary>
        /// Seleccionando este botón devuelve un mensaje con el nombre del mismo
        /// y el titulo de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 4", "Cuadro 4");
        }
        /// <summary>
        /// Seleccionando este botón devuelve un mensaje con el nombre del mismo
        /// y el titulo de la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha clickeado el boton 5", "Cuadro 5");
        }
    }
}
