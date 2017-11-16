using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class Dia
    {
        private string nombreDia;

        private Programa[] programacion;

        //Geters
        public string GetDia() { return nombreDia; }

        public Programa[] GetProgramas() { return programacion; }

        // Constructor
        public Dia()
        {
            nombreDia = "";
            programacion = new Programa[5];

            for (int i = 0; i < programacion.Length; i++)
                programacion[i] = new Programa();
        }

        public Dia(string d)
        {
            this.nombreDia = d;
            programacion = new Programa[5];

            for (int i = 0; i < programacion.Length; i++)
                programacion[i] = new Programa();
        }

        public Dia(string nomD, Programa[] programacion)
        {
            nombreDia = nomD;
            this.programacion = programacion;
        }

        // Metodos
        public void CrearPrograma(Programa pro)
        {
            for (int i = 0; i < programacion.Length; i++)
                if (programacion[i].GetHInicio() == pro.GetHInicio())
                    programacion[i] = pro;
        }

        public void Borrar(int h)
        {
            for (int i = 0; i < programacion.Length; i++)
                if (programacion[i].GetHInicio() == h)
                    programacion[i].Borrar();
        }

        public void DescontarMin(int t)
        {
            for (int i = 0; i < programacion.Length; i++)
                if (programacion[i].GetHInicio() == t)
                {
                    Console.WriteLine("Cuanto tiempo quieres descontar de " + programacion[i].GetDuracion() + ".");

                    if (programacion[i].ComprobarDuracion(Int32.Parse(Console.ReadLine())))
                        Console.WriteLine("Duracion modificada a --> " + programacion[i].GetDuracion());
                    else
                        Console.WriteLine("Cantidad mayor de " + programacion[i].DMaxMinutos() + " minutos.");
                }
        }

        public void MostrarProgramacion()
        {
            Console.WriteLine(" Dia\t--> " + nombreDia);

            for (int i = 0; i < programacion.Length; i++)
                Console.WriteLine(programacion[i].Escribir());
        }

        public void MostrarContenidos(string[] c)
        {
            int minTotal = 0;

            Console.WriteLine(" Dia\t--> " + nombreDia);
            for (int j = 0; j < c.Length; j++)
            {
                for (int i = 0; i < programacion.Length; i++)
                    if (c[j] == programacion[i].GetContenido())
                        minTotal += programacion[i].GetDuracion();

                Console.WriteLine(c[j] + "\t" + minTotal + " min");
            }
        }
    }
}

