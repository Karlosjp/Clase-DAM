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
        private static int codCompra;
        public Papeleria()
        {
            codCompra = 0;
        }

        // Registra la compra hecha por un cliente
        public void HacerCompra( Producto productoComprado, int cliente, double importe)
        {
            codCompra++;
            Compra c = new Compra(DateTime.Today, codCompra, importe, Datos.ClienteElegido(cliente), productoComprado);
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
    }
}