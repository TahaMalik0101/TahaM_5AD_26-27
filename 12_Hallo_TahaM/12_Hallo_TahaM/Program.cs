using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Hallo_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 16/10/2026
            // Project: Hallo

            // Velden
            Byte _keuze = 0;
            String _naam = null;

            // Programma

            // Intro
            Console.Write("Welkom op mijn programma, beste gebruiker.\nDruk op enter om te beginnen...");

            Console.ReadKey();
            Console.Clear();

            do
            {
                try
                {
                    // Stap 1: Keuzemenu
                    Console.WriteLine("Keuzemenu\n   1. Hallo Wereld\n   2. Naam ingeven\n   3. Afluisten");

               
                    // Stap 2: Keuze vragen plus opslaan
                    Console.Write("Uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Stap 3: Als Hallo Wereld
                    if (_keuze == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Hallo Wereld");
                        Console.Write("\nDruk op enter om terug naar het keuzemenu te keren...");

                        Console.ReadKey();
                        Console.Clear();

                    }
                    // Stap 4: Als naam
                    else if  (_keuze == 2)
                    {
                        Console.Clear();
                        Console.Write("Geef uw naam in: ");
                        _naam = Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine($"Hallo {_naam}");
                        Console.WriteLine();
                        Console.Write("Druk op enter om terug naar het keuzemenu te keren...");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (_keuze == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Tot ziens!");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("U een getal in dat niet in ons keuzemenu staat.\n");
                        Console.Write("Druk op enter om terug te keren naar het keuzemenu...");
                    }

                }
                catch 
                {
                    Console.Clear();
                    Console.Write("U gaf geen geldig getal in, druk op enter om nog eens te proberen...");

                    Console.ReadKey();
                    Console.Clear();
                }
            } while (_keuze != 3);

        }
    }
}
