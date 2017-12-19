using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.DAL;
using System.Collections;
using System.Data;

namespace JDR.LUG.Clase8.Ej1.Mapper
{
    public class LibroMPP
    {
        Datos data = new Datos();
        public void InsertarActualizar(Libro lib)
        {
            Hashtable table = new Hashtable();

            string store = "s_InsertarLibro";

            if(lib.ID != 0)
            {
                store = "s_ActualizarLibro";
                table.Add("@Id_Libro", lib.ID);
            }

            table.Add("@Titulo", lib.Titulo);
            table.Add("@Autor", lib.Autor);
            table.Add("@Tematica", lib.Tematica);

            data.Escribir(store, table);
        }

        public void Eliminar(Libro lib)
        {
            Hashtable table = new Hashtable();

            string store = "s_EliminarLibro";

            table.Add("@Id_Libro", lib.ID);

            data.Escribir(store, table);
        }        

        public List<Libro> ObtenerLibros()
        {
            List<Libro> libros = new List<Libro>();

            DataTable dt = new DataTable();

            string store = "s_ObtenerLibros";

            dt = data.Leer(store);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Libro l = new Libro();
                    l.ID = Convert.ToInt32(row["Id_Libro"].ToString());
                    l.Titulo = row["Titulo"].ToString();
                    l.Autor = row["Autor"].ToString();
                    l.Tematica = row["Tematica"].ToString();

                    libros.Add(l);
                }
            }

            return libros;
        }
    }
}
