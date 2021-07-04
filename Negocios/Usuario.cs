using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class Usuario
    {
        public static bool Validar(string usuario, string password)
        {
            return Usuario_m.Validar(usuario, password);
        }
    }
}
