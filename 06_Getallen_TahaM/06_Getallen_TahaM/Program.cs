using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Getallen_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 01/10/2026
            // Project: Getallen

            // Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _getal3 = 0;

            // Programma

            Console.WriteLine("Beste gebruiker, in dit programma zal jij mij 3 getallen aanbieden. Ik zal ze vervolgens achterstevoren terugsturen.");
            Console.WriteLine("Druk op enter om te beginnen...");

            Console.ReadKey();
            Console.Clear();

            //Stap 1: Vraag 3 getallen + opslaan
            Console.Write("Geef een eerste getal: ");
            _getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef een tweede getal: ");
            _getal2 = int.Parse(Console.ReadLine());

            Console.Write("Geef een derde getal: ");
            _getal3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Druk op enter om het resultaat te zien");
            Console.ReadKey();


            //Stap 2: Scherm wissen
            Console.Clear();

            //Stap 4: Toon de getallen
            Console.WriteLine($"Dit was het eerste getal: {_getal3}");
            Console.WriteLine($"Dit was het tweede getal: {_getal2}");
            Console.WriteLine($"Dit was het derde getal: {_getal1}");
        }
    }
}
