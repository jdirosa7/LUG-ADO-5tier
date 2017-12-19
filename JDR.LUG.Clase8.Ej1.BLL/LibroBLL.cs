using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.Mapper;
using System.Data;
using System.Collections;
using JDR.LUG.Clase8.Ej1.Mapper;

namespace JDR.LUG.Clase8.Ej1.BLL
{
    public class LibroBLL
    {
        LibroMPP lMpp = new LibroMPP();
        public void Insertar(Libro lib)
        {
            lMpp.InsertarActualizar(lib);
        }

        public void Actualizar(Libro lib)
        {
            lMpp.InsertarActualizar(lib);
        }

        public void Eliminar(Libro lib)
        {
            lMpp.Eliminar(lib);
        }

        public List<Libro> ObtenerLibros()
        {
            List<Libro> libros = new List<Libro>();
            libros = lMpp.ObtenerLibros();

            return libros;
        }

        public Libro ObtenerLibro(string titulo)
        {
            List<Libro> libros = new List<Libro>();
            Libro lib = new Libro();

            libros = lMpp.ObtenerLibros();

            if(libros != null && libros.Count > 0)
            {
                foreach (Libro item in libros)
                {
                    if (item.Titulo == titulo)
                    {
                        lib = item;
                        break;
                    }
                }
            }

            return lib;
        }

        public Libro ObtenerLibro(int idLibro)
        {
            List<Libro> libros = new List<Libro>();
            Libro lib = new Libro();

            libros = lMpp.ObtenerLibros();

            if (libros != null && libros.Count > 0)
            {
                foreach (Libro item in libros)
                {
                    if (item.ID == idLibro)
                    {
                        lib = item;
                        break;
                    }
                }
            }

            return lib;
        }
    }
}
