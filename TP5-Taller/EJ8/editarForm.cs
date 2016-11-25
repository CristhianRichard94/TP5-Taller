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
    public partial class editarForm : Form
    {
        public editarForm()
        {
            InitializeComponent();
        }

        public editarForm(Usuario pUsuario):this()
        {
            this.label1.Text = pUsuario.Codigo;
            this.textBox1.Text = pUsuario.NombreCompleto;
            this.textBox2.Text = pUsuario.CorreoElectronico;
        }

        private void editarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fachada.Instancia.Actualizar(this.label1.Text, this.textBox1.Text, this.textBox2.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
