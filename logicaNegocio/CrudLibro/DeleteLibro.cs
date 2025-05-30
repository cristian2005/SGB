using SGB.Entidades;
using SGB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudLibro
{
    public class DeleteLibro
    {
        public void EliminarLibroo()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Libros xLibro = db.Libros.Where(x => x.Id == 1).FirstOrDefault();
                db.Libros.Remove(xLibro);

                db.SaveChanges();
            }
        }
    }
}
