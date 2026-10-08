using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Rekensom_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 08/10/2026
            // Project: Rekensom

            // Hoe de bewerkingen worden uitgevoerd (in de cw) is niet een correcte manier, al lukt het. Bewerkingen gebeuren vooraleer de tekst word weergegeven.

            // Velden
            int _getal1 = 0;
            int _getal2 = 0;
            int _opgeteld = 0;
            int _vermeerderd = 0;
            int _vermenigvuldigd = 0;
            int _gedeeld = 0;

            int _vermeerdering = 5;
            int _vermenigvuldiging = 10;
            int _deling = 2;

            // Programma

            //Stap 1: Vraag getal 1 + opslaan
            try
            { 
                    Console.Write("Geef een eerste getal: ");
                    _getal1 = int.Parse(Console.ReadLine());
                try
                {
                    //Stap 2: Vraag getal 2 + opslaan
                    Console.Write("Geef een tweede getal: ");
                    _getal2 = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                    Console.WriteLine("Druk op enter om de berekeningen van uw getallen te zien");

                    Console.ReadKey();
                    Console.Clear();

                    // Getallen optellen
                    _opgeteld = _getal1 + _getal2;

                    Console.WriteLine($"U gaf getal {_getal1} en {_getal2} in.");

                    //Stap 3: Toon ze opgetaeld 
                    Console.WriteLine($"De som hiervan is {_opgeteld}");

                    //Stap 3: Tel er 5 bij op
                    Console.WriteLine($"Hier 5 bij optellen, komt {_vermeerderd = _opgeteld + _vermeerdering} uit");

                    //Stap 4: Vermenigvuldig door 10
                    Console.WriteLine($"Door 10 vermenigvuldigen geeft als uitkomst {_vermenigvuldigd = _vermeerderd * _vermenigvuldiging} ");

                    //Stap 5: Deel door 2
                    Console.WriteLine($"Als laatst deel je het door 2, waarbij je {_gedeeld = _vermenigvuldigd / _deling}");
                }
                catch 
                {
                    Console.Clear();
                    Console.WriteLine("Uw tweede getal was fout");
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Uw eerste getal was fout");
            }

           

        }
    }
}
