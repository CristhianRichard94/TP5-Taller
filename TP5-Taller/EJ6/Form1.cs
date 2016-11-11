using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJ6
{
    public partial class Form1 : Form
    {
        static Fachada fachada = new Fachada();
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button6.Visible = !(button6.Visible);
            button7.Visible = !(button7.Visible);
            button8.Visible = !(button8.Visible);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button9.Visible = !(button9.Visible);
            button10.Visible = !(button10.Visible);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button9.Visible = !(button9.Visible);
            button10.Visible = !(button10.Visible);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button11.Visible = !(button11.Visible);
            button12.Visible = !(button12.Visible);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fachada.Crear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string mensaje = ("Acuerdo: " + fachada.Cuentas().CuentaCorriente.Acuerdo + "\n Saldo:" + fachada.Cuentas().CuentaCorriente.Saldo);
            MessageBox.Show(mensaje);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string mensaje = ("Acuerdo: " + fachada.Cuentas().CajaAhorro.Acuerdo + "\n Saldo:" + fachada.Cuentas().CajaAhorro.Saldo);
            MessageBox.Show(mensaje);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string mensaje = ("             Cuenta Corriente             Caja Ahorro \n Acuerdo:        " + fachada.Cuentas().CuentaCorriente.Acuerdo + "                             " + fachada.Cuentas().CajaAhorro.Acuerdo + "\n Saldo:            " + fachada.Cuentas().CuentaCorriente.Saldo + "                               "+fachada.Cuentas().CajaAhorro.Saldo);
            MessageBox.Show(mensaje);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
