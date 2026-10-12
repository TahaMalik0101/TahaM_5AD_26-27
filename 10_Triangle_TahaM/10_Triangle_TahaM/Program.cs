using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_Triangle_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 12/10/2026
            // Project: Triangle

            // Velden
            int _h1 = 0, _h2 = 0, _h3 = 0;
            int _som = 0;
            const byte _driehoek = 180;
            // Programma

            // Intro
            Console.WriteLine("Welkom op mijn programma, beste gebruiker.\n\nHier zal je 3 hoek grotes ingeven, mijn programma stuurt dan terug of de hoekgrotes\nopsommen tot een werkelijk driehoek. Let op, " +
                "een driehoek telt altijd 180°.");
            Console.Write("\nDruk op enter om te starten...");

            Console.ReadKey();
            Console.Clear();

            try
            {
                // Stap 1: Hoek 1
                Console.Write("Geef in hoe groot je de eerste hoek maakt: ");
                _h1 = int.Parse(Console.ReadLine());
                if (_h1 == _driehoek || _h1 <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Je gaf een foute eerste hoek in.\nEen hoek moet tussen 0-180 graden zijn om te kunnen kloppen... Druk op enter om af te sluiten\n");
                    return;
                }

                // Stap 2: Hoek 2
                Console.Write("Geef in hoe groot je hoek twee maakt: ");
                _h2 = int.Parse(Console.ReadLine());
                if (_h2 == _driehoek || _h2 <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Je gaf een foute tweede hoek in.\nEen hoek moet tussen 0-180 graden zijn om te kunnen kloppen... Druk op enter om af te sluiten\n");
                    return;
                }
                
                // Stap 3: Hoek 3
                Console.Write("Geef de laatste hoek in: ");
                _h3 = int.Parse(Console.ReadLine());
                if (_h3 == _driehoek || _h3 <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Je gaf een foute derde hoek in.\nEen hoek moet tussen 0-180 graden zijn om te kunnen kloppen... Druk op enter om af te sluiten\n");
                    return;
                }
                Console.Clear();

                // Stap 4: optellen
                _som = _h1 + _h2 + _h3;

                // Stap 5: antwoord weergeven
                if (_som == _driehoek)
                {
                    Console.WriteLine($"Proficiat! U gaf {_h1}, {_h2} en {_h3} in. Opgeteld vormt dat een driehoek van 180 graden.");
                    Console.Write("\nDruk op enter om af te sluiten...\n");
                }
                else if (_som < _driehoek)
                {
                    Console.WriteLine($"Een driehoek bedraagt altijd 180 graden! {_som} is de som van de drie hoeken, wat te weinig is.");
                    Console.Write("\nDruk op enter om af te sluiten...\n");
                }
                else if (_som > _driehoek)
                {
                    Console.WriteLine($"{_som} is groter dan 180, een driehoek is niet mogelijk.");
                    Console.Write("\nDruk op enter om af te sluiten...\n");
                }
               
            }
            catch 
            {
                Console.Clear();
                Console.Write("Er ging iets mis, je getallen moeten steeds positieve gehele getallen zijn zonder ° teken.\nDruk op een toets om af te sluiten...\n");
            }

                    
        }
    }
}
