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
    public class EjemplarMPP
    {
        Datos data = new Datos();
        public void InsertarActualizar(Ejemplar ej)
        {
            Hashtable table = new Hashtable();

            string store = "s_InsertarEjemplar";

            if(ej.ID != 0)
            {
                store = "s_ActualizarEjemplar";
                table.Add("@Id_Ejemplar", ej.ID);
            }

            table.Add("@ISBN", ej.ISBN);
            table.Add("@Id_Libro", ej.IDLibro);
            table.Add("@Prestado", (ej.Prestado)?1:0);

            data.Escribir(store, table);
        }

        public void Eliminar(Ejemplar ej)
        {
            Hashtable table = new Hashtable();

            string store = "s_EliminarEjemplar";

            table.Add("@Id_Ejemplar", ej.ID);

            data.Escribir(store, table);
        }

        public List<Ejemplar> ObtenerEjemplares()
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            DataTable dt = new DataTable();

            string store = "s_ObtenerEjemplares";

            dt = data.Leer(store);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Ejemplar ej = new Ejemplar();
                    ej.ID = Convert.ToInt32(row["Id_Ejemplar"].ToString());
                    ej.IDLibro = Convert.ToInt32(row["Id_Libro"].ToString());
                    ej.ISBN = row["ISBN"].ToString();
                    ej.Prestado = Convert.ToBoolean(row["Prestado"].ToString());

                    ejemplares.Add(ej);
                }
            }

            return ejemplares;
        }        
    }
}
