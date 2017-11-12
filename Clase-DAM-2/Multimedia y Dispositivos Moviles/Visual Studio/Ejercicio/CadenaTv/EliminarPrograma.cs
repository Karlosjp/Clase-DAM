using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class EliminarPrograma : GeneralDatos
    {
        // Metodos
        public void Borrar()
        {
            IntroduceDia();
            IntroduceHora();
        }
    }
}
