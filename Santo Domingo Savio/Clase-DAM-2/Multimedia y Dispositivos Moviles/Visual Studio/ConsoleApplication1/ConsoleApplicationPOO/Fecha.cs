using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationPOO
{
    class Fecha
    {
        // Atributos
        private int dia, mes, anho;

        // Constructores
        public Fecha()
        {
            dia = 1;
            mes = 1;
            anho = 1970;
        }

        public Fecha(int dia, int mes, int anho)
        {
            this.dia = dia;
            this.mes = mes;
            this.anho = anho;
        }

        // Seters
        public void setDia(int dia)
        {
            this.dia = dia;
        }

        public void setMes(int mes)
        {
            this.mes = mes;
        }

        public void setAnho(int anho)
        {
            this.anho = anho;
        }

        // Geters
        public int getDia()
        {
            return dia;
        }

        public int getMes()
        {
            return mes;
        }

        public int getAnho()
        {
            return anho;
        }

        // Metodos
        public bool Bisiesto()
        {
            return (anho % 4 == 0);
        }

        public string EscribirFecha()
        {
            return "Dia: " + dia + " Mes: " + mes + " Año: " + anho;
        }

        public void AMes()
        {
            if (mes < 12)
                mes++;
            else
            {
                mes = 1;
                mes++;
            }
        }

        public int DiasAnho()
        {
            return 0;
        }
    }
}
