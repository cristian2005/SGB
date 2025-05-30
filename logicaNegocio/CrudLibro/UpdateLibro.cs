using SGB.Entidades;
using SGB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudLibro
{
    internal class UpdateLibro
    {
        public void ActualizarLibro()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Libros xLibro = db.Libros.Where(x => x.Id == 1).FirstOrDefault();
                xLibro.Titulo = "Titulo";
                xLibro.Autor = "Autor";
                xLibro.Genero = "Genero";

                db.Entry(xLibro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
