﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Consumible : Producto
    {
        public Consumible()
            : base()
        {
            fechaFabricacion = DateTime.Today;
            peso = 0;
        }

        public Consumible(string n, string t, int c, double p, double peso, DateTime fechaFabricacion)
            : base(n, t, c, p)
        {
            this.fechaFabricacion = fechaFabricacion;
            this.peso = peso;
        }

        public DateTime fechaFabricacion { get; }

        public double peso { get; }

        // Devuelve los datos del producto
        // Formato Consumible (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Fabricacion
        public override string Escribir()
        {
            return base.Escribir() + ":" + peso + ":" + fechaFabricacion.ToShortDateString();
        }
    }
}
