using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Consumible : Producto
    {
        private DateTime fechaFabricacion;
        private double peso;

        public Consumible()
            : base()
        {
            fechaFabricacion = DateTime.Today;
            peso = 0;
        }

        public Consumible(string n, string t, int c, double p, DateTime fechaFabricacion, double peso)
            : base(n,t,c,p)
        {
            this.fechaFabricacion = fechaFabricacion;
            this.peso = peso;
        }
    }
}
