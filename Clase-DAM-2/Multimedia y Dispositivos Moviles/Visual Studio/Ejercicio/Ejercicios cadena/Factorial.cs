using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_cadena
{
    class Factorial
    {
        private string frase;
        private int longitud;
        
        public Factorial()
        {
            frase = "";
            longitud = 0;
        }

        public void loFrase()
        {
            Console.WriteLine("Frase");
            frase = Console.ReadLine();

            Console.WriteLine("Longitud es: "+ longFrase(longitud));
        }

        private int longFrase(int l)
        {
            longitud = l;

            if (frase[longitud] == null)
                return longitud;
            else
                return longFrase(longitud++);
        }
    }
}
