using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Compra
    {
        public Compra()
        {
            pComprado = new Producto();
            importe = 0;
            fecha = DateTime.Today;
            codigoCompra = 0;
            compraCliente = new Cliente();
        }

        public Compra(int codigoCompra, Producto pComprado, double importe, DateTime fecha, Cliente compraCliente)
        {
            this.pComprado = pComprado;
            this.importe = importe;
            this.fecha = fecha;
            this.codigoCompra = codigoCompra;
            this.compraCliente = compraCliente;
        }

        // Get and Set
        // Cambia la fecha de la compra
        public DateTime fecha { get; set; }

        // Cambia y devuelve el importe de la compra
        public double importe { set; get; }

        // Devuelve el codigo de la compra
        public int codigoCompra { get; }

        // Devuelve el producto comprado
        public Producto pComprado { get; }

        // Devuelve el cliente que hizo la compra
        public Cliente compraCliente { get; }

        // Metodos
        // Devuelve el mes de la compra
        public string Mes()
        {
            return fecha.Month.ToString();
        }

        // Devuelve los datos de la compra: Datos cliente, codigo compra, importe y datos del producto
        public string Escribir()
        {
            return compraCliente.Escribir() + ":" + codigoCompra + ":" + importe + ":" + pComprado.Escribir();
        }
    }
}