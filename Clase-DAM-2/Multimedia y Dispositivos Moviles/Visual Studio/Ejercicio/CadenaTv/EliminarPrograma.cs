using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class EliminarPrograma : GModificarDatos
    {
        // Metodos
        public void Borrar()
        {
            IntroduceDia();
            IntroduceHora();
        }
    }
}
