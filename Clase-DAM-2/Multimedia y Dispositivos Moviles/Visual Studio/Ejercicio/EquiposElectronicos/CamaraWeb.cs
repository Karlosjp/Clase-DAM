using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposElectronicos
{
    class CamaraWeb : Camara
    {
        private double mPixeles, maxZoom;

        public CamaraWeb()
        {
            mPixeles = 0;
            maxZoom = 0;
            peso = 0;
            marca = "";
            objetivo = "";
        }

        public string Escribir()
        {
            return "Resolucion: " + mPixeles + " Zoom: " + maxZoom + base.Escribir();
        }

        public void Vaciar()
        {
            mPixeles = 0;
            maxZoom = 0;
            peso = 0;
            marca = "";
            objetivo = "";
        }
    }
}
