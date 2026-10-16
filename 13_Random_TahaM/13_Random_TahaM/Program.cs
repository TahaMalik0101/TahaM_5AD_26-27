using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Random_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 16/10/2026
            // Project: Random

            // Velden
            Byte _keuze = 0;
            Random _rdm1 = new Random();
            Random _rdm2 = new Random();
            int _getal1 = -1;
            int _getal2 = -1;

            // Programma

            do
            {
                Console.Clear();

                Console.WriteLine("Maak uw keuze uit onderstaand menu:\n");
                Console.WriteLine("   1. Maak 2 randoms zonder voorwaarde");
                Console.WriteLine("   2. Maak 2 randoms die verschillend zijn van elkaar");
                Console.WriteLine("   3. Maak 2 randoms met max-waarde");
                Console.WriteLine("   4. Maak 2 randoms met max- en min-waarde");
                Console.WriteLine("   5. Aflsuiten");

                try
                {
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = byte.Parse(Console.ReadLine());

                    if (_keuze == 1)
                    {
                        Console.Clear();
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm2.Next();

                        Console.WriteLine($"De twee geallen zijn {_getal1.ToString()} en {_getal2.ToString()}.");
                        Console.Write("\nDruk op enter om terug te keren naar het menu...");

                        Console.ReadKey();
                        Console.Clear();

                    }
                    else if (_keuze == 2)
                    {
                        Console.Clear();
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm1.Next();

                        Console.WriteLine($"De twee geallen zijn {_getal1.ToString()} en {_getal2.ToString()}.");
                        Console.Write("\nDruk op enter om terug te keren naar het menu...");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (_keuze == 3)
                    {
                        Console.Clear();
                        _getal1 = _rdm1.Next();
                        _getal2 = _rdm1.Next();

                        Console.WriteLine($"De twee geallen zijn {_getal1.ToString()} en {_getal2.ToString()}.");
                        Console.Write("\nDruk op enter om terug te keren naar het menu...");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (_keuze == 4)
                    {
                        Console.Clear();
                        _getal1 = _rdm1.Next(10,100);
                        _getal2 = _rdm1.Next(10,100);

                        Console.WriteLine($"De twee geallen zijn {_getal1.ToString()} en {_getal2.ToString()}.");
                        Console.Write("\nDruk op enter om terug te keren naar het menu...");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (_keuze == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Tot ziens!");
                        Console.Write("\nDruk op enter om af te sluiten...");

                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("U gaf geen correcte getal in\n\nDruk op enter om terug te keren naar het menu...");

                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                catch 
                {
                    Console.Clear();
                }

            } while (_keuze != 5);
        }
    }
}
