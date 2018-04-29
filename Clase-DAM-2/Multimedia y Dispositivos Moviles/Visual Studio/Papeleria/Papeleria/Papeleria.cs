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
        public int codCompra;
        public Papeleria()
        {
            codCompra = 0;
        }

        public int CodCompra { get { return codCompra; } }

        // Agrega del documento indicado las ventas a la lista de la tienda
        public void CargarVentas()
        {
            string lVenta, ruta = Path.Combine(Datos.CarpetaPadre, @"Archivos\Ventas.txt");
            string[] nVenta;

            try
            {
                if (File.Exists(ruta))
                {
                    // Abre el documento de la lista de productos en la ruta indicada
                    StreamReader sr = new StreamReader(ruta);
                    lVenta = sr.ReadLine();

                    // Lee una linea e introduce el producto en la lista  hasta llegar a la ultimo
                    while (lVenta != null)
                    {
                        nVenta = lVenta.Split(Datos.Separador, StringSplitOptions.RemoveEmptyEntries);
                        if (nVenta.Length == 1)
                        {
                            codCompra = Int32.Parse(nVenta[0]);
                            lVenta = sr.ReadLine();
                            nVenta = lVenta.Split(Datos.Separador, StringSplitOptions.RemoveEmptyEntries);
                        }

                        Datos.Compras.Add(new Compra(Datos.OrdenarFecha(nVenta[0]), Int32.Parse(nVenta[1]), Convert.ToDouble(nVenta[2]),
                                    Buscar(nVenta[4]), Buscar(Int32.Parse(nVenta[7]))));

                        // Lee la siguiente linea
                        lVenta = sr.ReadLine();
                    }

                    // Cierra el documento
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        // Registra la compra hecha por un cliente
        public void HacerCompra( Producto productoComprado, int cliente, double importe)
        {
            codCompra++;
            Compra c = new Compra(DateTime.Today, CodCompra, importe, Datos.ClienteElegido(cliente), productoComprado);
            Datos.Compras.Add(c);
        }
                
        //Recibe un codigo de compra de una compra. Busca la compra y borra el producto de la lista compras
        public void EliminarCompra(int codigo)
        {
            foreach (Compra c in Datos.Compras)
                if (c.codigoCompra == codigo)
                {
                    Datos.Compras.Remove(c);
                    break;
                }
        }

        //Recibe un codigo de compra de una compra a modificar y cambia su fecha de compra y/o su importe al indicado
        public void ModificarCompra(int codigo, DateTime nFecha, double nImporte)
        {
            foreach (Compra c in Datos.Compras)
                if (c.codigoCompra == codigo)
                {
                    if (nFecha != null)
                        c.fecha = nFecha;
                    if (nImporte > -1)
                        c.importe = nImporte;
                }
        }

        // Devuelve los datos de un cliente de la lista
        private Cliente Buscar(string dni)
        {
            Cliente cliente = new Cliente();
            foreach (Cliente c in Datos.Clientes)
                if (c.dni.Equals(dni))
                {
                    cliente = c;
                    break;
                }

            return cliente;
        }

        // Devuelve los datos de un producto de la lista
        private Producto Buscar(int codigo)
        {
            Producto producto = new Producto();
            foreach (Producto p in Datos.Productos)
                if (p.codigo.Equals(codigo))
                {
                    producto = p;
                    break;
                }

            return producto;
        }

        // Devuelve una Lista string de los nombres de clientes
        public List<string> ListaDatosClientes()
        {
            List<string> listaDatos = new List<string>();
            foreach (Cliente c in Datos.Clientes)
                listaDatos.Add(c.dni + Datos.Separador[0] + c.nombre);

            return listaDatos;
        }

        // Devuelve una lista con las compras realizadas en el mes indicado
        public List<Compra> Listado(int mes)
        {
            List<Compra> cMes = new List<Compra>();

            foreach (Compra c in Datos.Compras)
                if (mes.Equals(c.Mes()))
                    cMes.Add(c);

            return cMes;
        }

        // Devuelve una lista con las compras realizadas de un tipo indicado
        public List<Compra> Listado(string tipo)
        {
            List<Compra> cTipo = new List<Compra>();

            foreach (Compra c in Datos.Compras)
                if (tipo.Equals(c.pComprado.tipo))
                    cTipo.Add(c);

            return cTipo;
        }

        // Devuelve una lista con las compras realizadas de un tipo indicado 
        public List<Compra> Listado(Cliente cliente)
        {
            List<Compra> cCliente = new List<Compra>();

            foreach (Compra c in Datos.Compras)
                if (cliente.Equals(c.compraCliente))
                    cCliente.Add(c);

            return cCliente;
        }

        // Devuelve una lista con las compras realizadas de un producto indicado
        public List<Compra> Listado(Producto producto)
        {
            List<Compra> listaProducto = new List<Compra>();

            foreach (Compra c in Datos.Compras)
                if (producto.Equals(c.pComprado))
                    listaProducto.Add(c);

            return listaProducto;
        }

        // Devuelve el importe total de un tipo de producto vendido
        public double ImporteTotal(string tipo)
        {
            double importeTotal = 0;
            foreach (Compra c in Listado(tipo))
                importeTotal += c.importe;

            return importeTotal;
        }

        // Devuelve la cantidad total por tipo de productos vendidos
        public int CantidadTipoProducto(string tipo)
        {
            return Listado(tipo).Count;
        }

        // Borra las compras y el cliente del dni indicado
        public void EliminarCliente(string dni)
        {
            List<Compra> aBorrar = new List<Compra>();

            foreach (Compra co in Datos.Compras)
                if (co.compraCliente.dni.Equals(dni))
                    aBorrar.Add(co);

            foreach (Cliente cl in Datos.Clientes)
                if (cl.dni.Equals(dni))
                {
                    Datos.Clientes.Remove(cl);
                    break;
                }
                    

            foreach (Compra co2 in aBorrar)
                Datos.Compras.Remove(co2);
        }
    }
}