using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class Dia
    {
        private string nombreDia;

        static private Programa prorPh = new Programa(8,10);
        static private Programa prorMt = new Programa(10,14);
        static private Programa prorMd = new Programa(14,16);
        static private Programa prorTd = new Programa(16,20);
        static private Programa prorNc = new Programa(20,24);

        private Programa[] programacion = { prorPh, prorMt, prorMd, prorTd, prorNc };

        //Geters
        public string GetDia()
        {
            return nombreDia;
        }

        // Constructor
        public Dia()
        {
            nombreDia = "";
        }

        public Dia(string nomD)
        {
            nombreDia = nomD;
        }

        // Metodos
        public void AnadirPrograma(Programa pro)
        {
            for (int i = 0; i < programacion.Length; i++)
                if (programacion[i].getHInicio() == pro.getHInicio())
                    programacion[i] = pro;
        }
    }
}
