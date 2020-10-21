using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Producto
    {
        public Producto()
        {
            nombre = "";
            tipo = "";
            codigo = 0;
            precio = 0;
        }

        public Producto(string nombre, string tipo, int codigo, double precio)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.codigo = codigo;
            this.precio = precio;
        }

        public string nombre { get; }

        public string tipo { get; }

        public int codigo { get; }

        public double precio { get; }

        // Devuelve los datos del producto
        virtual public string Escribir()
        {
            return nombre + ":" + tipo + ":" + codigo + ":" + precio;
        }
    }
}
