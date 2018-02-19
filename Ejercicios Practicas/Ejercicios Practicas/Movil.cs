using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Movil : Producto
    {
        private double duracionBateria, almacenamiento;
        private string so;

        public Movil() : base()
        {
            so = "";
            duracionBateria = 0;
        }

        public Movil(int id, string m, string n, int r, double p, double db, double al, string so) : base(id, m, n, r, p)
        {
            this.so = so;
            duracionBateria = db;
            almacenamiento = al;
        }

        override public string So
        {
            get { return so; }
        }

        override public double DuracionBateria
        {
            get { return duracionBateria; }
        }

        override public double Almacenamiento
        {
            get { return almacenamiento; }
        }
    }
}
