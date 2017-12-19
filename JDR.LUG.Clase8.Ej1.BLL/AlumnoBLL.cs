using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.Mapper;

namespace JDR.LUG.Clase8.Ej1.BLL
{
    public class AlumnoBLL
    {
        AlumnoMPP alMpp = new AlumnoMPP();
        public void Insertar(Alumno al)
        {            
            alMpp.InsertarActualizar(al);
        }

        public void Actualizar(Alumno al)
        {
            alMpp.InsertarActualizar(al);
        }

        public void Eliminar(Alumno al)
        {
            alMpp.Eliminar(al);
        }

        public List<Alumno> ObtenerAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos = alMpp.ObtenerAlumnos();

            return alumnos;
        }

        public Alumno ObtenerAlumno(string nombre)
        {
            List<Alumno> alumnos = new List<Alumno>();
            Alumno al = new Alumno();

            alumnos = alMpp.ObtenerAlumnos();
            if (alumnos != null && alumnos.Count > 0)
            {
                foreach (Alumno item in alumnos)
                {
                    if (item.Nombre == nombre)
                    {
                        al = item;
                        break;
                    }
                }
            }

            return al;
        }
    }
}
