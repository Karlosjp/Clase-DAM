using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class MostrarProgramacion : GMostrarDatos
    {
        public void MosProgDiaria(Dia[] sem)
        {
            semana = sem;
            IntroduceDia();
            buscarDia();
            mostrarPro();
        }

        public void MosProgDia(Dia[] sem)
        {
            semana = sem;
            IntroduceDia();
            buscarDia();
        }
    }
}
