using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_cadena
{
    class AnadirPalabra
    {
        private string palabra, nueva = "";
        private int num;

        public AnadirPalabra()
        {
            palabra = "";
            nueva = "";
            num = 0;
        }

        public void imprimir()
        {
            Console.WriteLine("Palabra");
            palabra = Console.ReadLine();
            Console.WriteLine("Numero");
            num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                nueva += palabra[i];

            nueva += "hola";

            for (int i = num; i < palabra.Length; i++)
                nueva += palabra[i];

            Console.WriteLine(nueva);
            Console.ReadKey();
        }
        
    }
}
