using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Raadspel_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 13/11/2026
            // Project: Raadspel

            // Velden
            Byte _keuze = 0;

            // Programma


            // Intro
            Console.WriteLine("Welkom op mijn raadsel beste gebruiker, er zal een willekeurig getal zijn die jij moet gokken!");
            Console.Write("Druk op enter om te beginnen...");

            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.Clear();

                // Stap 1: Toon het menu
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("     1. Speel het spel");
                Console.WriteLine("     2. Aflsuiten");
                
                // Stap 2: Vraag keuze + opslaan
                _keuze = Byte.Parse(Console.ReadLine());

                Console.Clear();

                try
                {
                    // Stap 3: Als 1
                    if (_keuze == 1)
                    {
                        // Stap 4: Maak een willekeurig getal
                        Random rdm = new Random();
                        Byte geheimgetal = Convert.ToByte(rdm.Next(1, 101));
                        bool gevonden = false;

                        // Geef de gebruiker 5 kansen
                        for (int i = 5; i > 0 ; i--)
                        {
                            // Stap 5: Vraag de gokpoging van de gebruiker

                            // Stap 6: Kijk of de gok juist is

                            // Als kleiner

                            // Als groter 

                            // Als kansen 

                            // Als kansen op zijn	
                        }

                    }

                    // Stap 7: Als 2
                    else if (_keuze == 2)
                    {
                        // Stap 8: toon afluittekst

                        // Stap 9: Als geen keuze 2, terugkeren naarhoofdmenu 
                    }
                    else
                    {
                        Console.WriteLine("Tot de volgende keer");
                        Console.Write("U gaf geen correcte getal in, druk op enter om af te sluiten...");
                        Console.ReadKey();
                    }
                }
                catch 
                {
                    Console.Clear();
                    Console.WriteLine("U gaf geen getal in.");
                    Console.Write("Druk op enter om terug te gaan naar het hoofdmenu");

                    Console.ReadKey();
                    Console.Clear();
                }

            } while (_keuze != 2);

        }
    }
}
