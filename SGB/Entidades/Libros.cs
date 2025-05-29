using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGB.Entidades
{
    internal class Libros
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Autor { get; set; } = null!;

        [MaxLength(150)]
        public string Titulo { get; set; } = null!;
        [MaxLength(100)]
        public string Genero { get; set; } = null!; 
        
    }
}
