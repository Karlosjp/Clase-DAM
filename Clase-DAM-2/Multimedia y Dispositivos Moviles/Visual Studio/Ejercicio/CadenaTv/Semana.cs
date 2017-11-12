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
        private EliminarPrograma ep = new EliminarPrograma();
        private ModificarPrograma mp = new ModificarPrograma();
        private MostrarProgramacion mosPro = new MostrarProgramacion();
        
        private string[] tContenido = { "Informativo", "Entretenimiento", "Concurso", "Pelicula", "Serie" };

        public void NuevoPrograma()
        {
            cp.Crear();

            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), cp.GetDia()))
                    semana[i].ModificarPrograma(cp.GetPrograma());

            Console.WriteLine("Programa introducido.");
        }

        public void BorrarPrograma()
        {
            ep.Borrar();
            
            for (int i = 0; i < semana.Length; i++)
                if (string.Equals(semana[i].GetDia(), ep.GetDia()))
                    semana[i].ModificarPrograma(ep.GetPrograma());

            Console.WriteLine("Programa borrado.");
        }

        public void ModDuracion()
        {
            mp.Descontar(semana);

            Console.WriteLine("Duracion modificada.");
        }

        public void MostrarPDiaria()
        {
            mosPro.MosProgDiaria(semana);
        }
    }
}
