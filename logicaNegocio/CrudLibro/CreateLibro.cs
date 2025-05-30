using SGB.Entidades;
using SGB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudLibro
{
    internal class CreateLibro
    {
        public void CrearLibro()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                Libros xLibro = new Libros();
                xLibro.Autor = "Autor";
                xLibro.Titulo = "titulo";
                xLibro.Genero = "Genero";
                db.SaveChanges();
            }
        }
    }
}
