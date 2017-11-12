using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class MostrarProgramacion : GeneralDatos
    {
        public void MosProgDiaria(Dia[] sem)
        {
            semana = sem;
            IntroduceDia();
            buscarDia();
            mostrarProgDiaria();
        }

        public void MosProgDia(Dia[] sem)
        {
            semana = sem;
            IntroduceDia();
            buscarDia();
        }

        private void buscarDia()
        {
            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), dia))
                    pro = semana[i].GetProgramas();
        }

        private void mostrarProgSemanal()
        {

        }

        private void mostrarProgDiaria()
        {
            string fmt = " {0,15: 000 }";

            Console.WriteLine(" Dia\t--> " + dia);
            Console.WriteLine(" Horario:\tNombre:\tContenido:\tDuración:");
            for (int i = 0; i < pro.Length; i++)
                Console.WriteLine(fmt, pro[i].GetHInicio() + " -- " + pro[i].GetHFin() +
                                    "\t" + pro[i].GetNombre() + "\t" + pro[i].GetContenido() +
                                    "\t   --\t " + pro[i].GetDuracion() + " min ");
        }

        private void mostrarContenidos  Dia()
        {

            Console.WriteLine(" Dia\t--> " + dia);
            Console.WriteLine(" Horario:\tNombre:\tContenido:\tDuración:");
            for (int i = 0; i < pro.Length; i++)
                Console.WriteLine(fmt, pro[i].GetHInicio() + " -- " + pro[i].GetHFin() +
                                    "\t" + pro[i].GetNombre() + "\t" + pro[i].GetContenido() +
                                    "\t   --\t " + pro[i].GetDuracion() + " min ");
        }
    }
}