using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ordenar tabla nombres y ordene la estructura.// Algoridmo de la burbuja o insercion directa
             */
            int[] tabla = { 12, 23, 34, 5 };

            for (int i = 0; i < 4; i++)
                Console.WriteLine(tabla[i]);
            
            Console.ReadKey();

            foreach(int numero in tabla)
                Console.WriteLine(tabla);

            Console.ReadKey();

            if ((3.0 / 7) is System.Int32)
                Console.WriteLine("Es de tipo entero");
            else
                Console.WriteLine("No es de timpo entero");

            Console.ReadKey();
        }
    }
}
