﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Producto
    {
        protected string marca, nombre;
        protected int ram, id;
        protected double precio;

        public Producto()
        {
            marca = "";
            nombre = "";
            ram = 0;
            precio = 0;
        }

        public Producto(int id, string m, string n, int r, double p)
        {
            this.id = id;
            marca = m;
            nombre = n;
            ram = r;
            precio = p;
        }

        public string Marca
        {
            get { return marca; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        public int Id
        {
            get { return id; }
        }

        public int Ram
        {
            get { return ram; }
            set { ram += value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio += value; }
        }
    }
}