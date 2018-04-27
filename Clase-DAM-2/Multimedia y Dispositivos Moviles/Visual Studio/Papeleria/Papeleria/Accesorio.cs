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
        public Accesorio(string n, string t, int c, double p, double peso, string material)
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

        // Devuelve los datos del producto
        // Formato Accesorio (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Material
        public override string Escribir()
        {
            return base.Escribir() + ":" + peso + ":" + material;
        }
    }
}
