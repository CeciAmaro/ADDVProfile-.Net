using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtaqueManticora
{
    internal class Manticora
    {
        private static Random random = new Random();
        public int Posicion { get; private set; }
        public int Estado { get; private set; }

        public Manticora()
        {
            Posicion = 0;
            Estado = 10;
        }

        public int MoverManticora()
        {
            int nuevaPosicion;
            do
            {
                nuevaPosicion = random.Next(1, 6) * 10; 
            } while (nuevaPosicion == Posicion);

            Posicion = nuevaPosicion;
            return Posicion;
        }

        public void RecibirDaño(int daño)
        {
            Estado -= daño;
        }
    }
}
