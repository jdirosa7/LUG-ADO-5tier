using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JDR.LUG.Clase8.Ej1.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos al = new Alumnos();
            al.MdiParent = this;
            al.Show();
        }

        private void obrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Libros lib = new Libros();
            lib.MdiParent = this;
            lib.Show();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejemplares ej = new Ejemplares();
            ej.MdiParent = this;
            ej.Show();
        }

        private void préstamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prestamos p = new Prestamos();
            p.MdiParent = this;
            p.Show();
        }
    }
}
