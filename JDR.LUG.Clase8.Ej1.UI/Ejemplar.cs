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
    public partial class Ejemplares : Form
    {
        LibroBLL libBll = new LibroBLL();
        EjemplarBLL ejBll = new EjemplarBLL();
        public Ejemplares()
        {
            InitializeComponent();
        }

        private void Ejemplar_Load(object sender, EventArgs e)
        {
            ObtenerEjemplares();
            CargarLibros();
        }

        private void ObtenerEjemplares()
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            ejemplares = ejBll.ObtenerEjemplares();

            if(ejemplares != null && ejemplares.Count > 0)
            {
                foreach (Ejemplar ej in ejemplares)
                {
                    Libro lib = ObtenerLibroPorId(ej.IDLibro);
                    ej.TituloLibro = lib.Titulo;
                }
            }
            
            dgvEjemplares.DataSource = null;
            dgvEjemplares.DataSource = ejemplares;
        }

        private void CargarLibros()
        {
            List<Libro> libros = new List<Libro>();
            List<string> librosTitulo = new List<string>();

            libros = libBll.ObtenerLibros();

            if(libros != null && libros.Count > 0)
            {
                foreach (Libro item in libros)
                {
                    string titulo = item.Titulo.ToString();
                    librosTitulo.Add(titulo);
                }
            }

            cbLibros.DataSource = null;
            cbLibros.DataSource = librosTitulo;            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Ejemplar ej = new Ejemplar();
            ej.ISBN = txtIsbn.Text;
            Libro lib = ObtenerLibro(cbLibros.SelectedItem.ToString());

            ej.IDLibro = lib.ID;
            ej.TituloLibro = lib.Titulo;

            ejBll.Insertar(ej);

            ObtenerEjemplares();
        }

        private Libro ObtenerLibro(string titulo)
        {
            Libro lib = new Libro();

            lib = libBll.ObtenerLibro(titulo);

            return lib;
        }

        private void dgvEjemplares_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idLibro = Convert.ToInt32(dgvEjemplares.Rows[e.RowIndex].Cells["IDLibro"].Value.ToString());
            string isbn = dgvEjemplares.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            int idEjemplar = Convert.ToInt32(dgvEjemplares.Rows[e.RowIndex].Cells["ID"].Value.ToString());

            Libro lib = ObtenerLibroPorId(idLibro);

            cbLibros.Text = lib.Titulo;
            txtIsbn.Text = isbn;
            txtID.Text = idEjemplar.ToString();

            btnEliminar.Enabled = true;
        }

        private Libro ObtenerLibroPorId(int idLibro)
        {
            Libro lib = new Libro();

            lib = libBll.ObtenerLibro(idLibro);

            return lib;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ejemplar ej = new Ejemplar();
            ej.ID = Convert.ToInt32(txtID.Text);

            ejBll.Eliminar(ej);

            ObtenerEjemplares();
        }
    }
}
