using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Cliente
    {
        public Cliente()
        {
            this.nombre = "";
            this.direccion = "";
            this.dni = "";
            this.telefono = "";
        }

        public Cliente(string nombre, string direccion, string dni, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.dni = dni;
            this.telefono = telefono;
        }

        public string nombre { get; }

        public string direccion { get; }

        public string telefono { get; }

        public string dni { get; }

        public string Escribir()
        {
            return nombre + ":" + dni;
        }
    }
}
