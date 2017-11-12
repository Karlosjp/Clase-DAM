using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadenaTv
{
    class GModificarDatos
    {
        protected TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        protected Programa nPrograma = new Programa();

        protected string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" },
                         tContenido = { "Informativo", "Entretenimiento", "Concurso", "Pelicula", "Serie" };

        protected string dia;

        protected int[] horario = { 8, 10, 14, 16, 20, 24 };

        // Geters
        public string GetDia()
        {
            return dia;
        }

        public Programa GetPrograma()
        {
            return nPrograma;
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

        protected void IntroduceHora()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Escribe hora de inicio: (8, 10, 14, 16, 20).");
                nPrograma.SetHInicio(Int32.Parse(Console.ReadLine()));

                if (comprobarHora())
                {
                    horaFin();
                    aux = true;
                }
                else
                    Console.WriteLine("Hora incorrecta.");
            } while (!aux);
        }

        protected void horaFin()
        {
            for (int i = 0; i < horario.Length; i++)
                if (nPrograma.GetHInicio() == horario[i])
                    nPrograma.SetHFin(horario[i + 1]);
        }

        protected bool comprobarDuracion()
        {
            bool resD = false;

            if (nPrograma.GetDuracion() > 0 && nPrograma.GetDuracion() <= dMinutos())
                resD = true;

            return resD;
        }

        protected int dMinutos()
        {
            int minutos = 0;

            for (int i = 0; i < horario.Length - 1; i++)
                if (horario[i] == nPrograma.GetHInicio())
                    minutos = (horario[i + 1] - horario[i]) * 60;

            return minutos;
        }

        protected bool comprobarDia()
        {
            bool resD = false;

            for (int i = 0; i < diasSemana.Length; i++)
                if (string.Equals(diasSemana[i], dia))
                    resD = true;

            return resD;
        }

        protected bool comprobarHora()
        {
            bool resH = false;

            for (int i = 0; i < horario.Length - 1; i++)
                if (horario[i] == nPrograma.GetHInicio())
                    resH = true;

            return resH;
        }
    }
}
