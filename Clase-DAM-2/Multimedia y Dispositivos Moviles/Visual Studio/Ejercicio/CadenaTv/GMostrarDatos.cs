using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class GMostrarDatos
    {
        protected TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        protected Dia[] semana;
        protected Programa[] pro;

        protected string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" };

        protected string dia;

        // Geters
        public string GetDia()
        {
            return dia;
        }

        // Metodos
        protected void IntroduceDia()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("¿Que dia es el programa? (Lunes, Martes, Miercoles, Jueves, Viernes).");
                dia = ti.ToTitleCase(Console.ReadLine());

                if (comprobarDia())
                {
                    aux = true;
                    Console.WriteLine("Dia correcto.");
                }
                else
                    Console.WriteLine("Dia incorrecto.");
            } while (!aux);
        }

        protected void buscarDia()
        {
            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), dia))
                    pro = semana[i].GetProgramas();
        }

        protected void mostrarPro()
        {
            string fmt = " {0,15: 000 }";

            Console.WriteLine(" Dia\t--> " + dia);
            Console.WriteLine(" Horario:\tNombre:\tContenido:\tDuración:");
            for (int i = 0; i < pro.Length; i++)
                Console.WriteLine(fmt,pro[i].GetHInicio() + " -- " + pro[i].GetHFin() +
                                    "\t" + pro[i].GetNombre() + "\t" + pro[i].GetContenido() +
                                    "\t   --\t " + pro[i].GetDuracion() + " min ");
        }

        protected bool comprobarDia()
        {
            bool resD = false;

            for (int i = 0; i < diasSemana.Length; i++)
                if (string.Equals(diasSemana[i], dia))
                    resD = true;

            return resD;
        }
    }
}