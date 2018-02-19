using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Practicas
{
    class Tienda
    {
        private int idProducto;
        private ArrayList productos;

        public Tienda() { idProducto = 0; productos = new ArrayList(); }

        public void Eliminar(int id)
        {
            for(int i = 0; i < productos.Count; i++)
                if (((Producto)productos[i]).Id == id)
                    productos.RemoveAt(i);
        }

        public void Anotar(ArrayList nuevo)
        {
            string n = nuevo[0].ToString();
            switch (n)
            {
                case "Ordenador":
                    AnotarOrdenadores(nuevo);
                    idProducto++;
                    break;
                case "Movil":
                    AnotarMovil(nuevo);
                    idProducto++;
                    break;
                case "Tablet":
                    AnotarTablet(nuevo);
                    idProducto++;
                    break;
            }
        }

        public ArrayList Mostrar(string tipo)
        {
            ArrayList lista = new ArrayList();

            foreach (Producto o in productos)
                switch (tipo)
                {
                    case "Ordenador":
                        if (o is Ordenador)
                            lista.Add(o);
                        break;
                    case "Movil":
                        if (o is Movil)
                            lista.Add(o);
                        break;
                    case "Tablet":
                        if (o is Tablet)
                            lista.Add(o);
                        break;
                }

            return lista;
        }

        public ArrayList Productos
        {
            get { return productos; }
        }

        public void Modificar(int ram)
        {
            foreach (Object o in productos)
                if (o.GetType().Name.Equals("Ordenador"))
                    ((Ordenador)o).Ram = ram;
                else if (o.GetType().Name.Equals("Movil"))
                    ((Movil)o).Ram = ram;
                else if (o.GetType().Name.Equals("Tablet"))
                    ((Tablet)o).Ram = ram;
        }

        public void Modificar(int ram, string tipo)
        {
            foreach (Object o in productos)
                if (o.GetType().Name.Equals(tipo))
                    switch (tipo)
                    {
                        case "Ordenador":
                            ((Ordenador)o).Ram = ram;
                            break;
                        case "Tablet":
                            ((Tablet)o).Ram = ram;
                            break;
                        case "Movil":
                            ((Movil)o).Ram = ram;
                            break;
                    }
        }

        public void Modificar(Object mod, double pre)
        {
            string t = mod.GetType().ToString();

            foreach (Object o in productos)
                if (o.Equals(mod))
                    switch (t)
                    {
                        case "Ordenador":
                            ((Ordenador)o).Precio = pre;
                            break;
                        case "Tablet":
                            ((Tablet)o).Precio = pre;
                            break;
                        case "Movil":
                            ((Movil)o).Precio = pre;
                            break;
                    }
        }

        private void AnotarMovil(ArrayList nMov)
        {
            Movil nMovil = new Movil(idProducto, (string)nMov[1], (string)nMov[2], Convert.ToInt32(nMov[3]),
                Convert.ToDouble(nMov[4]), Convert.ToDouble(nMov[5]), Convert.ToDouble(nMov[6]), (string)nMov[7]);
            productos.Add(nMovil);
        }

        private void AnotarOrdenadores(ArrayList nOrd)
        {
            Ordenador nOrdenador = new Ordenador(idProducto, (string)nOrd[1], (string)nOrd[2], Convert.ToInt32(nOrd[3]),
                Convert.ToDouble(nOrd[4]), Convert.ToDouble(nOrd[5]), Convert.ToInt32(nOrd[6]));
            productos.Add(nOrdenador);
        }

        private void AnotarTablet(ArrayList nTab)
        {
            Tablet nTablet = new Tablet(idProducto, (string)nTab[1], (string)nTab[2], Convert.ToInt32(nTab[3]),
                Convert.ToDouble(nTab[4]), Convert.ToDouble(nTab[5]), Convert.ToDouble(nTab[6]));
            productos.Add(nTablet);
        }
    }
}
