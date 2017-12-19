using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.Mapper;

namespace JDR.LUG.Clase8.Ej1.BLL
{
    public class PrestamoBLL
    {
        PrestamoMPP pMpp = new PrestamoMPP();
        public void Insertar(Prestamo p)
        {
            pMpp.Insertar(p);
        }
    }
}
