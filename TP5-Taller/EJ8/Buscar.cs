using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ8
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label6.Text = "";
            label7.Text = "";
            string cod = textBox1.Text;
            if (cod=="")
            {
                cod =null;
            }
            try
            {
                Usuario us = Fachada.Instancia.ObtenerPorCodigo(cod);
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label2.Text = us.Codigo;
                label6.Text = us.NombreCompleto;
                label7.Text = us.CorreoElectronico;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("No se ha ingresado una clave");
            }
            catch (KeyNotFoundException)
            {
                MessageBox.Show("No se ha encontrado el Usuario");
            }

        }
    }
}
