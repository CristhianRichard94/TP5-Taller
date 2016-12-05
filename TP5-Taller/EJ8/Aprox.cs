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
    public partial class Aprox : Form
    {
        public Aprox()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Usuario> lista = Fachada.Instancia.BuscarAproximado(textBox1.Text).ToList<Usuario>();
            dataGridView1.DataSource = lista;
        }
    }
}
