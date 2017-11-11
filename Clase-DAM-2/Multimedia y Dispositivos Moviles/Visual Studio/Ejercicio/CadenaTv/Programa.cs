using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv
{
    class Programa
    {

        private string nombre, contenido;
        private int duracion, hInicio, hFin;

        // constructores
        public Programa()
        {
            nombre = "";
            contenido = "";
            duracion = 0;
            hInicio = 8;
            hFin = 10;
        }

        public Programa(int i, int f)
        {
            hInicio = i;
            hFin = f;
        }
    
        // Seters
        public void setNombre(string n)
        {
            nombre = n;
        }

        public void setContenido(string c)
        {
            contenido = c;
        }

        public void setDuracion(int d)
        {
            duracion = d;
        }

        public void setHInicio(int i)
        {
            hInicio = i;
        }

        public void setHFin(int f)
        {
            hFin = f;
        }

        // Geters
        public int getHInicio()
        {
            return hInicio;
        }
        
        public int getHFin()
        {
            return hFin;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getContenido()
        {
            return contenido;
        }

        public int getDuracion()
        {
            return duracion;
        }
    }
}
