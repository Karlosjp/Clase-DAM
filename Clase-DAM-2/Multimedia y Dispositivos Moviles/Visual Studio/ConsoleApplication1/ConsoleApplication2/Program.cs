using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = {"Carlos", "Carlota", "David", "Fabiola", "Javier"};

            for (int i = 0; i < nombres.Length; i++)
            {
                for (int j = 0; i < (nombres.Length - 2) - i; j++)
                {
                    if (nombres[j].CompareTo(nombres[j + 1]) > 0)
                    {
                        string aux = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = aux;
                    }
                }
            }

            foreach (string nombre in nombres)
            {
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
