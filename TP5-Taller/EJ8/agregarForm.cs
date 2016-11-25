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
    public partial class agregarForm : Form
    {
        public agregarForm()
        {
            InitializeComponent();
            textBox_NombreCompleto.TabIndex = 1;
            textBox_CorreoElectronico.TabIndex = 2;
            button_Aceptar.TabIndex = 3;
            button_Cerrar.TabIndex = 4;
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            Fachada.Instancia.AgregarUsuario(textBox_NombreCompleto.Text, textBox_CorreoElectronico.Text);
            this.Close();
        }

        private void button_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_NombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
