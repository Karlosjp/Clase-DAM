﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposElectronicos
{
    class CamaraIP : Camara
    {
        private string dirMAC;
        private string iP;

        public CamaraIP()
        {
            dirMAC = "";
            iP = "";
        }

        public string Escribir()
        {
            return "Direccion MAC: " + dirMAC + " Direccion IP" + iP + base.Escribir();
        }

        public void Vaciar()
        {
            dirMAC = "";
            iP = "";
            base.Vaciar();
        }
    }
}
