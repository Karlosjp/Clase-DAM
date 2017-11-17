using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadenaTv2
{
    class GeneralDatos : Globales
    {


        private TextInfo ti;
        private Programa auxPrograma;

        private string diaElegido;
        private int hora, dia, duracion;

        // Geters
        public int GetDia() { return dia; }

        public int GetHora() { return hora; }

        public int GetDuracion() { return duracion; }

        public Programa GetPrograma() { return auxPrograma; }

        // Constructores
        public GeneralDatos()
        {
            ti = CultureInfo.CurrentCulture.TextInfo;
            auxPrograma = new Programa();
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

            switch (diaElegido)
            {
                case "Lunes":
                    dia = 0;
                    break;
                case "Martes":
                    dia = 1;
                    break;
                case "Miercoles":
                    dia = 2;
                    break;
                case "Jueves":
                    dia = 3;
                    break;
                case "Viernes":
                    dia = 4;
                    break;
            }
        }

        public void IntroduceHora()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Escribe hora de inicio: (8, 10, 14, 16, 20).");
                hora = Int32.Parse(Console.ReadLine());

                if (comprobarHora())
                {
                    Console.WriteLine("Hora correcta.");
                    aux = true;
                }
                else
                    Console.WriteLine("Hora incorrecta.");
            } while (!aux);

            switch (hora)
            {
                case 8:
                    hora = 0;
                    break;
                case 10:
                    hora = 1;
                    break;
                case 14:
                    hora = 2;
                    break;
                case 16:
                    hora = 3;
                    break;
                case 20:
                    hora = 4;
                    break;
            }
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
                Console.WriteLine("Duracion en minutos desde las: " + horario[dia] + ":00 hasta las: " + horario[dia+1] + ":00.");
                duracion = Int32.Parse(Console.ReadLine());

                if (auxPrograma.GetDuracion() < maxDuracion(hora))
                {
                    aux = true;
                    auxPrograma.SetDuracion(duracion);
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

        public void IntroducirDuracion2()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("¿Cuanto tiempo desde las " + horario[dia] + ":00 hasta las: " + horario[dia++] + ":00 quieres descontar?.");
                duracion = Int32.Parse(Console.ReadLine());

                if (auxPrograma.GetDuracion() < maxDuracion(hora))
                {
                    aux = true;
                    Console.WriteLine("Duracion correcta.");
                }
                else
                    Console.WriteLine("Duracion incorrecta, el maximo es --> " + maxDuracion(hora));
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
                if (horario[i] == hora)
                    resH = true;

            return resH;
        }

        private bool comprobarDia()
        {
            bool resD = false;

            for (int i = 0; i < diasSemana.Length; i++)
                if (string.Equals(diasSemana[i], diaElegido))
                    resD = true;

            return resD;
        }

        private int maxDuracion(int hora) { return (horario[hora+1] - horario[hora]) * 60; }
    }
}