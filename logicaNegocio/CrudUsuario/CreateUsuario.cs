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
        public void CrearUsuario()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Usuarios xUsuario = new Usuarios();
                xUsuario.Nombre = "hector";
                xUsuario.Correo = "hector@gmail.com";
                xUsuario.Telefono = "8297144352";
                xUsuario.Direccion = "calle 1ra";

                db.Usuarios.Add(xUsuario);
                db.SaveChanges();
            }
        }
    }
}
