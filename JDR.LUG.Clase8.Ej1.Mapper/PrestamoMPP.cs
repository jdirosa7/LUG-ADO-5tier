using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.DAL;
using System.Collections;

namespace JDR.LUG.Clase8.Ej1.Mapper
{
    public class PrestamoMPP
    {
        Datos data = new Datos();
        public void Insertar(Prestamo p)
        {
            Hashtable table = new Hashtable();
            table.Add("@IDAlumno", p.IDAlumno);
            table.Add("@IDEjemplar", p.IDEjemplar);
            table.Add("@FechaPrestamo", p.FechaPrestamo.ToString("dd-MM-yyyy"));
            table.Add("@FechaDevolucion", p.FechaDevolucion.ToString("dd-MM-yyyy"));

            string store = "s_InsertarPrestamo";

            data.Escribir(store, table);
        }
    }
}
