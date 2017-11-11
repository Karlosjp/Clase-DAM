using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadenaTv
{
    class CrearPrograma
    {
        Programa nPrograma = new Programa();

        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;

        private string[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" },
                         tContenido = { "Informativo", "Entretenimiento", "Concurso", "Pelicula", "Serie" };
        string dia, contenido;

        private int[] horario = { 8, 10, 14, 16, 20, 24 };

        // Geters
        public Programa GetPrograma()
        {
            return nPrograma;
        }

        public string GetDia()
        {
            return dia;
        }

        // Metodos
        public void IntroduceDia()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("¿Que dia sera el programa? (Lunes, Martes, Miercoles, Jueves, Viernes).");
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

        public void IntroduceHora()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Escribe hora de inicio: (8, 10, 14, 16, 20).");
                nPrograma.setHInicio(Int32.Parse(Console.ReadLine()));

                if (comprobarHora())
                {
                    aux = true;
                    horaFin();
                }
                else
                    Console.WriteLine("Hora incorrecta.");
            } while (!aux);
        }

        public void IntroducirContenido()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Contenido del programa: (Informativo, Entretenimiento, Concurso, Pelicula, Serie).");
                contenido = ti.ToTitleCase(Console.ReadLine());
                nPrograma.setContenido(contenido);

                if (comprobarConenido())
                {
                    aux = true;
                    Console.WriteLine("Contenido correcto.");
                }
                else
                    Console.WriteLine("Contenido incorrecto.");
            } while (!aux);
        }

        public void IntroducirDuracion()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Duracion en minutos desde las: " + nPrograma.getHInicio() + ":00 hasta las: " + nPrograma.getHFin()+":00.");
                nPrograma.setDuracion(Int32.Parse(Console.ReadLine()));

                if (comprobarDuracion())
                {
                    aux = true;
                    Console.WriteLine("Duracion correcta.");
                }
                else
                    Console.WriteLine("Duracion incorrecta.");
            } while (!aux);
        }

        public void IntroducirNombre()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Nombre del programa: ");
                nPrograma.setNombre(ti.ToTitleCase(Console.ReadLine()));

                if (comprobarNombre())
                {
                    aux = true;
                    Console.WriteLine("Nombre correcto.");
                }
                else
                    Console.WriteLine("Nombre incorrecto.");
            } while (!aux);
        }

        private bool comprobarDia()
        {
            bool resD = false;

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i], dia))
                    resD = true;

            return resD;
        }

        private bool comprobarHora()
        {
            bool resH = false;

            for (int i = 0; i < horario.Length; i++)
                if (horario[i] == nPrograma.getHInicio())
                    resH = true;

            return resH;
        }

        private void horaFin()
        {
            for (int i = 0; i < horario.Length; i++)
                if (nPrograma.getHInicio() == horario[i])
                    nPrograma.setHFin(horario[i + 1]);
        }

        private bool comprobarConenido()
        {
            bool resC = false;

            for (int i = 0; i < tContenido.Length; i++)
                if (string.Equals(tContenido[i], nPrograma.getContenido()))
                    resC = true;

            return resC;
        }

        private bool comprobarDuracion()
        {
            bool resD = false;
            int minutos = 0;

            for (int i = 0; i < horario.Length - 1; i++)
                if (horario[i] == nPrograma.getHInicio())
                    minutos = (horario[i + 1] - horario[i]) * 60;

            if (nPrograma.getDuracion() > 0 && nPrograma.getDuracion() <= minutos)
                resD = true;

            return resD;
        }

        private bool comprobarNombre()
        {
            bool resD = false;

            if (!(nPrograma.getNombre() == ""))
                resD = true;

            return resD;
        }
    }
}
