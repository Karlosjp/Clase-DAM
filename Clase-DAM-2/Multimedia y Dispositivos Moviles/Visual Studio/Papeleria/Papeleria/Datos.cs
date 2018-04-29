using System;
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
        private static string[] separador = new string[] { ":" };

        public const string CONSUMIBLE = "Consumible";
        public const string REPROGRAFIA = "Reprografia";
        public const string ACCESORIO = "Accesorio";
        public const string VENTAS = "Ventas";        
        public const string PRODUCTO = "Producto";
        public const string CLIENTE = "Cliente";
        public const string MES = "Mes";
        public static readonly string[] meses = new string[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Nobiembre", "Diciembre"};
        public static readonly string[] producto = new string[] { "Nombre", "Tipo", "Código", "Precio" };
        public static readonly string[] consumible = new string[] { "Fecha Fabricación", "Peso" };
        public static readonly string[] accesorio = new string[] { "Peso", "Material" };
        public static readonly string[] reprografia = new string[] { "Material", "Color", "Fabricante" };
        public static readonly string[] resumenSecundario = new string[] { "Tipo", "Cantidad", "Importe total" };
        public static readonly string[] resumenPrincipal = new string[] { "Fecha compra", "Codigo compra", "Codigo comprador", "Nombre comprador", "Codigo producto", "Tipo producto", "Nombre producto", "Precio" };


        // Devuelve el listado completo de clientes
        public static List<Cliente> Clientes { get { return clientes; } }
        // Devuelve el listado completo de productos
        public static List<Producto> Productos { get { return productos; } }
        // Devuelve el listado completo de compras realizadas    
        public static List<Compra> Compras { get { return compras; } }
        public static string[] Separador { get { return separador; } }
        public static string CarpetaPadre { get { return carpetaPadre; } }

        // Devuelve un producto seleccionado
        public static Producto ProductoElegido(int pe)
        {
            return productos[pe];
        }

        // Devuelve un cliente selecionado
        public static Cliente ClienteElegido(int ce)
        {
            return clientes[ce];
        }

        // Agrega del documento indicado los clientes a la lista de la tienda
        public static void CargarClientes()
        {
            string lCliente, ruta = Path.Combine(carpetaPadre, @"Archivos\Clientes.txt");
            string[] nC;
            

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
                        nC = lCliente.Split(Separador, StringSplitOptions.RemoveEmptyEntries);

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
        public static void CargarProductos()
        {
            string lProducto, ruta = Path.Combine(carpetaPadre, @"Archivos\Productos.txt");
            string[] nProducto;

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
                        nProducto = lProducto.Split(separador, StringSplitOptions.RemoveEmptyEntries);
                        // Separa los datos recogidos segun su tipo y los agrega a la lista
                        switch (nProducto[1])
                        {
                            case CONSUMIBLE:
                                // Formato Consumible (0)Nombre: (1)Tipo: (2)Codigo: (3)Precio: (4)Peso: (6)Fabricacion
                                productos.Add(new Consumible(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), double.Parse(nProducto[4]), OrdenarFecha(nProducto[5])));
                                break;
                            case REPROGRAFIA:
                                // Formato Reprografia (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Material:(5)Color:(6)Fabricante
                                Reprografia r = new Reprografia(nProducto[0], nProducto[1], Int32.Parse(nProducto[2]), double.Parse(nProducto[3]), nProducto[4], nProducto[5], nProducto[6]);
                                productos.Add(r);
                                break;
                            case ACCESORIO:
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
                
        // Guarda los datos de los productos 
        public static void GuardarVentas(int codigoVenta)
        {
            string ventas = Path.Combine(carpetaPadre, @"Archivos\Ventas.txt");

            try
            {
                if (!Directory.Exists(carpetaPadre))
                    Directory.CreateDirectory(carpetaPadre);

                if (!File.Exists(ventas))
                    File.Create(ventas);

                StreamWriter sw = new StreamWriter(ventas);

                sw.WriteLine(codigoVenta);

                foreach (Compra c in Datos.Compras)
                    sw.WriteLine(c.Escribir());

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Crea el producto consumible y lo agrega a la lista Productos Formato :
        public static DateTime OrdenarFecha(string nFecha)
        {
            // Formato Consumible (0)Nombre:(1)Tipo:(2)Codigo:(3)Precio:(4)Peso:(5)Fabricacion
            string[] f;
            string[] stringSeparators = new string[] { "/" };
            f = nFecha.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
            

            return new DateTime (Int32.Parse(f[2]), Int32.Parse(f[1]), Int32.Parse(f[0]));
        }        
    }
}
