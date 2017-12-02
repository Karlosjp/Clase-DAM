using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposElectronicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Camara c = new Camara();
            CamaraWeb cw = new CamaraWeb();

            Console.WriteLine(c.Escribir());
            Console.WriteLine(cw.Escribir());
            Console.ReadKey();
        }
    }
}
