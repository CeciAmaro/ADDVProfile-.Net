using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtaqueManticora
{
    internal class Defensor
    {
        public string Nombre { get; set; }
        public int oro { get; set; }
        public List<Arma> Inventario { get; set; }
        public int DisparosIzquierda { get; set; }

        public Defensor(string nombre)
        {
            Nombre = nombre;
            oro = 100;
            Inventario = new List<Arma>();
            DisparosIzquierda = 5;
        }

        public void ComprarArma(Arma arma)
        {
            if (oro >= arma.Costo)
            {
                oro -= arma.Costo;
                Inventario.Add(arma);
                Console.WriteLine($"{Nombre} ha comprado {arma.Nombre}.");
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene suficiente oro para comprar {arma.Nombre}.");
            }
        }

        public void Disparar(Manticora manticora)
        {
            if (DisparosIzquierda > 0)
            {
                Arma seleccionarArma = Inventario.First(); 
                DisparosIzquierda--;

                int distancia = manticora.MoverManticora();
                int daño = seleccionarArma.CalcularDaño(distancia);

                if (daño > 0)
                {
                    manticora.RecibirDaño(daño);
                    Console.WriteLine($"{Nombre} dispara con {seleccionarArma.Nombre} en la posición {distancia}. Mantícora toma {daño} daño.");
                }
                else
                {
                    Console.WriteLine($"{Nombre} No puedo alcanzar la Mantícora con {seleccionarArma.Nombre} en la posición {distancia}.");
                }
            }
        }
    }
}
