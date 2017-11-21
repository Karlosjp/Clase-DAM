using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposElectronicos
{
    class Camara
    {
        protected string marca, objetivo;
        protected Double peso;

        protected virtual string Escribir()
        {
            return "Marca: " + marca + " Objetivo: " + objetivo +
                " Peso: " + peso;
        }

        protected virtual void Vaciar()
        {
            marca = "";
            objetivo = "";
            peso = 0;
        }
    }
}
