using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ7
{
    public partial class Form1 : Form
    {
        static Fachada fachada = new Fachada();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Seleccionado este botón toma el texto del textBox1 y lo encripta y desencripta
        /// según el encriptador que seleccione en el comboBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            Object selectedItem = comboBox1.SelectedItem;
            string opcion = comboBox1.GetItemText(selectedItem);
            if (input == "")
                MessageBox.Show("DEBE INGRESAR UNA CADENA!!!!");
            else
            {
                switch (opcion)
                {
                    case "CESAR":
                        MessageBox.Show("Cadena Encriptada: " + fachada.EncriptarCesar(input) + "\n Cadena Desencriptada:" + fachada.DesencriptarCesar(fachada.EncriptarCesar(input)));
                        break;
                    case "AES":
                        MessageBox.Show("Cadena Encriptada: " + fachada.EncriptarAES(input) + "\n Cadena Desencriptada:" + fachada.DesencriptarAES(fachada.EncriptarAES(input)));
                        break;
                    case "NULO":
                        MessageBox.Show("Cadena Encriptada: " + fachada.EncriptarNulo(input) + "\n Cadena Desencriptada:" + fachada.DesencriptarNulo(fachada.EncriptarNulo(input)));
                        break;
                    case "Triple DES":
                        MessageBox.Show("Cadena Encriptada: " + fachada.EncriptarTripleDES(input) + "\n Cadena Desencriptada:" + fachada.DesencriptarTripleDES(fachada.EncriptarTripleDES(input)));
                        break;
                    case "":
                        MessageBox.Show("DEBE SELECCIONAR UNA OPCION");
                        break;
                    default: break;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
