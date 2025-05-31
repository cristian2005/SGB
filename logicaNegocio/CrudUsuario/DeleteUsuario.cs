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
        public void EliminarUsuario(int id )
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Usuarios xUsuario = new Usuarios()
                {
                    Id = id
                };

                var elimador = db.Usuarios.Where ( x => x.Id == id );

                db.Usuarios.Remove(xUsuario);
                
                db.SaveChanges();
            }
        }
    }
}
