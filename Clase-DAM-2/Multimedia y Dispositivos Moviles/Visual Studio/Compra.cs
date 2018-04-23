using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Compra
    {
        private Producto pComprado;
        private int codigoCompra;
        private double importe;
        private DateTime fecha;
        private Cliente compraCliente;

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
        public DateTime Fecha
        {
            set { fecha = value; }
        }

        // Cambia el importe de la compra
        public double Importe
        {
            set { importe = value; }
            get { return importe; }
        }
        
        // Devuelve el codigo de la compra
        public int CodigoCompra
        {
            get { return codigoCompra; }
        }

        // Devuelve el producto comprado
        public Producto PComprado
        {
            get { return pComprado; }
        }

        // Devuelve el cliente que hizo la compra
        public Cliente CompraCliente
        {
            get { return compraCliente; }
        }

        // Metodos
        // Devuelve el mes de la compra
        public string Mes()
        {
            return fecha.Month.ToString();
        }

        // Devuelve el tipo de producto comprado
        public string Tipo()
        {
            return pComprado.Tipo;
        }

    }
}
