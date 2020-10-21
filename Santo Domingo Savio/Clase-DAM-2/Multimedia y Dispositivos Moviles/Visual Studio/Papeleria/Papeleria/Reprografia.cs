using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Reprografia : Producto
    {
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

        public string material { get; }

        public string color { get; }

        public string fabricante { get; }

        // Devuelve los datos del producto
        // Formato Reprografia (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Material:(5)Color:(6)Fabricante
        public override string Escribir()
        {
            return base.Escribir() + ":" + material + ":" + color + ":" + fabricante;
        }
    }
}
