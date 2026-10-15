using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Keuzemenu_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 13/10/2026
            // Project: Keuzemenu

            // Velden
            byte _keuze = 0;

            // Programma

            // Intro
            Console.Write("Welkom gebruiker. Je krijgt 3 keuzes waaruit jij moet kiezen.\nDruk op enter om te beginnen...\n");

            Console.ReadKey();
            Console.Clear();

            do
            {
                try
                {
                    // Stap 1: Toon 3 keuzes
                    Console.WriteLine("  1. Keuze 1\n  2. Keuze 2\n  3. Keuze 3\n");

                    // Stap 2: Vraag een keuze
                    Console.Write("Maak een keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());
                    Console.Clear();

                    // Stap 3: Weergeef de keuze
                    if (_keuze == 1)
                    {
                        Console.WriteLine("U koos keuze 1!");
                    }
                    else if (_keuze == 2)
                    {
                        Console.WriteLine("U koos keuze 2!");

                    }
                    else if (_keuze == 3)
                    {
                        Console.WriteLine("U koos keuze 3!");

                    }
                    else if (_keuze == 4)
                    {
                        Console.WriteLine("Tot ziens gebruiker!");
                    }
                    // Stap 4: Toon keuzemenu weer
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("U gaf geen getal in!");
                    Console.Write("Druk op enter om terug naar het keuzemenu te gaan...");
                    Console.ReadKey();
                } 

            } while (_keuze != 4);
        }
    }
}
