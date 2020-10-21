using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static public void sumar(int n1, int n2, out int res)
        {
            res = n1 + n2;
        }

        static void Main(string[] args)
        {
            int numero1, numero2, resultado;

            Console.WriteLine("Introduce numero 1");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce numero 2");
            numero2 = Int32.Parse(Console.ReadLine());

            sumar(numero1, numero2, out resultado);
            Console.WriteLine("La suma es: " + resultado);
            Console.ReadKey();
        }
    }
}
