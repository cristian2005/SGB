using SGB;
using SGB.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudUsuario
{
    public class UpdateUsuario
    {
       public void ActualizarUsuario()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Usuarios xUsuario = db.Usuarios.Where(x => x.Id == 1).FirstOrDefault();
                xUsuario.Nombre = "h";
                xUsuario.Correo = "h";
                xUsuario.Telefono = "h";
                xUsuario.Direccion = "h";

                db.Entry(xUsuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }


    }
}
