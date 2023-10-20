using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtaqueManticora
{
    internal class Arma
    {
        public string Nombre { get; }
        public int Costo { get; }
        public int Rango { get; }

        public Arma(string nombre, int costo, int rango)
        {
            Nombre = nombre;
            Costo = costo;
            Rango = rango;
        }

        public int CalcularDaño(int distancia)
        {
            if (distancia < Rango)
            {
                return 2;
            }
            else if (distancia > Rango)
            {
                return 0;
            }
            return 5;
        }
    }
}
