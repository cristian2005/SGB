using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGB.Entidades
{
    public class Disponibilidad
    {
        public int id { get; set; }
        public int cantidad { get; set; }

        [ForeignKey("libro")]
        public int libroId { get; set; }
        public Libros libro { get; set; } = null!;

    }
}
