using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.BLL;

namespace JDR.LUG.Clase8.Ej1.UI
{
    public partial class Libros : Form
    {
        LibroBLL lBll = new LibroBLL();
        public Libros()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Libro lib = new Libro();
            lib.Titulo = txtTitulo.Text;
            lib.Autor = txtAutor.Text;
            lib.Tematica = cbTematicas.SelectedItem.ToString();

            lBll.Insertar(lib);

            ObtenerLibros();
        }

        private void ObtenerLibros()
        {
            List<Libro> libros = new List<Libro>();
            libros = lBll.ObtenerLibros();

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = libros;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Libro lib = new Libro();
            lib.ID = Convert.ToInt32(txtID.Text);
            lib.Titulo = txtTitulo.Text;
            lib.Autor = txtAutor.Text;
            lib.Tematica = cbTematicas.SelectedItem.ToString();

            lBll.Actualizar(lib);

            ObtenerLibros();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Libro lib = new Libro();
            lib.ID = Convert.ToInt32(txtID.Text);

            lBll.Eliminar(lib);

            ObtenerLibros();
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            CargarTematicas();
            ObtenerLibros();
        }

        private void CargarTematicas()
        {
            cbTematicas.Items.Add("Terror");
            cbTematicas.Items.Add("Literatura Clásica");
            cbTematicas.Items.Add("Historia");
        }

        private void dgvLibros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvLibros.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
            txtAutor.Text = dgvLibros.Rows[e.RowIndex].Cells["Autor"].Value.ToString();
            cbTematicas.Text = dgvLibros.Rows[e.RowIndex].Cells["Tematica"].Value.ToString();

            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
