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
            CamaraIP cIP = new CamaraIP();

            Console.WriteLine(cIP.Escribir());
            Console.ReadKey();
        }
    }
}
