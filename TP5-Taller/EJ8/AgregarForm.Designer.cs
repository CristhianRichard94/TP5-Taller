namespace EJ8
{
    partial class agregarForm
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
            this.textBox_NombreCompleto = new System.Windows.Forms.TextBox();
            this.textBox_CorreoElectronico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Cerrar = new System.Windows.Forms.Button();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_NombreCompleto
            // 
            this.textBox_NombreCompleto.Location = new System.Drawing.Point(205, 41);
            this.textBox_NombreCompleto.Name = "textBox_NombreCompleto";
            this.textBox_NombreCompleto.Size = new System.Drawing.Size(100, 20);
            this.textBox_NombreCompleto.TabIndex = 11;
            this.textBox_NombreCompleto.TextChanged += new System.EventHandler(this.textBox_NombreCompleto_TextChanged);
            // 
            // textBox_CorreoElectronico
            // 
            this.textBox_CorreoElectronico.Location = new System.Drawing.Point(205, 77);
            this.textBox_CorreoElectronico.Name = "textBox_CorreoElectronico";
            this.textBox_CorreoElectronico.Size = new System.Drawing.Size(100, 20);
            this.textBox_CorreoElectronico.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Correo Electrónico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre Completo";
            // 
            // button_Cerrar
            // 
            this.button_Cerrar.Location = new System.Drawing.Point(230, 139);
            this.button_Cerrar.Name = "button_Cerrar";
            this.button_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar.TabIndex = 8;
            this.button_Cerrar.Text = "Cerrar";
            this.button_Cerrar.UseVisualStyleBackColor = true;
            this.button_Cerrar.Click += new System.EventHandler(this.button_Cerrar_Click);
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(124, 139);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 7;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // agregarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 203);
            this.Controls.Add(this.textBox_NombreCompleto);
            this.Controls.Add(this.textBox_CorreoElectronico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cerrar);
            this.Controls.Add(this.button_Aceptar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "agregarForm";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.agregarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_NombreCompleto;
        private System.Windows.Forms.TextBox textBox_CorreoElectronico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Cerrar;
        private System.Windows.Forms.Button button_Aceptar;
    }
}