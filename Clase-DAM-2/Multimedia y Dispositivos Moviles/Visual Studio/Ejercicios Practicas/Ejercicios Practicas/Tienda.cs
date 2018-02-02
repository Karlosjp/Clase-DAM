using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class  Tienda
    {
        private ArrayList productos;
        /*private ArrayList ordenadores;
        private ArrayList tablet;
        private ArrayList movil;*/

        public Tienda()
        {
            productos = new ArrayList();
            /*tablet = new ArrayList();
            movil = new ArrayList();*/

        }

        public void Eliminar(string tipo, int num)
        {
            switch (tipo)
            {
                case "Ordenador":
                    ordenadores.RemoveAt(num);
                    break;
                case "Tablet":
                    tablet.RemoveAt(num);
                    break;
                case "Movil":
                    movil.RemoveAt(num);
                    break;

            }
        }

        public void Anotar(ArrayList nuevo)
        {
            string n = nuevo[0].ToString();
            switch (n)
            {
                case "Ordenador":
                    AnotarOrdenadores(nuevo);
                    break;
                case "Movil":
                    AnotarMovil(nuevo);
                    break;
                case "Tablet":
                    AnotarTablet(nuevo);
                    break;
            }
        }

        public ArrayList Mostrar(string tipo)
        {
            ArrayList lista = new ArrayList();

            switch (tipo)
            {
                case "Ordenadores":
                    lista = ordenadores;
                    break;
                case "Movil":
                    lista = movil;
                    break;
                case "Tablet":
                    lista = tablet;
                    break;
            }

            return lista;
        }

        public void Modificar(int ram)
        {
            foreach (Ordenador ord in ordenadores)
                ord.Ram = ram;

            foreach (Movil mov in movil)
                mov.Ram = ram;

            foreach (Tablet tab in tablet)
                tab.Ram = ram;
        }

        public void Modificar(int ram, string tipo)
        {
            switch (tipo)
            {
                case "ordenadores":
                    foreach (Ordenador ord in ordenadores)
                        ord.Ram = ram;
                    break;
                case "tablet":
                    foreach (Tablet tab in tablet)
                        tab.Ram = ram;
                    break;
                case "movil":
                    foreach (Movil mov in movil)
                        mov.Ram = ram;
                    break;
            }
        }

        public void Modificar(string tipo, int num, double pre)
        {
            switch (tipo)
            {
                case "ordenadores":
                    ((Ordenador)ordenadores[num]).Precio = pre;
                    break;
                case "tablet":
                    ((Tablet)tablet[num]).Precio = pre;
                    break;
                case "movil":
                    ((Movil)movil[num]).Precio = pre;
                    break;
            }

        }

        private void AnotarMovil(ArrayList nMov)
        {
            Movil nMovil = new Movil((string)nMov[1], (string)nMov[2], Convert.ToInt32(nMov[3]),
                Convert.ToDouble(nMov[4]), Convert.ToDouble(nMov[5]), Convert.ToDouble(nMov[6]), (string)nMov[7]);
            movil.Add(nMovil);
        }

        private void AnotarOrdenadores(ArrayList nOrd)
        {
            Ordenador nOrdenador = new Ordenador((string)nOrd[1], (string)nOrd[2], Convert.ToInt32(nOrd[3]),
                Convert.ToDouble(nOrd[4]), Convert.ToDouble(nOrd[5]), Convert.ToInt32(nOrd[6]));
            ordenadores.Add(nOrdenador);
        }

        private void AnotarTablet(ArrayList nTab)
        {
            Tablet nTablet = new Tablet((string)nTab[1], (string)nTab[2], Convert.ToInt32(nTab[3]),
                Convert.ToDouble(nTab[4]), Convert.ToDouble(nTab[5]), Convert.ToDouble(nTab[6]));
            tablet.Add(nTablet);
        }
    }
}
