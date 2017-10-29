using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Metodos
{
    class Program
    {
        static public string pideEntero()
        {
            Console.WriteLine("Escribe un numero entero. Ej --> 3");
            return Console.ReadLine();
        }

        static public string pideReal()
        {
            Console.WriteLine("Escribe un numero entero. Ej --> 3,47");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Metodos met = new Metodos();

            string nAlmacen;
            int opcion = 0;

            do
            {
                Console.WriteLine("Elije una opcion.");
                Console.WriteLine("1.- ejercicio A.");
                Console.WriteLine("2.- ejercicio B.");
                Console.WriteLine("3.- ejercicio C.");
                Console.WriteLine("4.- ejercicio D.");
                Console.WriteLine("5.- ejercicio E.");
                Console.WriteLine("6.- ejercicio F.");
                Console.WriteLine("0.- Salir.");

                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El numero es --> " + met.ejercicioA(pideReal()));
                        break;
                    case 2:
                        met.ejercicioB(pideReal(), out nAlmacen);

                        Console.WriteLine("El resultado es --> " + nAlmacen);
                        break;
                    case 3:
                        nAlmacen = pideReal();

                        met.ejercicioC(ref nAlmacen);

                        Console.WriteLine("El resultado es --> " + nAlmacen);
                        break;
                    case 4:
                        Console.WriteLine(met.ejercicioD(pideReal(), pideEntero()));               
                        break;
                    case 5:
                        met.ejercicioE(pideReal(), pideEntero(), out nAlmacen);

                        Console.WriteLine("El resultado es --> " + nAlmacen);
                        break;
                    case 6:
                        nAlmacen = pideReal();

                        met.ejercicioF(ref nAlmacen, pideEntero());

                        Console.WriteLine("El resultado es --> " + nAlmacen);
                        break;
                    case 0:
                        Console.WriteLine("Adios.");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.WriteLine("Opcion " + opcion + " no existe.");
                        Console.ReadKey();
                        break;              
                }
            } while (opcion != 0);
        }
    }
}
