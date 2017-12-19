namespace JDR.LUG.Clase8.Ej1.UI
{
    partial class Ejemplares
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
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLibros = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEjemplares = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(76, 111);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(204, 22);
            this.txtIsbn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Libro";
            // 
            // cbLibros
            // 
            this.cbLibros.FormattingEnabled = true;
            this.cbLibros.Location = new System.Drawing.Point(76, 74);
            this.cbLibros.Name = "cbLibros";
            this.cbLibros.Size = new System.Drawing.Size(204, 24);
            this.cbLibros.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ejemplar";
            // 
            // dgvEjemplares
            // 
            this.dgvEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEjemplares.Location = new System.Drawing.Point(15, 249);
            this.dgvEjemplares.Name = "dgvEjemplares";
            this.dgvEjemplares.RowTemplate.Height = 24;
            this.dgvEjemplares.Size = new System.Drawing.Size(832, 150);
            this.dgvEjemplares.TabIndex = 24;
            this.dgvEjemplares.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEjemplares_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnInsertar);
            this.panel1.Location = new System.Drawing.Point(15, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 65);
            this.panel1.TabIndex = 23;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(132, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 34);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(17, 14);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(109, 34);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(76, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 22);
            this.txtID.TabIndex = 1;
            // 
            // Ejemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 480);
            this.Controls.Add(this.dgvEjemplares);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbLibros);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Ejemplares";
            this.Text = "Ejemplar";
            this.Load += new System.EventHandler(this.Ejemplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEjemplares)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLibros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEjemplares;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
    }
}