using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _09_Kleur_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 10/10/2026
            // Project: Kleur

            // Velden
            int _getal = 0;

            // Programma

            // Intro
            Console.WriteLine("Welkom bij mijn programma. In mijn programma moet je een kleur kiezen en vertel ik je een funfact.");
            Console.WriteLine();
            Console.Write("Druk op enter om te starten...");

            Console.ReadKey();
            Console.Clear();

            try
            {
                // Stap 1: Maak een keuzemenu
                Console.WriteLine("Menu:");
                Console.WriteLine("\n1. Rood\n2. Geel\n3. Groen");
                Console.Write("\nVul een getal in: ");

                _getal = int.Parse(Console.ReadLine());
                Console.Clear();

                // Stap 2: Weergeef tekst
                if (_getal == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                    Console.WriteLine("Je koos rood!\n\nRood was ongeveer 9 jaar mijn favoriete kleur.\n" +
                    "Een vriend die ik super cool vond zei me dat zijn favoriete kleur rood was, sinds die dag was de mijne ook rood.");

                    Console.Write("\nDruk op enter om de sessie te verlaten...\n ");
                }
                else if (_getal == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    Console.WriteLine("Je koos geel!\n\nGeel is een kleur die ik graag combineer wanneer ik een outfit kies.\nZo heb ik fel gele schoenen," +
                    " dat zie je niet vaak waarschijnlijk.");
                    Console.Write("\nDruk op enter om de sessie te verlaten...\n");
                }
                else if (_getal == 3)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();

                    Console.WriteLine("Je koos groen!\n\nGroen is de kleur van de vlag van Pakistan. Ik heb roots en familie in Pakistan.\n" +
                    "Overlangs ben ik nog eens geweest en ik mis het nu al.\nVal niet voor al het slechte propaganda dat je zit over dit land!");
                    Console.Write("\nDruk op enter om de sessie te verlaten...\n");
                }
                else
                {
                    Console.WriteLine($"{_getal} staat niet staat in het keuzemenu.");
                    Console.Write("\nDruk op enter en geef bij de volgende sessie een correct getal in...\n");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("U gaf geen getal in.");
                Console.Write("\nDruk op enter en geef bij de volgende sessie effectief een getal in...\n");
            }
        }
    }
}
