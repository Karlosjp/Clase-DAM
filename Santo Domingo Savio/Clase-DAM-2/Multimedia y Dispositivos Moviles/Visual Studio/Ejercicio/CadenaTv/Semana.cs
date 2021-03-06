﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class Semana
    {
        private GeneralDatos gp = new GeneralDatos();

        private Dia[] semana;

        // Constructores
        public Semana()
        {
            crearSemana(5);
        }

        // Metodos
        private void crearSemana(int s)
        {
            semana = new Dia[s];
            for (int i = 0; i < semana.Length; i++)
                semana[i] = new Dia(gp.GetDiasSemana(i));
        }

        /*public void NuevoPrograma()
        {
            gp.IntroduceDia();
            gp.IntroducirNombre();
            gp.IntroduceHora();
            gp.IntroducirContenido();
            gp.IntroducirDuracion();

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), gp.GetDia()))
                    semana[i].CrearPrograma(gp.GetPrograma());

            Console.WriteLine("Programa introducido.");
        }

        public void BorrarPrograma()
        {
            gp.IntroduceDia();
            gp.IntroduceHora();

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), gp.GetDia()))
                    semana[i].Borrar(gp.GetHora());

            Console.WriteLine("Programa borrado.");
        }

        public void ModDuracion()
        {
            gp.IntroduceDia();
            gp.IntroduceHora();

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), gp.GetDia()))
                    semana[i].DescontarMin(gp.GetHora());

            Console.WriteLine("Duracion modificada.");
        }

        public void MostrarProgDiaria()
        {
            gp.IntroduceDia();

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), gp.GetDia()))
                    semana[i].MostrarProgramacion();
        }

        public void MostrarContenidos()
        {
            gp.IntroduceDia();

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), gp.GetDia()))
                    semana[i].MostrarContenidos(gp.GetContenido());
        }

        public void MostrarProgramacion()
        {
            Console.WriteLine(" Horario:\tNombre:\tContenido:\tDuración:");

            for (int i = 0; i < semana.Length; i++)
                semana[i].MostrarProgramacion();
        }
        */
    }
}
