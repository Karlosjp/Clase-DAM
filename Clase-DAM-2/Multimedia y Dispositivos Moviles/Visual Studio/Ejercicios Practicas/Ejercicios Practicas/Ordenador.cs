using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Ordenador : Producto
    {
        private double velocidad;
        private int puertos;

        public Ordenador() : base()
        {
            velocidad = 0;
            puertos = 0;
        }

        public Ordenador(int id, string m, string n, int r, double p, double ve, int pu) : base(id, m, n, r, p)
        {
            velocidad = ve;
            puertos = pu;
        }

        public double Velocidad
        {
            get { return velocidad; }
        }

        public int Puertos
        {
            get { return puertos; }
        }
    }
}
