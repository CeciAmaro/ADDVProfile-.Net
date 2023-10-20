using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtaqueManticora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Defensor defensor1 = new Defensor("Defensor 1");
            Defensor defensor2 = new Defensor("Defensor 2");

            Arma cañón = new Arma("Gran cañón", 80, 50);
            Arma escopeta = new Arma("Metralla", 60, 40);
            Arma mosquete = new Arma("Mosquete", 50, 30);
            Arma pistola = new Arma("Pistola", 30, 20);
            Arma Granada  = new Arma("Granada", 10, 10);

            defensor1.ComprarArma(cañón);
            defensor1.ComprarArma(mosquete);
            defensor2.ComprarArma(escopeta);
            defensor2.ComprarArma(pistola);
            

            Manticora manticora = new Manticora();

            while (defensor1.DisparosIzquierda > 0 || defensor2.DisparosIzquierda > 0)
            {
                defensor1.Disparar(manticora);
                defensor2.Disparar(manticora);

                Console.WriteLine($"Manticora Posicion: {manticora.Posicion}, Manticora Estado: {manticora.Estado}");
                Console.WriteLine($"{defensor1.Nombre} disparos a la izquierda: {defensor1.DisparosIzquierda}, {defensor2.Nombre} disparos a la izquierda: {defensor2.DisparosIzquierda}");
                Console.WriteLine();
                if (manticora.Estado <= 0)
                {
                    Console.WriteLine("Manticora derrotada!");
                    break;
                }
                else if (defensor1.DisparosIzquierda == 0 && defensor2.DisparosIzquierda == 0)
                {
                    Console.WriteLine("Ciudad destruida por la Mantícora!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
