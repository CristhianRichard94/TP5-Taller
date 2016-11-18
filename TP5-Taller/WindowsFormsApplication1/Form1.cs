using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Seleccionado este botón se verifica por medio de True o False cuál checkBox
        /// o radioButton está seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "El componente  " +  radioButton1.Text + "está  " + radioButton1.Checked +"          El componente  " + checkBox1.Text + "está  " + checkBox1.Checked + ",El componente  " +  radioButton2.Text + "está  " + radioButton2.Checked+ "         El componente  " + checkBox2.Text + "está  " + checkBox2.Checked+ ",El componente  " + radioButton3.Text + "está  " + radioButton3.Checked;
            mensaje = mensaje.Replace(",", "\n");
            MessageBox.Show(mensaje);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
