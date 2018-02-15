using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Tablet : Producto
    {
        private double resolucion, duracionBateria;

        public Tablet() : base()
        {
            resolucion = 0;
            duracionBateria = 0;
        }

        public Tablet(int id, string m, string n, int r, double p, double db, double re) : base(id, m, n, r, p)
        {
            resolucion = re;
            duracionBateria = db;
        }

        public double Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }

        public double DuracionBateria
        {
            get { return duracionBateria; }
            set { duracionBateria = value; }
        }
    }
}
