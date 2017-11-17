using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv2
{
    class Programa
    {
        private string nombre, contenido;
        private int duracion;

        // constructores
        public Programa()
        {
            nombre = "";
            contenido = "";
            duracion = 0;
        }

        public Programa(string nombre, string contenido, int duracion)
        {
            this.nombre = nombre;
            this.contenido = contenido;
            this.duracion = duracion;
        }

        // Seters
        public void SetNombre(string nombre) { this.nombre = nombre; }

        public void SetContenido(string contenido) { this.contenido = contenido; }

        public void SetDuracion(int duracion) { this.duracion = duracion; }

        // Geters
        public string GetNombre() { return nombre; }

        public string GetContenido() { return contenido; }

        public int GetDuracion() { return duracion; }
        
        // Metodos 

        // Devuelve el contenido de Programa
        public string Escribir() { return nombre + "\t" + contenido + "\t   --\t" + duracion + " min"; }
        
        public void Borrar()
        {
            nombre = "";
            contenido = "";
            duracion = 0;
        }
    }
}
