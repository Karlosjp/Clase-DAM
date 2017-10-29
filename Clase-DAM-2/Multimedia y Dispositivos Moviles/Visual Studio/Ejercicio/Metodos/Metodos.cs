using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Metodos
    {
        public string ejercicioA(string dou)
        {
            return Math.Truncate(double.Parse(dou)).ToString();
        }

        public void ejercicioB(string dou, out string ent)
        {
            ent = (Int32.Parse(ejercicioA(dou))).ToString();
        }

        public void ejercicioC(ref string dou)
        {
            dou = ejercicioA(dou);
        }

        public string ejercicioD(string dou, string ent)
        {
            double elevado = Math.Pow(10, Int32.Parse(ent));

            return (Math.Truncate(double.Parse(dou) * elevado) / elevado).ToString();
        }

        public void ejercicioE(string dou, string ent, out string real)
        {
            real = ejercicioD(dou, ent);
        }

        public void ejercicioF(ref string dou, string ent)
        {
            dou = ejercicioD(dou,ent);
        }
    }
}