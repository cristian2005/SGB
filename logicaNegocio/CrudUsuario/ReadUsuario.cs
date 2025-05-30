using SGB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudUsuario
{
    public class ReadUsuario
    {
        public void Readusuario()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                var lst = db.Usuarios.ToList(); 
            }
        }

    }
}
