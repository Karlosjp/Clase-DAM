using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Producto
    {
        private string nombre, tipo;
        private int codigo;
        private double precio;

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

        public string Nombre
        {
            get { return nombre; }
        }

        public string Tipo
        {
            get { return tipo; }
        }

        public int Codigo
        {
            get { return codigo; }
        }

        public double Precio
        {
            get { return precio; }
        }
    }
}
