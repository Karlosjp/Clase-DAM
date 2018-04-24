using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria
{
    class Cliente
    {
        private string nombre, direccion, dni, telefono;

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

        // Devuelve el Nombre
        public string Nombre
        {
            get { return nombre; }
        }

        // Devuelve el DNI
        public string Dni
        {
            get { return dni; }
        }
    }
}
