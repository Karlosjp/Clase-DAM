using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Potencia
    {
        private int dBase, dExp;

        public int getDExp()
        {
            return dExp;
        }

        public Potencia()
        {
            dBase = 0;
            dExp = 0;
        }

        public Potencia(int b, int e)
        {
            dBase = b;
            dExp = e;
        }

        public Potencia Multiplicar(Potencia p)
        {
            Potencia nueva = new Potencia();

            if (this.dBase == p.dBase)
            {
                nueva.dBase = this.dBase;
                nueva.dExp = this.dExp + p.dExp;
            }

            return nueva;
        }

        public Potencia Dividir(Potencia p)
        {
            Potencia nueva = new Potencia();

            if (this.dBase == p.dBase)
            {
                nueva.dBase = this.dBase;
                nueva.dExp = this.dExp - p.dExp;
            }

            return nueva;
        }

        public void Elevar(int e)
        {
            dBase *= e;
        }

        public double valor()
        {
            double valor = 1;

            for (int i = 0; i < dExp; i++)
                valor *= dBase;
                
            return valor;
        }

        public string Escribir()
        {
            return "Base: " + dBase + " Exponente: " + dExp;
        }
    }
}
