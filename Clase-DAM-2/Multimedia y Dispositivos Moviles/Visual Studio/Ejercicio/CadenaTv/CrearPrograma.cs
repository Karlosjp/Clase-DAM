using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CadenaTv
{
    class CrearPrograma : GModificarDatos
    {
        private string contenido;

        // Metodos publicos
        public void Crear()
        {
            IntroduceDia();
            IntroduceHora();
            IntroducirContenido();
            IntroducirDuracion();
            IntroducirNombre();
        }

        // Metodos privados
        private void IntroducirContenido()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Contenido del programa: (Informativo, Entretenimiento, Concurso, Pelicula, Serie).");
                contenido = ti.ToTitleCase(Console.ReadLine());
                nPrograma.SetContenido(contenido);

                if (comprobarConenido())
                {
                    aux = true;
                    Console.WriteLine("Contenido correcto.");
                }
                else
                    Console.WriteLine("Contenido incorrecto.");
            } while (!aux);
        }

        private void IntroducirDuracion()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Duracion en minutos desde las: " + nPrograma.GetHInicio() + ":00 hasta las: " + nPrograma.GetHFin() + ":00.");
                nPrograma.SetDuracion(Int32.Parse(Console.ReadLine()));

                if (comprobarDuracion())
                {
                    aux = true;
                    Console.WriteLine("Duracion correcta.");
                }
                else
                    Console.WriteLine("Duracion incorrecta.");
            } while (!aux);
        }

        private void IntroducirNombre()
        {
            bool aux = false;

            do
            {
                Console.WriteLine("Nombre del programa: ");
                nPrograma.SetNombre(ti.ToTitleCase(Console.ReadLine()));

                if (comprobarNombre())
                {
                    aux = true;
                    Console.WriteLine("Nombre correcto.");
                }
                else
                    Console.WriteLine("Nombre incorrecto.");
            } while (!aux);
        }

        private bool comprobarConenido()
        {
            bool resC = false;

            for (int i = 0; i < tContenido.Length; i++)
                if (string.Equals(tContenido[i], nPrograma.GetContenido()))
                    resC = true;

            return resC;
        }

        private bool comprobarNombre()
        {
            bool resD = false;

            if (!(nPrograma.GetNombre() == ""))
                resD = true;

            return resD;
        }
    }
}
