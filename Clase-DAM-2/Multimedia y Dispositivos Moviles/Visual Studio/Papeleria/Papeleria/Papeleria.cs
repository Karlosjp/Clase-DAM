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

        // Devuelve la cantidad de productos de un tipo vendidas
        public double Listado(List<Compra> calculaImporte)
        {
            double importeTotal = 0;
            foreach (Compra cI in calculaImporte)
                importeTotal += cI.importe;

            return importeTotal;
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
                    Datos.Clientes.Remove(cl);

            foreach (Compra co2 in aBorrar)
                Datos.Compras.Remove(co2);
        }
    }
}