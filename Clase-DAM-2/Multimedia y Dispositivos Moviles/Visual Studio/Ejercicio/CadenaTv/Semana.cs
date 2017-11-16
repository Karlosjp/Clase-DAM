using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class Semana
    {
        static private Dia lunes = new Dia("Lunes");
        static private Dia martes = new Dia("Martes");
        static private Dia miercoles = new Dia("Miercoles");
        static private Dia jueves = new Dia("Jueves");
        static private Dia viernes = new Dia("Viernes");

        Dia[] semana = { lunes, martes, miercoles, jueves, viernes };

        private GeneralDatos gp = new GeneralDatos();

        public void NuevoPrograma()
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
    }
}
