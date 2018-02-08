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

        public Tienda(){ productos = new ArrayList(); }

        public void Eliminar(string tipo, int num)
        {/*
            switch (tipo)
            {
                case "Ordenador":
                    productos.RemoveAt(num);
                    break;
                case "Tablet":
                    productos.RemoveAt(num);
                    break;
                case "Movil":
                    productos.RemoveAt(num);
                    break;

            }*/
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

            foreach (Object o in productos)
                if (o.GetType().Name.Equals(tipo))
                    lista.Add(o);

            return lista;
        }

        public ArrayList Productos
        {
            get { return productos; }
        }

        public void Modificar(int ram)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].GetType().Name.Equals("Ordenador"))
                    ((Ordenador)productos[i]).Ram = ram;
                else if (productos[i].GetType().Name.Equals("Movil"))
                    ((Movil)productos[i]).Ram = ram;
                else if (productos[i].GetType().Name.Equals("Tablet"))
                    ((Tablet)productos[i]).Ram = ram;
            }
        }

        public void Modificar(int ram, string tipo)
        {
            switch (tipo)
            {
                case "Ordenador":
                    foreach (Object o in productos)
                        if (o.GetType().Name.Equals("Ordenador"))
                            ((Ordenador)o).Ram = ram;
                    break;
                case "Tablet":
                    foreach (Object o in productos)
                        if (o.GetType().Name.Equals("Tablet"))
                            ((Tablet)o).Ram = ram;
                    break;
                case "Movil":
                    foreach (Object o in productos)
                        if (o.GetType().Name.Equals("Movil"))
                            ((Movil)o).Ram = ram;
                    break;
            }
        }

        public void Modificar(int num, double pre)
        {
            string t = productos[num].GetType().ToString();

            switch (t)
            {
                case "Ordenador":
                    ((Ordenador)productos[num]).Precio = pre;
                    break;
                case "Tablet":
                    ((Tablet)productos[num]).Precio = pre;
                    break;
                case "Movil":
                    ((Movil)productos[num]).Precio = pre;
                    break;
            }
        }

        private void AnotarMovil(ArrayList nMov)
        {
            Movil nMovil = new Movil((string)nMov[1], (string)nMov[2], Convert.ToInt32(nMov[3]),
                Convert.ToDouble(nMov[4]), Convert.ToDouble(nMov[5]), Convert.ToDouble(nMov[6]), (string)nMov[7]);
            productos.Add(nMovil);
        }

        private void AnotarOrdenadores(ArrayList nOrd)
        {
            Ordenador nOrdenador = new Ordenador((string)nOrd[1], (string)nOrd[2], Convert.ToInt32(nOrd[3]),
                Convert.ToDouble(nOrd[4]), Convert.ToDouble(nOrd[5]), Convert.ToInt32(nOrd[6]));
            productos.Add(nOrdenador);
        }

        private void AnotarTablet(ArrayList nTab)
        {
            Tablet nTablet = new Tablet((string)nTab[1], (string)nTab[2], Convert.ToInt32(nTab[3]),
                Convert.ToDouble(nTab[4]), Convert.ToDouble(nTab[5]), Convert.ToDouble(nTab[6]));
            productos.Add(nTablet);
        }
    }
}
