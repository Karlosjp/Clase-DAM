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
            GeneralDatos gd = new GeneralDatos();
            Semana sm = new Semana();

            int opcion;
            do
            {
                opciones();
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        gd.IntroduceDia();
                        gd.IntroduceHora();
                        gd.IntroducirNombre();
                        gd.IntroducirContenido();
                        gd.IntroducirDuracion();
                        sm.NuevoPrograma(gd.GetPrograma(),gd.GetDia(), gd.GetHora());
                        break;
                    case 2:
                        gd.IntroduceDia();
                        gd.IntroduceHora();
                        sm.BorrarPrograma(gd.GetDia(),gd.GetHora());
                        break;
                    case 3:
                        gd.IntroduceDia();
                        gd.IntroduceHora();
                        gd.IntroducirDuracion2();
                        sm.CambiarDuracionPrograma(gd.GetDia(),gd.GetHora(),gd.GetDuracion());
                        break;
                    case 4:
                        sm.MostrarProgramacionSemanal();
                        break;
                    case 5:
                        gd.IntroduceDia();
                        sm.MostrarProgramacionDiaria(gd.GetDia());
                        break;
                    case 6:
                        gd.IntroduceDia();
                        sm.MostrarDuracionContenidoDiario(gd.GetDia());
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