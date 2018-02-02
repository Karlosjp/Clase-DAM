using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Ordenador : Comunes
    {
        private double velocidad;
        private int puertos;

        public Ordenador() : base()
        {
            velocidad = 0;
            puertos = 0;
        }

        public Ordenador(string m, string n, int r, double p, double ve, int pu) : base(m, n, r, p)
        {
            velocidad = ve;
            puertos = pu;
        }

        public double Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }

        public int Puertos
        {
            get { return puertos; }
            set { puertos = value; }
        }
    }
}
