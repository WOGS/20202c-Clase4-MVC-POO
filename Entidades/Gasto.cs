using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gasto
    {
        public Guid Id { get; set; }
        public double Monto { get; set; }
        public string Descripcion { get; set; }
        public bool Recurrente { get; set; }

        [Display(Name ="Fecha del Gasto")]
        public DateTime Fecha { get; set; }
    }
}
