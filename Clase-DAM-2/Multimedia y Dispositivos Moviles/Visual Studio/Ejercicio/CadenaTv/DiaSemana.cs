using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class DiaSemana
    {
        private int numeroDiaSemana;
        private string nombreDiaSemana;

        int[] hora = { 8, 10, 14, 16, 20, 24 };

        static private Programa prorPh = new Programa();
        static private Programa prorMt = new Programa();
        static private Programa prorMd = new Programa();
        static private Programa prorTd = new Programa();
        static private Programa prorNc = new Programa();

        private Programa[] programacion = { prorPh, prorMt, prorMd, prorTd, prorNc };

        // Constructor
        public DiaSemana()
        {
            numeroDiaSemana = 1;
            nombreDiaSemana = "";
        }

        public DiaSemana(int numD, string nomD)
        {
            numeroDiaSemana = numD;
            nombreDiaSemana = nomD;
        }

        // Metodos
        public void CrearPrograma(Programa pro)
        {
            for (int i = 0; i < hora.Length; i++)
                if (hora[i] == pro.getHInicio())
                {
                    programacion[i] = pro;
                }
        }
    }
}
