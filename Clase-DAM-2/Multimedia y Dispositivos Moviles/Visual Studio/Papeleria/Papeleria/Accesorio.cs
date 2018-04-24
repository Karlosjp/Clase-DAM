using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Accesorio : Producto
    {
        private double peso;
        private string material;

        public Accesorio()
        {
            peso = 0;
            material = "";
        }
        public Accesorio(string n, string t, int c, double p, string material, double peso)
            : base(n, t, c, p)
        {
            this.material = material;
            this.peso = peso;
        }

        public string Material
        {
            get { return material; }
        }

        public double Peso
        {
            get { return peso; }
        }
    }
}
