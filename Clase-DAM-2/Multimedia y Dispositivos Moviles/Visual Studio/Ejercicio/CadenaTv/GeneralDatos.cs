using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadenaTv
{
    class GeneralDatos
    {
        static private string[] diasSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes" },
                         tContenido = { "Informativo", "Entretenimiento", "Concurso", "Pelicula", "Serie" };

        private TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        private Programa auxPrograma = new Programa();

        private string diaElegido;

        private int[] horario = { 8, 10, 14, 16, 20, 24 };

        // Geters
        public string GetDia(){return diaElegido;}

        public int GetHora(){return auxPrograma.GetHInicio();}

        public string [] GetContenido() { return tContenido; }

        public Programa GetPrograma()
        {
            return auxPrograma;
        }

        // Metodos
        public void IntroduceDia()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("¿Que dia es el programa? (Lunes, Martes, Miercoles, Jueves, Viernes).");
                diaElegido = ti.ToTitleCase(Console.ReadLine());

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
                auxPrograma.SetHInicio(Int32.Parse(Console.ReadLine()));

                if (comprobarHora())
                {
                    horaFin();
                    aux = true;
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
                auxPrograma.SetContenido(ti.ToTitleCase(Console.ReadLine()));

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
                Console.WriteLine("Duracion en minutos desde las: " + auxPrograma.GetHInicio() + ":00 hasta las: " + auxPrograma.GetHFin() + ":00.");
                auxPrograma.SetDuracion(Int32.Parse(Console.ReadLine()));

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
                auxPrograma.SetNombre(ti.ToTitleCase(Console.ReadLine()));

                if (comprobarNombre())
                {
                    aux = true;
                    Console.WriteLine("Nombre correcto.");
                }
                else
                    Console.WriteLine("Nombre incorrecto.");
            } while (!aux);
        }

        // Metodos privados
        private bool comprobarConenido()
        {
            bool resC = false;

            for (int i = 0; i < tContenido.Length; i++)
                if (string.Equals(tContenido[i], auxPrograma.GetContenido()))
                    resC = true;

            return resC;
        }

        private bool comprobarNombre()
        {
            bool resD = false;

            if (!(auxPrograma.GetNombre() == ""))
                resD = true;

            return resD;
        }

        private bool comprobarHora()
        {
            bool resH = false;

            for (int i = 0; i < horario.Length - 1; i++)
                if (horario[i] == auxPrograma.GetHInicio())
                    resH = true;

            return resH;
        }

        private bool comprobarDuracion()
        {
            bool resD = false;

            if (auxPrograma.GetDuracion() > 0 && auxPrograma.GetDuracion() <= auxPrograma.DMaxMinutos())
                resD = true;

            return resD;
        }

        private bool comprobarDia()
        {
            bool resD = false;

            for (int i = 0; i < diasSemana.Length; i++)
                if (string.Equals(diasSemana[i], diaElegido))
                    resD = true;

            return resD;
        }

        private void horaFin()
        {
            for (int i = 0; i < horario.Length; i++)
                if (auxPrograma.GetHInicio() == horario[i])
                    auxPrograma.SetHFin(horario[i + 1]);
        }
    }
}

