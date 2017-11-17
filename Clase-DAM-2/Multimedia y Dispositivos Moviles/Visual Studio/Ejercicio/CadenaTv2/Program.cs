using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv2
{
    class Program
    {
        static void opciones()
        {
            Console.WriteLine("Selecciona la opcion que quieres ejecutar");
            Console.WriteLine("1. Asignar un programa nuevo");
            Console.WriteLine("2. Eliminar programa");
            Console.WriteLine("3. Modificar minutos de un programa");
            Console.WriteLine("4. Mostrar programacion semanal");
            Console.WriteLine("5. Mostrar programacion diaria");
            Console.WriteLine("6. Mostrar contenido por dia");
        }

        static void Main(string[] args)
        {
            Semana sm = new Semana();
            int opcion;
            do
            {
                opciones();
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        sm.NuevoPrograma();
                        break;
                    case 2:
                        sm.BorrarPrograma();
                        break;
                    case 3:
                        sm.ModDuracion();
                        break;
                    case 4:
                        sm.MostrarProgramacion();
                        break;
                    case 5:
                        sm.MostrarProgDiaria();
                        break;
                    case 6:
                        sm.MostrarContenidos();
                        break;
                    case 0:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
            } while (opcion != 0);
        }
    }
}