using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGB.Entidades
{
    public class Usuarios
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; } = null!;
        [EmailAddress,MaxLength(150)]
        public string Correo { get; set; } = null!;
        [Phone]
        public string Telefono { get; set; } = null!;
        [MaxLength(150)]
        public string Direccion { get; set; } = null!;

    }
}
