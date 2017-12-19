using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR.LUG.Clase8.Ej1.Entities
{
    public class Alumno
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public double DNI { get; set; }

        public Alumno() { }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}
