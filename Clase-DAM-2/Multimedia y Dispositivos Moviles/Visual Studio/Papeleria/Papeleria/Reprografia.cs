using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Reprografia : Producto
    {
        private string material, color, fabricante;

        public Reprografia()
        {
            this.material = "";
            this.color = "";
            this.fabricante = "";
        }

        public Reprografia(string n, string t, int c, double p, string material, string color, string fabricante)
            : base(n, t, c, p)
        {
            this.material = material;
            this.color = color;
            this.fabricante = fabricante;
        }

        public string Material
        {
            get { return material; }
        }

        public string Color
        {
            get { return color; }
        }

        public string Fabricante
        {
            get { return fabricante; }
        }
    }
}
