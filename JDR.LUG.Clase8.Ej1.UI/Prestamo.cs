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
    public partial class Prestamos : Form
    {
        AlumnoBLL aBll = new AlumnoBLL();
        LibroBLL lBll = new LibroBLL();
        EjemplarBLL ejBll = new EjemplarBLL();
        PrestamoBLL pBll = new PrestamoBLL();

        Ejemplar ej = new Ejemplar();
        public Prestamos()
        {
            InitializeComponent();
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            CargarAlumnos();
            CargarLibros();

            lblFechaDev.Text = DateTime.Today.AddDays(7).ToString("dd-MM-yyyy");
        }

        private void CargarAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos = aBll.ObtenerAlumnos();

            List<string> nombres = new List<string>();

            if(alumnos.Count > 0)
            {
                foreach (Alumno item in alumnos)
                {
                    nombres.Add(item.Nombre);
                }
            }

            cbAlumnos.DataSource = null;
            cbAlumnosPrest.DataSource = null;

            cbAlumnos.DataSource = nombres;
            cbAlumnosPrest.DataSource = nombres;
        }

        private void CargarLibros()
        {
            List<Libro> libros = new List<Libro>();
            libros = lBll.ObtenerLibros();

            List<string> nombres = new List<string>();

            if(libros.Count > 0)
            {
                foreach (Libro item in libros)
                {
                    nombres.Add(item.Titulo);
                }
            }

            cbLibros.DataSource = null;
            cbLibros.DataSource = nombres;
        }

        private void btnAlquilarLibro_Click(object sender, EventArgs e)
        {
            Prestamo p = new Prestamo();
            string alumno = cbAlumnos.SelectedItem.ToString();
            Alumno al = aBll.ObtenerAlumno(alumno);           

            string libro = cbLibros.SelectedItem.ToString();
            Libro lib = lBll.ObtenerLibro(libro);

            Ejemplar ej = ejBll.ObtenerEjemplar(lib.ID);

            p.IDAlumno = al.ID;
            p.FechaPrestamo = DateTime.Today;
            p.FechaDevolucion = Convert.ToDateTime(lblFechaDev.Text);
            p.IDEjemplar = ej.ID;

            pBll.Insertar(p);

            ej.Prestado = true;

            ejBll.Actualizar(ej);
        }

        private void cbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            string titulo = cbLibros.SelectedItem.ToString();

            Libro lib = lBll.ObtenerLibro(titulo);
            ej = ejBll.ObtenerEjemplarLibre(lib.ID);

            if(ej == null)
            {
                MessageBox.Show("No hay ejemplares disponibles");
                btnAlquilarLibro.Enabled = false;
                return;
            }

            btnAlquilarLibro.Enabled = true;            
        }
    }
}
