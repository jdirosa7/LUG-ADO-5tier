using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR.LUG.Clase8.Ej1.Entities
{
    public class Prestamo
    {
        public int ID { get; set; }
        public int IDAlumno { get; set; }
        public int IDEjemplar { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public Prestamo() { }
    }
}
