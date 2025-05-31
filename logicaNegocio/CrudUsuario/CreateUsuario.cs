using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using SGB;
using SGB.Entidades;

namespace logicaNegocio.CrudUsuario
{
  public class CreateUsuario
    {
        public void CrearUsuario(string nombre, string correo, string telefono, string direccion)
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Usuarios xUsuario = new Usuarios()
                {
                    Nombre = nombre,
                    Correo = correo,
                    Telefono = telefono,
                    Direccion = direccion
                };
                db.Usuarios.Add(xUsuario);
                db.SaveChanges();
            }
        }
    }
}
