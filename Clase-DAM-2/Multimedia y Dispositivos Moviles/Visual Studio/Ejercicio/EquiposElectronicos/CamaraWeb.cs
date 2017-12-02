using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposElectronicos
{
    class CamaraWeb : Camara
    {
        private string pixeles;
        private double zoom;

        public CamaraWeb() : base()
        {
            pixeles = "";
            zoom = 0;

        }

        public CamaraWeb(string m, string o, double p, string mPixeles, double maxZoom) : base(m,o,p)
        {
            this.pixeles = mPixeles;
            this.zoom = maxZoom;
        }

        new public string Escribir()
        {
            return "Resolucion: " + pixeles + " Zoom: " + zoom + base.Escribir();
        }

        new public void Vaciar()
        {
            base.Vaciar();
            pixeles = "";
            zoom = 0;
        }
    }
}
