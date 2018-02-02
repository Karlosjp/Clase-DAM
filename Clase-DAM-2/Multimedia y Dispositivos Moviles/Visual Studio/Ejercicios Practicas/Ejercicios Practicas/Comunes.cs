using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Comunes
    {
        protected string marca, nombre;
        protected int ram;
        protected double precio;

        public Comunes()
        {
            marca = "";
            nombre = "";
            ram = 0;
            precio = 0;
        }

        public Comunes(string m, string n, int r, double p)
        {
            marca = m;
            nombre = n;
            ram = r;
            precio = p;
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Ram
        {
            get { return ram; }
            set { ram += value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio += value; }
        }

    }
}