using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv2
{
    class Semana : Globales
    {
        private Dia[] semana;

        // Constructores
        public Semana()
        {
            semana = new Dia[5];
            for (int i = 0; i < semana.Length; i++)
                semana[i] = new Dia(diasSemana[i]);
        }

        // Metodos
        public void NuevoPrograma(Programa p, int dia, int hora)
        {
            semana[dia].NuevoPrograma(p, hora);
            Console.WriteLine("Programa introducido.");
        }

        public void BorrarPrograma(int dia, int hora)
        {
            semana[dia].Borrar(hora);
            Console.WriteLine("Programa borrado.");
        }

        public void CambiarDuracionPrograma(int dia, int hora, int nDuracion)
        {
            Console.WriteLine(semana[dia].CambiarDuracion(hora, nDuracion));
        }

        public void MostrarProgramacionSemanal()
        {
            ArrayList aux = new ArrayList();

            foreach (Dia d in semana)
            {
                aux = d.Escribir();
                for (int i = 0; i < horario.Length-1; i++)
                    //foreach (string texto in aux)
                    Console.WriteLine(horario[i] + " -- " + horario[i+1] + "\t" + aux[i]);
            }
        }

        public void MostrarProgramacionDiaria(int dia)
        {
            ArrayList aux = new ArrayList();
            aux = semana[dia].Escribir();

            for (int i = 0; i < horario.Length - 1; i++)
                Console.WriteLine(horario[i] + " -- " + horario[i + 1] + "\t" + aux[i]);
        }

        public void MostrarDuracionContenidoDiario(int dia)
        {
            foreach (string c in tContenido)
                Console.WriteLine("- " + c + " \t" + semana[dia].DuracionPorContenido(c));
        }
    }
}
