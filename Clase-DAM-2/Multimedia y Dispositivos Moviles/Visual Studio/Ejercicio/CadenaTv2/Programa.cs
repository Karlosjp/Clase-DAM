﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenaTv2
{
    class Programa
    {

        private string nombre, contenido;
        private int duracion, hInicio, hFin;

        // constructores
        public Programa()
        {
            nombre = "Ninguno";
            contenido = "Ninguno";
            duracion = 0;
            hInicio = 0;
            hFin = 0;
        }

        public Programa(int i, int f)
        {
            hInicio = i;
            hFin = f;
            nombre = "Ninguno";
            contenido = "Ninguno";
            duracion = 0;
        }

        // Seters
        public void SetNombre(string n)
        {
            nombre = n;
        }

        public void SetContenido(string c)
        {
            contenido = c;
        }

        public void SetDuracion(int d)
        {
            duracion = d;
        }

        public void SetHInicio(int i)
        {
            hInicio = i;
        }

        public void SetHFin(int f)
        {
            hFin = f;
        }

        // Geters
        public int GetHInicio()
        {
            return hInicio;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetContenido()
        {
            return contenido;
        }

        public int GetDuracion()
        {
            return duracion;
        }

        public int GetHFin()
        {
            return hFin;
        }

        // Metodos
        public string Escribir()
        {
            return hInicio + ":00 -- " + hFin + ":00\t" + nombre + "\t" + contenido + "\t   --\t" + duracion + " min";
        }

        public bool ComprobarDuracion(int d)
        {
            bool resD = false;

            if (d > 0 && d <= DMaxMinutos())
            {
                resD = true;
                duracion -= d;
            }

            return resD;
        }

        public int DMaxMinutos()
        {
            return (hInicio - hFin) * 60;
        }

        public void Borrar()
        {
            nombre = "";
            contenido = "";
            duracion = 0;
            hInicio = 0;
            hFin = 0;
        }
    }
}
