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
       public void ActualizarUsuario(int id, string nombre, string correo, string telefono,string direccion)
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Usuarios xUsuario = db.Usuarios.Where(x => x.Id == id).FirstOrDefault();

                xUsuario.Nombre = nombre;
                xUsuario.Correo = correo;
                xUsuario.Telefono = telefono;
                xUsuario.Direccion = direccion;

                db.Entry(xUsuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }

    }
}
