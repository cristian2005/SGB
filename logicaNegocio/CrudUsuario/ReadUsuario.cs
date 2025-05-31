using SGB;
using SGB.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace logicaNegocio.CrudUsuario
{
    public class ReadUsuario
    {
        public List<Usuarios> Readusuario()
        {
            using (BibliotecaBDContext db = new BibliotecaBDContext())
            {
                return db.Usuarios.ToList();
            }
        }

    }
}
