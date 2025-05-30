using SGB.Entidades;
using SGB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudUsuario
{
    public class DeleteUsuario
    {
        public void EliminarUsuario()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Usuarios xUsuario = db.Usuarios.Where(x => x.Id == 1).FirstOrDefault();
                db.Usuarios.Remove(xUsuario);
                
                db.SaveChanges();
            }
        }
    }
}
