using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Metodos
{
    class Program
    {
        static public Boolean vacio(string lectura)
        {
            bool aux = false;

            if (lectura == "")
                aux = true;

            return aux;
        }

        static public string pideEntero()
        {
            string lectura;

            Console.WriteLine("Escribe un numero entero. Ej --> 3");
            lectura = Console.ReadLine();

            if (vacio(lectura))
            {
                Console.WriteLine("Campo vacio");
                lectura = null;
            }

            return null;

        }

        static public string pideReal()
        {
            string lectura;

            Console.WriteLine("Escribe un numero entero. Ej --> 3,47");
            lectura = Console.ReadLine();

            if (vacio(lectura))
            {
                Console.WriteLine("Campo vacio");
                lectura = null;
            }

            return null;
        }

        static void Main(string[] args)
        {
            Metodos met = new Metodos();

            string nAlmacen, lectura1, lectura2;
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

                lectura1 = Console.ReadLine();

                if (lectura1 != null)
                {
                    opcion = Int32.Parse(lectura1);

                    switch (opcion)
                    {
                        case 1:
                            lectura1 = pideReal();

                            if (lectura1 != null)
                                Console.WriteLine("El numero es --> " + met.ejercicioA(lectura1));
                            break;
                        case 2:
                            lectura1 = pideReal();

                            if (lectura1 != null)
                            {
                                met.ejercicioB(lectura1, out nAlmacen);
                                Console.WriteLine("El resultado es --> " + nAlmacen);
                            }
                            break;
                        case 3:
                            nAlmacen = pideReal();

                            if (nAlmacen != null)
                            {
                                met.ejercicioC(ref nAlmacen);

                                Console.WriteLine("El resultado es --> " + nAlmacen);
                            }
                            break;
                        case 4:
                            lectura1 = pideReal();
                            lectura2 = pideEntero();

                            if (lectura1 != null && lectura2 != null)
                                Console.WriteLine(met.ejercicioD(lectura1, lectura2));
                            break;
                        case 5:
                            lectura1 = pideReal();
                            lectura2 = pideEntero();

                            if (lectura1 != null && lectura2 != null)
                            {
                                met.ejercicioE(lectura1, lectura2, out nAlmacen);

                                Console.WriteLine("El resultado es --> " + nAlmacen);
                            }
                            break;
                        case 6:
                            nAlmacen = pideReal();
                            lectura2 = pideEntero();

                            if (nAlmacen != null && lectura2 != null)
                            {
                                met.ejercicioF(ref nAlmacen, lectura2);

                                Console.WriteLine("El resultado es --> " + nAlmacen);
                            }
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
                }
                else
                    Console.WriteLine("Campo vacio");
            } while (opcion != 0);
        }
    }
}
