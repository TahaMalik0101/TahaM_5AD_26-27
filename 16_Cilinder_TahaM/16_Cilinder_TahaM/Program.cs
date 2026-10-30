using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Cilinder_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 29/10/2026
            // Project: Cilinder

            // Velden
            Byte _keuze = 0;
            int _straal = 0, _hoogte = 0;

            // Programma


            // Intro
            Console.Write("Welkom op mijn cilinder berekenende programma, druk op enter om door te gaan...");

            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.Clear();

                // Stap 1: Keuze menu
                Console.WriteLine("Keuzemenu:");
                Console.WriteLine("\n   1. Omtrek van cilinder berekenen");
                Console.WriteLine("\n   2. Aflsuiten");

                _keuze = byte.Parse(Console.ReadLine());
                Console.Clear();

                // Als omtrek berekenen
                if (_keuze == 1)
                {
                    // Stap 1: Vraag de straal van het grondvlak van een cilinder
                    Console.Write("Geef in hoeveel de straal van deze cilinder bedraagt: ");
                    _straal = int.Parse(Console.ReadLine());

                    // Stap 2: Vraag de hoogte van de cilinder 
                    Console.Write("Geef in hoeveel de hoogte van deze cilinder bedraagt: ");
                    _hoogte = int.Parse(Console.ReadLine());

                    Console.Write("Druk op enter om de inhoud van deze cilinder berekend te zien");
                    Console.ReadKey();
                    Console.Clear();

                    


                }

                // Als afsluiten

                // Sluit af 

            } while (_keuze != 2);
        }
    }
}
