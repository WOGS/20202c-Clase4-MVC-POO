using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class GastosServicios
    {
        private static List<Gasto> Lista = new List<Gasto>();

        static GastosServicios()
        {
            Gasto g = new Gasto()
            {
                Fecha = DateTime.Now,
                Descripcion = "Mantenimiento",
                Monto = 100
            };
            Alta(g);
            Alta(g);
            Alta(g);
            Alta(g);
        }
        public static void Alta(Gasto gasto)
        {
            Gasto g = new Gasto();
            g.Descripcion = gasto.Descripcion;
            g.Fecha = gasto.Fecha;
            g.Monto = gasto.Monto;
            g.Id = Guid.NewGuid();
            Lista.Add(g);
        }

        public static Gasto ObtenerPorId(Guid id)
        {
            return Lista.Find(o => o.Id == id);
        }

        public static List<Gasto> ObtenerTodos()
        {
            return Lista;
        }

    }
}
