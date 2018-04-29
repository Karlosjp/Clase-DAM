using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Compra
    {
        public double importe;

        public Compra()
        {
            pComprado = new Producto();
            importe = 0;
            fecha = DateTime.Today;
            codigoCompra = 0;
            compraCliente = new Cliente();
        }

        public Compra(DateTime fecha, int codigoCompra, double importe, Cliente compraCliente, Producto pComprado)
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
        public double Importe
        {
            get { return importe; }
            set { importe = value; }
        }

        // Devuelve el codigo de la compra
        public int codigoCompra { get; }

        // Devuelve el producto comprado
        public Producto pComprado { get; }

        // Devuelve el cliente que hizo la compra
        public Cliente compraCliente { get; }

        // Metodos
        // Devuelve el mes de la compra
        public int Mes()
        {
            return fecha.Month;
        }

        // Devuelve los datos de la compra: Datos cliente, codigo compra, importe y datos del producto
        // Consumible --> (0)FechaCompra:(1)CodigoCompra:(2)Importe:(3)NombreCliente:(4)DNICliente:(5)NombreProducto:(6)Tipo:(7)Codigo:(8)Precio:(9)Peso:(10)FechaFabricacion
        // Reprografia --> (0)FechaCompra:(1)CodigoCompra:(2)Importe:(3)NombreCliente:(4)DNICliente:(5)NombreProducto:(6)Tipo:(7)Codigo:(8)Precio:(9)Material:(10)Color:(11)Fabricante
        // Accesorio --> (0)FechaCompra:(1)CodigoCompra:(2)Importe:(3)NombreCliente:(4)DNICliente:(5)NombreProducto:(6)Tipo:(7)Codigo:(8)Precio:(9)Peso:(10)Material
        public string Escribir()
        {
            return fecha.ToShortDateString() + ":" + codigoCompra + ":" + importe + ":" + compraCliente.Escribir() + ":" + pComprado.Escribir();
        }
    }
}