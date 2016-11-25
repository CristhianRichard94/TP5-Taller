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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fachada.Crear();
        }
        /// <summary>
        /// Muestra en una ventana emergente los datos de la cuenta corriente como el Acuerdo y el Saldo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            string mensaje = ("Acuerdo: " + fachada.Cuentas().CuentaCorriente.Acuerdo + "\n Saldo:" + fachada.Cuentas().CuentaCorriente.Saldo);
            MessageBox.Show(mensaje, "Resumen");
        }
        /// <summary>
        /// Muestra en una ventana emergente los datos de la caja de ahorro como el Acuerdo y el Saldo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            string mensaje = ("Acuerdo: " + fachada.Cuentas().CajaAhorro.Acuerdo + "\n Saldo:" + fachada.Cuentas().CajaAhorro.Saldo);
            MessageBox.Show(mensaje, "Resumen");
        }
        /// <summary>
        /// Muestra los datos de la cuenta corriente y de la caja de ahorro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            string mensaje = ("Cuenta Corriente \n Acuerdo:" + fachada.Cuentas().CuentaCorriente.Acuerdo + "\n Saldo:" + fachada.Cuentas().CuentaCorriente.Saldo +"\n \n Caja ahorro \n Acuerdo:"+ fachada.Cuentas().CajaAhorro.Acuerdo + "\n Saldo: " + fachada.Cuentas().CajaAhorro.Saldo);
            MessageBox.Show(mensaje,"Resumen");
        }
        /// <summary>
        /// Seleccionando este botón debita el valor ingresado en el monto en la caja de ahorro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            float input;
            float.TryParse(textBox1.Text, out input);
            if (input == 0)
            {
                MessageBox.Show("Error, no se ha ingresado un valor", "Error");
            }
            else
            {
                try
                {
                    fachada.Cuentas().CajaAhorro.DebitarSaldo(input);
                    MessageBox.Show("Se ha debitado con exito", "Accion completada");
                }
                catch (SaldoInsuficienteException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
                catch (SaldoInvalidoException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }
        /// <summary>
        /// Seleccionando este botón transfiere el valor ingresado en el monto de una cuenta corriente  a una caja de ahorro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            float input;
            float.TryParse(textBox1.Text, out input);
            if (input == 0)
            {
                MessageBox.Show("Error, no se ha ingresado un valor", "Error");
            }
            else
            {
                try
                {
                    fachada.Transferir(fachada.Cuentas().CuentaCorriente, fachada.Cuentas().CajaAhorro, input);
                    MessageBox.Show("Se ha transferido con exito", "Accion completada");
                }
                catch (SaldoInvalidoException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }
        /// <summary>
        /// Seleccionando este botón debita el saldo ingresado en el monto en la caja de ahorro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            float input;
            float.TryParse(textBox1.Text, out input);
            if (input == 0)
            {
                MessageBox.Show("Error, no se ha ingresado un valor", "Error");
            }
            else
            {
                try
                {
                    fachada.Cuentas().CajaAhorro.DebitarSaldo(input);
                    MessageBox.Show("Se ha debitado con exito", "Accion completada");
                }
                catch(SaldoInsuficienteException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
                catch (SaldoInvalidoException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Seleccionando este botón acredita el valor ingresado en el monto a una caja de ahorro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            float input;
            float.TryParse(textBox1.Text, out input);
            if (input ==0)
            {
                MessageBox.Show("Error, no se ha ingresado un valor","Error");
            }
            else
            {
                try
                {
                    fachada.Cuentas().CajaAhorro.AcreditarSaldo(input);
                    MessageBox.Show("Se ha acreditado con exito","Accion completada");
                }
                catch (SaldoInvalidoException exception)
                {
                    MessageBox.Show(exception.Message,"Error");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Seleccionando este botón acredita el valor ingresado en el monto a la cuenta corriente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            float input;
            float.TryParse(textBox1.Text, out input);
            if (input == 0)
            {
                MessageBox.Show("Error, no se ha ingresado un valor", "Error");
            }
            else
            {
                try
                {
                    fachada.Cuentas().CuentaCorriente.AcreditarSaldo(input);
                    MessageBox.Show("Se ha acreditado con exito", "Accion completada");
                }
                catch (SaldoInvalidoException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
                catch (SaldoInsuficienteException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }
        /// <summary>
        /// Seleccionando este botón transfiere el valor ingresado en el monto deuna caja de ahorro a una cuenta corriente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            float input;
            float.TryParse(textBox1.Text, out input);
            if (input == 0)
            {
                MessageBox.Show("Error, no se ha ingresado un valor", "Error");
            }
            else
            {
                try
                {
                    fachada.Transferir(fachada.Cuentas().CajaAhorro,fachada.Cuentas().CuentaCorriente,input);
                    MessageBox.Show("Se ha transferido con exito", "Accion completada");
                }
                catch (SaldoInvalidoException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
                catch (SaldoInsuficienteException exception)
                {
                    MessageBox.Show(exception.Message, "Error");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
