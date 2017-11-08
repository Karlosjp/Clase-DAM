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

        static private void mayor(ref Fecha[] fechas)
        {
            for (int i = 0; i < fechas.Length - 1; i++)
            {
                for (int j = 0; j < fechas.Length; j++)
                {
                    if (fechas[i].getAnho() > fechas[j].getAnho())
                        fechas[j] = fechas[i];
                    else if (fechas[i].getAnho() == fechas[j].getAnho())
                        if (fechas[i].getMes() > fechas[j].getMes())
                            fechas[j] = fechas[i];
                        else if (fechas[i].getMes() == fechas[j].getMes())
                            if (fechas[i].getDia() > fechas[j].getDia())
                                fechas[j] = fechas[i];
                }
            }
        } 

        static private void difFecha(Fecha f1, Fecha f2)
        {
            int dAnho, dMes, dDia, dFechas;

            dAnho = Math.Abs(f1.getAnho() - f2.getAnho());
            dMes = Math.Abs(f2.getMes() - f1.getMes());
            dDia = Math.Abs(f1.getDia() - f2.getDia());

            dFechas = (dAnho * 365) + (dMes * 30) + dDia;

            Console.WriteLine("Desde el dia 1 del mes 1 del año " + f1.getAnho() + " hasta hoy. Hay una diferencia de " + dFechas + " dias.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            DateTime fechaHoy = DateTime.Today;
            Fecha f1 = new Fecha(),
                  f2 = new Fecha(),
                  f3 = new Fecha(),
                  f4 = new Fecha(),
                  f5 = new Fecha(fechaHoy.Day, fechaHoy.Month, fechaHoy.Year),
                  f6 = new Fecha(1, 1, fechaHoy.Year);

            Fecha[] fechas = { f1, f2, f3, f4 };

            difFecha(f6, f5);
            /*for (int i = 0; i < fechas.Length; i++)
                datos(fechas[i]);

            mayor(ref fechas);

            Console.WriteLine("La fecha mayor es --> " + fechas[fechas.Length-1].EscribirFecha());
            Console.ReadKey();*/         
        }
    }
}
