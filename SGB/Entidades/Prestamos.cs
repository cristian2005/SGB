using SGB.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGB.Datos.Entidades
{
    public class Prestamos
    {
        public int Id { get; set; }
        public DateTime Fecha_De_Inicio { get; set; }
        public DateTime Fecha_Limite { get; set; }

        public int UsuarioId { get; set; }
        public Usuarios Usuario { get; set; } = null!;

        public int LibroId { get; set; }
        public Libros Libro { get; set; }

    }
}
