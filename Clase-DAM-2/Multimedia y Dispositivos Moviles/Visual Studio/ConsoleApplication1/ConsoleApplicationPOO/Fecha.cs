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

        // Geters and Seters
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

        // Metodos
        public bool Bisiesto()
        {
            bool bisi = false;

            if (anho % 4 == 0)
                bisi = true;

            return bisi;
        }

        public void AMes()
        {
            mes++;
            mes %= 12;
        }

        public int DiasAnho()
        {
            return 0;
        }
    }
}
