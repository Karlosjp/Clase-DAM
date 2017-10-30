using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPOO
{
    class Program
    {
        static private void datos(Fecha fecha)
        {
            Console.WriteLine("Escribe Año");
            fecha.setAnho(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Escribe Mes");
            fecha.setMes(Int32.Parse(Console.ReadLine()));

            Console.WriteLine("Escribe Dia");
            fecha.setDia(Int32.Parse(Console.ReadLine()));
        }

        static private void mayor(Fecha [] fechas)
        {
            Fecha aux;
            for(int i = 0; i < fechas.Length - 1; i++)
            {
                for(intj=0)
            }
        }

        static void Main(string[] args)
        {
            Fecha f1 = new Fecha(),
                  f2 = new Fecha(),
                  f3 = new Fecha(),
                  f4 = new Fecha();

            Fecha[] fechas = { f1, f2, f3, f4 };

            for (int i = 0; i < fechas.Length; i++)
                datos(fechas[i]);
        }
    }
}
