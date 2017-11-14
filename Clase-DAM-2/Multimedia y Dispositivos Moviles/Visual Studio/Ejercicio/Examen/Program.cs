using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Potencia p1 = new Potencia(2, 8);
            Potencia p2 = new Potencia(2, 6);
            Potencia p3 = new Potencia(2, 4);

            Potencia[] py = { p1, p2, p3 };

            Potencia px = new Potencia();

            Potencia aux = new Potencia();

            px = p1.Multiplicar(p2);

            Console.WriteLine(px.Escribir());
            Console.ReadKey();

            for (int i = 0; i < py.Length-1; i++)
                if (py[i].getDExp() > py[i + 1].getDExp())
                {
                    aux = py[i + 1];
                    py[i + 1] = py[i];
                    py[i] = aux;
                }

            Console.WriteLine(py[py.Length-1].Escribir());
            Console.ReadKey();
        }
    }
}
