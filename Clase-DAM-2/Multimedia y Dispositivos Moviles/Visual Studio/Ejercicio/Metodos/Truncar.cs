using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Truncar
    {
        // Atributos
        private double real;
        private int entero;

        // Get and Set
        public double getReal()
        {
            return real;
        }

        public double getEntero()
        {
            return entero;
        }

        public void setReal(double real)
        {
            this.real = real;
        }

        public void setEntero(int entero)
        {
            this.entero = entero;
        }

        // Metodos
        public double TruncarACero()
        {
            return Math.Truncate(real);
        }

        public void TruncarACero(out int ent)
        {
            ent = (int)TruncarACero();
        }

        public void TruncarACero(ref double dou)
        {
            dou = Math.Truncate(dou);
        }

        public double TruncaraElegir()
        {
            entero = (int)Math.Pow(10, entero);

            return Math.Truncate(real * entero) / entero;
        }

        public void TruncaraElegir(out double dou)
        {
            dou = TruncaraElegir();
        }

        public void TruncaraElegirDos(ref double dou)
        {
            dou = Math.Truncate(dou * entero) / entero;
        }       
    }
}
