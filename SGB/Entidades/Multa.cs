using SGB.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Summary description for Class1
/// </summary>
public class Multa
{
    public int Id { get; set; }

    public double Monto { get; set; }

    public int UsuarioId { get; set; }

    [ForeignKey("UsuarioId")]
    public Usuarios Usuario { get; set; } = null!;

}
