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
    public partial class Form1 : Form
    {
        static public RepositorioUsuario repo = new RepositorioUsuario();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarForm MDIChild = new agregarForm();
            // Set the Parent Form of the Child window.
            MDIChild.MdiParent = this;
            // Display the new form.
            MDIChild.Show();
            MDIChild.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        /// <summary>
        /// Procedimientos que hará al cerrar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ActualizarLista();
        }

        /// <summary>
        /// Actualiza la lista
        /// </summary>
        private void ActualizarLista()
        {
            try
            {
                var source = new BindingSource();
                List<Usuario> list = Fachada.Instancia.ObtenerTodos();
                source.DataSource = list;
                this.dataGridView1.DataSource = source;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen elementos");
            }
        }
        /// <summary>
        /// Método que abre la ventana Editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario usuario = new Usuario();
                usuario.Codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                usuario.NombreCompleto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                usuario.CorreoElectronico = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                editarForm MDIChild = new editarForm(usuario);
                // Set the Parent Form of the Child window.
                MDIChild.MdiParent = this;
                // Display the new form.
                MDIChild.Show();
                MDIChild.FormClosing += new FormClosingEventHandler(Form_FormClosing);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se ha seleccionado ningún usuario");
            }
        }

        /// <summary>
        /// Elimina un usuario del repositorio de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioAEliminar = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Fachada.Instancia.Eliminar(usuarioAEliminar);
                this.ActualizarLista();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se ha seleccionado ningún usuario");
            }
        }
        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nombreColumna = dataGridView1.Columns[e.ColumnIndex].Name;
            try
            {
                var source = new BindingSource();
                List<Usuario> list = Fachada.Instancia.ObtenerComparadosPor(nombreColumna);
                source.DataSource = list;
                this.dataGridView1.DataSource = source;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen elementos");
            }
        }

    }
}
