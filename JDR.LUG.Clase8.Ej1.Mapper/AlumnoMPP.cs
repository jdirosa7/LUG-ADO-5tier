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
    public class AlumnoMPP
    {
        Datos data = new Datos();
        public void InsertarActualizar(Alumno al)
        {            
            Hashtable table = new Hashtable();

            string store = "s_InsertarAlumno";

            if(al.ID != 0)
            {
                table.Add("@Id_Alumno", al.ID);
                store = "s_ActualizarAlumno";
            }

            table.Add("@Nombre", al.Nombre);
            table.Add("@Apellido", al.Apellido);
            table.Add("@DNI", al.DNI);

            data.Escribir(store, table);
        }

        public void Eliminar(Alumno al)
        {
            string store = "s_EliminarAlumno";

            Hashtable table = new Hashtable();
            table.Add("@Id_Alumno", al.ID);

            data.Escribir(store, table);
        }       

        public List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();

            string store = "s_ObtenerAlumnos";

            DataTable dt = new DataTable();
            dt = data.Leer(store);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Alumno al = new Alumno();
                    al.ID = Convert.ToInt32(row["Id_Alumno"].ToString());
                    al.Nombre = row["Nombre"].ToString();
                    al.Apellido = row["Apellido"].ToString();
                    al.DNI = Convert.ToInt32(row["DNI"].ToString());

                    alumnos.Add(al);
                }
            }

            return alumnos;
        }
    }
}
