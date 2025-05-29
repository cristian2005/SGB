using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGB.Entidades
{
    public class Prestamos
    {
        public int Id { get; set; }
        public DateTime Fecha_De_Inicio { get; set; }

        public DateTime Fecha_Limite { get;set; }
    }
}
