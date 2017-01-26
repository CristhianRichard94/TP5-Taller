namespace EJ8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAproximadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.ordenamientoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.operacionesToolStripMenuItem.Text = "Gestion";
            // 
            // añadirToolStripMenuItem
            // 
            this.añadirToolStripMenuItem.Name = "añadirToolStripMenuItem";
            this.añadirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.añadirToolStripMenuItem.Text = "Agregar";
            this.añadirToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Editar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPorCodigoToolStripMenuItem,
            this.buscarAproximadoToolStripMenuItem});
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // buscarPorCodigoToolStripMenuItem
            // 
            this.buscarPorCodigoToolStripMenuItem.Name = "buscarPorCodigoToolStripMenuItem";
            this.buscarPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.buscarPorCodigoToolStripMenuItem.Text = "Buscar por Codigo";
            this.buscarPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.buscarPorCodigoToolStripMenuItem_Click);
            // 
            // buscarAproximadoToolStripMenuItem
            // 
            this.buscarAproximadoToolStripMenuItem.Name = "buscarAproximadoToolStripMenuItem";
            this.buscarAproximadoToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.buscarAproximadoToolStripMenuItem.Text = "Buscar Aproximado";
            this.buscarAproximadoToolStripMenuItem.Click += new System.EventHandler(this.buscarAproximadoToolStripMenuItem_Click);
            // 
            // ordenamientoToolStripMenuItem
            // 
            this.ordenamientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenarPorNombreToolStripMenuItem,
            this.ordenarPorCorreoToolStripMenuItem,
            this.ordenarPorCodigoToolStripMenuItem});
            this.ordenamientoToolStripMenuItem.Name = "ordenamientoToolStripMenuItem";
            this.ordenamientoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.ordenamientoToolStripMenuItem.Text = "Ordenamiento";
            this.ordenamientoToolStripMenuItem.Click += new System.EventHandler(this.ordenamientoToolStripMenuItem_Click);
            // 
            // ordenarPorNombreToolStripMenuItem
            // 
            this.ordenarPorNombreToolStripMenuItem.Name = "ordenarPorNombreToolStripMenuItem";
            this.ordenarPorNombreToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ordenarPorNombreToolStripMenuItem.Text = "Ordenar Por nombre";
            this.ordenarPorNombreToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorNombreToolStripMenuItem_Click);
            // 
            // ordenarPorCorreoToolStripMenuItem
            // 
            this.ordenarPorCorreoToolStripMenuItem.Name = "ordenarPorCorreoToolStripMenuItem";
            this.ordenarPorCorreoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ordenarPorCorreoToolStripMenuItem.Text = "Ordenar Por Correo";
            this.ordenarPorCorreoToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorCorreoToolStripMenuItem_Click);
            // 
            // ordenarPorCodigoToolStripMenuItem
            // 
            this.ordenarPorCodigoToolStripMenuItem.Name = "ordenarPorCodigoToolStripMenuItem";
            this.ordenarPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ordenarPorCodigoToolStripMenuItem.Text = "Ordenar Por Codigo";
            this.ordenarPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.ordenarPorCodigoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 307);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 331);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ordenamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAproximadoToolStripMenuItem;
    }
}

