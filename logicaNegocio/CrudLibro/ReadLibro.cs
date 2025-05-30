using SGB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudLibro
{
    public class ReadLibro
    {
       
            public void Readlibro()
            {
                using (BibliotecaBDContext db = new BibliotecaBDContext())
                {
                    var lst = db.Libros.ToList();
                }
            }

        
    }
}
