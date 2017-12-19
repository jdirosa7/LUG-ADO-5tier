using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JDR.LUG.Clase8.Ej1.Entities;
using JDR.LUG.Clase8.Ej1.Mapper;

namespace JDR.LUG.Clase8.Ej1.BLL
{
    public class EjemplarBLL
    {
        EjemplarMPP ejMpp = new EjemplarMPP();
        public void Insertar(Ejemplar ej)
        {
            ejMpp.InsertarActualizar(ej);
        }

        public void Actualizar(Ejemplar ej)
        {
            ejMpp.InsertarActualizar(ej);
        }

        public void Eliminar(Ejemplar ej)
        {
            ejMpp.Eliminar(ej);
        }

        public List<Ejemplar> ObtenerEjemplares()
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();

            ejemplares = ejMpp.ObtenerEjemplares();

            return ejemplares;
        }

        public Ejemplar ObtenerEjemplar(int IDLibro)
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            Ejemplar ej = new Ejemplar();

            ejemplares = ejMpp.ObtenerEjemplares();
            if(ejemplares.Count > 0)
            {
                foreach (Ejemplar item in ejemplares)
                {
                    if (item.IDLibro == IDLibro)
                    {
                        ej = item;
                        break;
                    }
                }
            }

            return ej;
        }

        public Ejemplar ObtenerEjemplarLibre(int IDLibro)
        {
            List<Ejemplar> ejemplares = new List<Ejemplar>();
            Ejemplar ej = null;

            ejemplares = ejMpp.ObtenerEjemplares();
            if (ejemplares.Count > 0)
            {
                foreach (Ejemplar item in ejemplares)
                {
                    if (item.IDLibro == IDLibro && item.Prestado == false)
                    {
                        ej = new Ejemplar();
                        ej = item;
                        break;
                    }
                }
            }

            return ej;
        }
    }
}
