namespace JDR.LUG.Clase8.Ej1.UI
{
    partial class Prestamos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLibros = new System.Windows.Forms.ComboBox();
            this.lblFechaDev = new System.Windows.Forms.Label();
            this.btnAlquilarLibro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAlumnos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAlumnosPrest = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Préstamos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de Devolución";
            // 
            // cbLibros
            // 
            this.cbLibros.FormattingEnabled = true;
            this.cbLibros.Location = new System.Drawing.Point(174, 69);
            this.cbLibros.Name = "cbLibros";
            this.cbLibros.Size = new System.Drawing.Size(209, 24);
            this.cbLibros.TabIndex = 2;
            this.cbLibros.SelectedIndexChanged += new System.EventHandler(this.cbLibros_SelectedIndexChanged);
            // 
            // lblFechaDev
            // 
            this.lblFechaDev.AutoSize = true;
            this.lblFechaDev.Location = new System.Drawing.Point(171, 105);
            this.lblFechaDev.Name = "lblFechaDev";
            this.lblFechaDev.Size = new System.Drawing.Size(0, 17);
            this.lblFechaDev.TabIndex = 3;
            // 
            // btnAlquilarLibro
            // 
            this.btnAlquilarLibro.Location = new System.Drawing.Point(18, 136);
            this.btnAlquilarLibro.Name = "btnAlquilarLibro";
            this.btnAlquilarLibro.Size = new System.Drawing.Size(99, 30);
            this.btnAlquilarLibro.TabIndex = 4;
            this.btnAlquilarLibro.Text = "Alquilar libro";
            this.btnAlquilarLibro.UseVisualStyleBackColor = true;
            this.btnAlquilarLibro.Click += new System.EventHandler(this.btnAlquilarLibro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alumno";
            // 
            // cbAlumnos
            // 
            this.cbAlumnos.FormattingEnabled = true;
            this.cbAlumnos.Location = new System.Drawing.Point(174, 37);
            this.cbAlumnos.Name = "cbAlumnos";
            this.cbAlumnos.Size = new System.Drawing.Size(209, 24);
            this.cbAlumnos.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ver préstamos por alumno";
            // 
            // cbAlumnosPrest
            // 
            this.cbAlumnosPrest.FormattingEnabled = true;
            this.cbAlumnosPrest.Location = new System.Drawing.Point(18, 227);
            this.cbAlumnosPrest.Name = "cbAlumnosPrest";
            this.cbAlumnosPrest.Size = new System.Drawing.Size(209, 24);
            this.cbAlumnosPrest.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(18, 272);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 148);
            this.listBox1.TabIndex = 5;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 462);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAlquilarLibro);
            this.Controls.Add(this.lblFechaDev);
            this.Controls.Add(this.cbAlumnosPrest);
            this.Controls.Add(this.cbAlumnos);
            this.Controls.Add(this.cbLibros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Prestamos";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbLibros;
        private System.Windows.Forms.Label lblFechaDev;
        private System.Windows.Forms.Button btnAlquilarLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbAlumnos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlumnosPrest;
        private System.Windows.Forms.ListBox listBox1;
    }
}