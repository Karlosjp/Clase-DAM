using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Metodos
{
    class Program
    {
        static Truncar trunc = new Truncar();

        static private Boolean vacio(int lectura)
        {
            bool aux = false;

            if (lectura == 0){
                aux = true;
                Console.WriteLine("Campo vacio");
            }

            return aux;
        }

        static public int pideEntero()
        {
            Console.WriteLine("Escribe un numero entero. Ej --> 3");
            return Int32.Parse(Console.ReadLine());
        }

        static public double pideReal()
        {
            Console.WriteLine("Escribe un numero entero. Ej --> 3,47");
            return double.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int opcion = 0, nAlmacenEntero;
            double nAlmacenReal;

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
                        trunc.setReal(pideReal());

                        Console.WriteLine("El resultado es --> " + trunc.TruncarACero());
                        break;
                    case 2:
                        trunc.setReal(pideReal());

                        trunc.TruncarACero(out nAlmacenEntero);

                        Console.WriteLine("El resultado es --> " + nAlmacenEntero);
                        break;
                    case 3:
                        nAlmacenReal = pideReal();

                        trunc.TruncarACero(ref nAlmacenReal);

                        Console.WriteLine("El resultado es --> " + nAlmacenReal);
                        break;
                    case 4:
                        trunc.setReal(pideReal());
                        trunc.setEntero(pideEntero());

                        Console.WriteLine("El resultado es --> " + trunc.TruncaraElegir());
                        break;
                    case 5:
                        trunc.setReal(pideReal());
                        trunc.setEntero(pideEntero());

                        trunc.TruncaraElegir(out nAlmacenReal);

                        Console.WriteLine("El resultado es --> " + nAlmacenReal);
                        break;
                    case 6:
                        nAlmacenReal = pideReal();
                        trunc.setEntero(pideEntero());

                        trunc.TruncaraElegirDos(ref nAlmacenReal);

                        Console.WriteLine("El resultado es --> " + nAlmacenReal);
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
