using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ5
{
    public partial class Form1 : Form
    {
        FachadaFigura fachada = new FachadaFigura();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label8.Visible = false;
            label9.Text = "Radio:";
            label10.Visible = false;
            label12.Visible = false;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            label8.Visible = true;
            label9.Text = "Y:";
            label10.Visible = true;
            label12.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double x1, y1, x2, y2, x3, y3;
                double.TryParse(textBox1.Text, out x1);
                double.TryParse(textBox2.Text, out y1);
                double.TryParse(textBox3.Text, out x2);
                double.TryParse(textBox4.Text, out y2);
                double.TryParse(textBox5.Text, out x3);
                double.TryParse(textBox6.Text, out y3);
                if (radioButton3.Checked)
                {
                    label6.Visible = true;
                    label6.Text = "El Perimetro es:";
                    label7.Text=(fachada.CalcularPerimetroTriangulo(x1,y1,x2,y2,x3,y3)).ToString();
                }
                else
                {
                    label6.Visible = true;
                    label6.Text = "El Area es:";
                    label7.Text = (fachada.CalcularAreaTriangulo(x1, y1, x2, y2, x3, y3)).ToString();
                }
            }
            else
            {
                double x1, y1, radio;
                double.TryParse(textBox1.Text, out x1);
                double.TryParse(textBox2.Text, out y1);
                double.TryParse(textBox4.Text, out radio);
                if (radioButton3.Checked)
                {
                    label6.Visible = true;
                    label6.Text = "El Perimetro es:";
                    label7.Text = (fachada.CalcularPerimetroCirculo(x1, y1, radio)).ToString();
                }
                else
                {
                    label6.Visible = true;
                    label6.Text = "El Area es:";
                    label7.Text = (fachada.CalcularAreaCirculo(x1, y1, radio)).ToString();
                }
            }
        }
    }
}
