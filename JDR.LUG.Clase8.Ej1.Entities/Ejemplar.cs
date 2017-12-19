using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR.LUG.Clase8.Ej1.Entities
{
    public class Ejemplar
    {
        public int ID { get; set; }
        public int IDLibro { get; set; }
        public string TituloLibro { get; set; }
        public string ISBN { get; set; }
        public bool Prestado { get; set; }

        public Ejemplar() { }
    }
}
