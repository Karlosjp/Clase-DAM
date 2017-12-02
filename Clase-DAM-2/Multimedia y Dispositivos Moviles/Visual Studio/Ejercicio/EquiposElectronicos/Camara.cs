using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposElectronicos
{
    class Camara
    {
        private string marca;
        private string objetivo;
        private double peso;

        public Camara()
        {
            marca = "";
            objetivo = "";
            peso = 0;
        }

        public Camara(string marca, string objetivo, double peso)
        {
            this.marca = marca;
            this.objetivo = objetivo;
            this.peso = peso;
        }

        public string Escribir()
        {
            return "Marca: " + marca + " Objetivo: " + objetivo +
                " Peso: " + peso;
        }

        public void Vaciar()
        {
            marca = "";
            objetivo = "";
            peso = 0;
        }
    }
}
