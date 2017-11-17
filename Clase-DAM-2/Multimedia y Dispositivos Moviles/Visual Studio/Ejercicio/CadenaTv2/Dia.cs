using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv2
{
    class Dia
    {
        private string nombreDia;
        private Programa[] programacion;

        // Constructor
        public Dia()
        {
            nombreDia = "";
            iniciarProgramas(5);
        }

        public Dia(string d)
        {
            this.nombreDia = d;
            iniciarProgramas(5);
        }

        // Metodos publicos    
        // Imprime por pantalla el contenido de cada programa    
        public ArrayList Escribir()
        {
            ArrayList aux = new ArrayList();

            Console.WriteLine(nombreDia);
            foreach (Programa p in programacion)
                aux.Add(p.Escribir());

            return aux;
        }
        
        // Devuelve el la duracion total de un contenido
        public int DuracionPorContenido(string contenido)
        {
            int minutos= 0;

            foreach (Programa p in programacion)
                if (string.Equals(contenido, p.GetContenido()))
                    minutos += p.GetDuracion();

            return minutos;
        }

        // Crea nuevo programa
        public void NuevoPrograma(Programa nPro, int hora)
        {
            programacion[hora].SetNombre(nPro.GetNombre());
            programacion[hora].SetContenido(nPro.GetContenido());
            programacion[hora].SetDuracion(nPro.GetDuracion());
        }

        // Elimina un programa
        public void Borrar(int hora) { programacion[hora].Borrar(); }

        // Resta duracion a un programa
        public string CambiarDuracion(int hora, int nDuracion)
        {
            string aux;

            if (programacion[hora].GetDuracion() - nDuracion < 0)
            {
                programacion[hora].SetDuracion(nDuracion);
                aux = "Duración cambiada.";
            }
            else
                aux = "Se resta demasiado.";

            return aux;
        }

        // Metodos privados
        private void iniciarProgramas(int p)
        {
            programacion = new Programa[p];

            for (int i = 0; i < programacion.Length; i++)
                programacion[i] = new Programa();
        }               
    }
}