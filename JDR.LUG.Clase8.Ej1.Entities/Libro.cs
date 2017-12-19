using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDR.LUG.Clase8.Ej1.Entities
{
    public class Libro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Tematica { get; set; }

        public Libro() { }
    }
}
