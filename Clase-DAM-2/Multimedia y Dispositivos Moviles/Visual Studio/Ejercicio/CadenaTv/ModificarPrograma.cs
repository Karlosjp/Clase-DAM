using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class ModificarPrograma : GModificarDatos
    {
        private int minDescontar = 0;

        public void Descontar(Dia[] sem)
        {
            IntroduceDia();
            IntroduceHora();

            for (int i = 0; i < sem.Length; i++)
                if(string.Equals(sem[i].GetDia(), dia))
                    DescontarMin(sem[i].GetProgramas());
        }

        private void DescontarMin(Programa[] dia)
        {
            for (int i = 0; i < dia.Length; i++)
                if (dia[i].GetHInicio() == nPrograma.GetHInicio())
                {
                    Console.WriteLine("Cuanto tiempo quieres descontar de " + dia[i].GetDuracion()+".");
                    minDescontar = Int32.Parse(Console.ReadLine());

                    if (comprobarMinutos())
                    {
                        dia[i].SetDuracion(dia[i].GetDuracion() - minDescontar);

                        Console.WriteLine("Duracion modificada a --> " + dia[i].GetDuracion());
                    }
                    else
                        Console.WriteLine(minDescontar + " es mayor que " + dMinutos() + ".");
                }

        }

        private bool comprobarMinutos()
        {
            return minDescontar <= dMinutos();
        }
    }
}
