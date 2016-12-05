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
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarForm MDIChild = new agregarForm();
            //MDIChild.MdiParent = this;  (Con esta linea no abren las ventanas)
            MDIChild.Show();
            //Cuando se cierra la ventana llama al metodo form_formClosing que actualiza la tabla de la ventana principal
            MDIChild.FormClosing += new FormClosingEventHandler(Form_FormClosing);
        }

        /// <summary>
        /// Procedimientos que hará al cerrar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.ActualizarTabla();
        }

        /// <summary>
        /// Actualiza la tabla
        /// </summary>
        private void ActualizarTabla()
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
                //MDIChild.MdiParent = this;
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
                this.ActualizarTabla();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No se ha seleccionado ningún usuario");
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }
        /// <summary>
        /// boton del menu para Salir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordenarPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreColumna = "NombreCompleto";
            try
            {
                var source = new BindingSource();
                List<Usuario> list = Fachada.Instancia.ObtenerComparadosPor(nombreColumna);
                source.DataSource = list;
                this.dataGridView1.DataSource = source.DataSource;
                ActualizarTabla();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen elementos");
            }
        }

        private void ordenarPorCorreoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreColumna = "CorreoElectronico";
            try
            {
                var source = new BindingSource();
                List<Usuario> list = Fachada.Instancia.ObtenerComparadosPor(nombreColumna);
                source.DataSource = list;
                this.dataGridView1.DataSource = source.DataSource;
                ActualizarTabla();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen elementos");
            }
        }

        private void ordenarPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombreColumna = "Codigo";
            try
            {
                var source = new BindingSource();
                List<Usuario> list = Fachada.Instancia.ObtenerComparadosPor(nombreColumna);
                source.DataSource = list;
                this.dataGridView1.DataSource = source.DataSource;
                ActualizarTabla();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No existen elementos");
            }
        }
    }
}
