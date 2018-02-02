using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Movil : Comunes
    {
        private double duracionBateria, almacenamiento;
        private string so;

        public Movil() : base()
        {
            so = "";
            duracionBateria = 0;
        }

        public Movil(string m, string n, int r, double p, double db, double al, string so) : base(m, n, r, p)
        {
            this.so = so;
            duracionBateria = db;
            almacenamiento = al;
        }

        public string So
        {
            get { return so; }
            set { so = value; }
        }

        public double DuracionBateria
        {
            get { return duracionBateria; }
            set { duracionBateria = value; }
        }

        public double Almacenamiento
        {
            get { return almacenamiento; }
            set { almacenamiento = value; }
        }
    }
}
