﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    static class Datos
    {
        private static string carpetaPadre = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        private static List<Cliente> clientes = new List<Cliente>();
        private static List<Producto> productos = new List<Producto>();
        private static List<Compra> compras = new List<Compra>();

        // Devuelve el listado completo de clientes
        public static List<Cliente> Clientes { get { return clientes; } }
        // Devuelve el listado completo de productos
        public static List<Producto> Productos { get { return productos; } }
        // Devuelve el listado completo de compras realizadas    
        public static List<Compra> Compras { get { return compras; } }

        // Devuelve un producto seleccionado
        public static Producto ProductoElegido(int pe)
        {
            return productos[pe];
        }

        // Agrega del documento indicado los clientes a la lista de la tienda
        public static void IniciarClientes()
        {
            string lCliente, ruta = Path.Combine(carpetaPadre, @"Archivos\Clientes.txt");
            string[] nC;
            string[] stringSeparators = new string[] { ":" };

            try
            {
                if (File.Exists(ruta))
                {
                    // Abre el documento de la lista de productos en la ruta indicada
                    StreamReader sr = new StreamReader(ruta);
                    lCliente = sr.ReadLine();

                    // Lee una linea e introduce el producto en la lista  hasta llegar a la ultimo
                    while (lCliente != null)
                    {
                        nC = lCliente.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                        // Separa los datos recogidos segun su tipo y los agrega a la lista
                        // Formato Reprografia (0)Nombre:(1)Direccion:(2)dni:(3)telefono
                        Cliente c = new Cliente(nC[0], nC[1], nC[2], nC[3]);
                        clientes.Add(c);

                        // Lee la siguiente linea
                        lCliente = sr.ReadLine();
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

        // Agrega los productos del archivo indicado a la lista de la tienda   
        public static void IniciarProductos()
        {
            string lProducto, ruta = Path.Combine(carpetaPadre, @"Archivos\Productos.txt");
            string[] nProducto;
            string[] stringSeparators = new string[] { ":" };

            try
            {
                if (File.Exists(ruta))
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
                                // Formato Consumible (0)Nombre: (1)Tipo: (2)Codigo: (3)Precio: (4)Peso: (6)Fabricacion
                                productos.Add(new Consumible(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), double.Parse(nProducto[4]), OrdenarFecha(nProducto[5])));
                                break;
                            case "Reprografia":
                                // Formato Reprografia (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Material:(5)Color:(6)Fabricante
                                Reprografia r = new Reprografia(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), nProducto[4], nProducto[5], nProducto[6]);
                                productos.Add(r);
                                break;
                            case "Accesorio":
                                // Formato Accesorio (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Material
                                Accesorio a = new Accesorio(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), double.Parse(nProducto[4]), nProducto[5]);
                                productos.Add(a);
                                break;
                        }

                        // Lee la siguiente linea
                        lProducto = sr.ReadLine();
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

        // Agrega del documento indicado las ventas a la lista de la tienda
        public static void IniciarVentas()
        {
            string lVenta, ruta = Path.Combine(carpetaPadre, @"Archivos\Ventas.txt");
            string[] nVenta;
            string[] stringSeparators = new string[] { ":" };

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
                        nVenta = lVenta.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

                        compras.Add(new Compra(OrdenarFecha(nVenta[0]), Int32.Parse(nVenta[1]), Convert.ToDouble(nVenta[2]),
                                    BuscarCliente(Int32.Parse(nVenta[4])), BuscarProducto(Int32.Parse(nVenta[7]))));

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

        // Guarda los datos de los productos 
        public static void GuardarVentas()
        {
            string ventas = Path.Combine(carpetaPadre, @"Archivos\Ventas.txt");

            try
            {
                if (!Directory.Exists(carpetaPadre))
                    Directory.CreateDirectory(carpetaPadre);

                if (!File.Exists(ventas))
                    File.Create(ventas);

                StreamWriter sw = new StreamWriter(ventas);

                foreach (Compra c in Datos.Compras)
                    sw.WriteLine(c.Escribir());

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Devuelve los datos de un cliente de la lista
        private static Cliente BuscarCliente(int dni)
        {
            Cliente cliente = new Cliente();
            foreach (Cliente c in clientes)
                if (c.dni.Equals(dni))
                {
                    cliente = c;
                    break;
                }                    

            return cliente;
        }

        // Devuelve los datos de un producto de la lista
        private static Producto BuscarProducto(int codigo)
        {
            Producto producto = new Producto();
            foreach (Producto p in productos)
                if (p.tipo.Equals(codigo))
                {
                    producto = p;
                    break;
                }

            return producto;
        }

        // Crea el producto consumible y lo agrega a la lista Productos Formato :
        private static DateTime OrdenarFecha(string nFecha)
        {
            // Formato Consumible (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Fabricacion
            string[] f;
            string[] stringSeparators = new string[] { "/" };
            f = nFecha.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            

            return new DateTime (Int32.Parse(f[2]), Int32.Parse(f[1]), Int32.Parse(f[0]));
        }

        // Devuelve una Lista string de los nombres de clientes
        public static List<string> ListaNombresClientes()
        {
            List<string> nombres = new List<string>();
            foreach (Cliente c in clientes)
                nombres.Add(c.nombre);

            return nombres;
        }

        // Devuelve una Lista string de los DNI de clientes
        public static List<string> ListaDNIClientes()
        {
            List<string> dni = new List<string>();
            foreach (Cliente c in clientes)
                dni.Add(c.dni);

            return dni;
        }

        // Devuelve un cliente selecionado
        public static Cliente ClienteElegido(int ce)
        {
            return clientes[ce];
        }
    }
}
