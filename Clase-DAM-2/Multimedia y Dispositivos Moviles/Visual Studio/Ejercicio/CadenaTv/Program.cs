using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
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
            string[] tContenido = { "Informativo", "Entretenimiento", "Concurso", "Pelicula", "Serie" };
            int opcion;
            do
            {
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 0:
                        Console.WriteLine("Adios");
                        break;
                    default:
                        break;
                }
            } while (opcion != 0);
        }
    }
}
