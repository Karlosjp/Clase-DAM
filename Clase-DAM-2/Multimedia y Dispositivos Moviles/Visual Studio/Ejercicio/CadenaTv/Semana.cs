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

        private CrearPrograma cp = new CrearPrograma();
        
        private string[] tContenido = { "Informativo", "Entretenimiento", "Concurso", "Pelicula", "Serie" };

        public void NuevoPrograma()
        {
            cp.IntroduceDia();
            cp.IntroduceHora();
            cp.IntroducirContenido();
            cp.IntroducirDuracion();
            cp.IntroducirNombre();

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), cp.GetDia()))
                    semana[i].AnadirPrograma(cp.GetPrograma());

            Console.WriteLine("Programa introducido.");
        }
    }
}
