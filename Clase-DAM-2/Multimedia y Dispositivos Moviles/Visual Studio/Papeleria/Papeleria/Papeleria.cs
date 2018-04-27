using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Papeleria
    {
        private List<Producto> productos;
        private List<Cliente> clientes;
        private List<Compra> compras; 

        public Papeleria()
        {
            productos = new List<Producto>();
            clientes = new List<Cliente>();
            compras = new List<Compra>();
        }

        // Devuelve el listado completo de compras realizadas
        public List<Compra> Compras
        {
            get { return compras; }
        }

        // Guarda los datos de los productos
        public void GuardarVentas(string carpeta, string archivo)
        {
            try
            {
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                if (!File.Exists(carpeta + @"\" + archivo))
                    File.Create(carpeta + @"\" + archivo);

                StreamWriter sw = new StreamWriter(carpeta + @"\" + archivo);

                foreach (Compra c in compras)
                    sw.WriteLine(c.Escribir());

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Agrega los productos del archivo indicado a la lista de productos.     
        public void IniciarProductos(string ruta)
        {
            string lProducto;
            string[] nProducto;
            string[] stringSeparators = new string[] { ":" };

            try
            {
                // Abre el documento de la lista de productos en la ruta indicada
                StreamReader sr = new StreamReader(ruta);
                lProducto = sr.ReadLine();

                // Lee una linea e introduce el producto en la lista  hasta llegar a la ultimo
                while (lProducto != null)
                {
                    nProducto = lProducto.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                    // Separa los datos recogidos segun su tipo y los agrega a la lista
                    switch (nProducto[1])
                    {
                        case "Consumible":
                            NuevoConsumible(nProducto);
                            break;
                        case "Reprografia":
                            // Formato Reprografia (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Material:(5)Color:(6)Fabricante
                            Reprografia r = new Reprografia(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), nProducto[4], nProducto[5], nProducto[6]);
                            productos.Add(r);
                            break;
                        case "Accesorio":
                            // Formato Accesorio (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Material
                            Accesorio a = new Accesorio(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), double.Parse(nProducto[4]),nProducto[5]);
                            productos.Add(a);
                            break;
                    }

                    // Lee la siguiente linea
                    lProducto = sr.ReadLine();
                }

                // Cierra el documento
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        //Recibe un codigo de compra de una compra. Busca la compra y borra el producto de la lista compras
        public void EliminarCompra(int codigo)
        {
            foreach (Compra c in compras)
                if (c.CodigoCompra == codigo)
                    compras.Remove(c);
        }

        //Recibe un codigo de compra de una compra a modificar y cambia su fecha de compra y/o su importe al indicado.
        public void ModificarCompra(int codigo, DateTime nFecha, double nImporte)
        {
            foreach (Compra c in compras)
                if (c.CodigoCompra == codigo)
                {
                    if (nFecha != null)
                        c.Fecha = nFecha;
                    if (nImporte > -1)
                        c.Importe = nImporte;
                }
        }

        // Devuelve una lista con las compras realizadas en el mes indicado
        public List<Compra> ListadoPorMes(string mes)
        {
            List<Compra> cMes = new List<Compra>();

            foreach (Compra c in compras)
                if (mes.Equals(c.Mes()))
                    cMes.Add(c);

            return cMes;
        }

        // Devuelve una lista con las compras realizadas de un tipo indicado
        public List<Compra> ListadoPorTipo(string tipo)
        {
            List<Compra> cTipo = new List<Compra>();

            foreach (Compra c in compras)
                if (tipo.Equals(c.Tipo()))
                    cTipo.Add(c);

            return cTipo;
        }

        // Devuelve una lista con las compras realizadas de un tipo indicado
        public List<Compra> ListadoPorCliente(Cliente cliente)
        {
            List<Compra> cCliente = new List<Compra>();

            foreach (Compra c in compras)
                if (cliente.Equals(c.CompraCliente))
                    cCliente.Add(c);

            return cCliente;
        }


        // Devuelve la cantidad de productos de un tipo vendidas
        public double TotalImportePorTipo(List<Compra> cImporte)
        {
            double importeTotal = 0;
            foreach (Compra cI in cImporte)
                importeTotal += cI.Importe;

            return importeTotal;
        }

        // Borra las compras y el cliente del dni indicado
        public void EliminarCliente(string dni)
        {
            foreach (Compra co in compras)
                if (co.CompraCliente.Dni.Equals(dni))
                    compras.Remove(co);

            foreach (Cliente cl in clientes)
                if (cl.Dni.Equals(dni))
                    clientes.Remove(cl);
        }

        public List<Producto> MostrarProductos()
        {
            return productos;
        }

        // Crea el producto consumible y lo agrega a la lista Productos Formato (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(6)Fabricacion:
        private void NuevoConsumible(string[] nProducto)
        {
            // Formato Consumible (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Fabricacion
            string[] f;
            string[] stringSeparators = new string[] { "/" };
            f = nProducto[5].Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            DateTime fecha = new DateTime(Int32.Parse(f[0]), Int32.Parse(f[1]), Int32.Parse(f[2]));
            
            Consumible c = new Consumible(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), double.Parse(nProducto[4]), fecha);
            productos.Add(c);
        }

        // Crea el producto Reprografia y lo agrega a la lista Productos
        // Formato (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Material:(6)Fabricacion:(7)Color:(8)Fabricante
        /*private void NuevoReprografia(string[] nProducto)
        {
            Reprografia c = new Reprografia(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]),nProducto[5],nProducto[7],nProducto[8]);
            productos.Add(c);
        }*/

        // Crea el producto Accesorio y lo agrega a la lista Productos
        // Formato (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Material:(6)Fabricacion:(7)Color:(8)Fabricante
        /*private void NuevoAccesorio(string[] nProducto)
        {
            Accesorio c = new Accesorio(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), nProducto[5], double.Parse(nProducto[4]));
            productos.Add(c);
        }*/
    }
}