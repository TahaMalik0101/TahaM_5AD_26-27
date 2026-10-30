using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_MeerDobbel_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 20/10/2026
            // Project: Meer Dobbelsteen

            // Velden
            //int _DobbelStart = 0;
            //Byte _keuze = 0;
            // Programma

            //do
            //{
            //    // Stap 1: Intro 
            //    Console.WriteLine("Welom op mijn programma. Hier geef je een aantal ogen in en dobbel je ermee.\nMet meerdere dobbelstenen worden de worpen opgeteld");
            //    Console.Write("\nGeef een aantal ogen in voor je eerste dobbelsteen om te beginnen: ");
            //    _DobbelStart = int.Parse(Console.ReadLine());

            //    if (_DobbelStart == 0)
            //    {
            //        Console.WriteLine("Keuzemenu: ");
            //        Console.WriteLine("   1. Ogen ingeven");
            //        Console.WriteLine("   2. Werpen");
            //        Console.WriteLine("   3. Aflsuiten");
            //        Console.Write("uw keuze: ");

            //        _keuze = Byte.Parse(Console.ReadLine());
            //        Console.Clear();
            //    }

            //    // Stap 2: Keuzemenu
            //    else
            //    {
            //        Console.WriteLine("Keuzemenu: ");
            //        Console.WriteLine("   1. Werpen");
            //        Console.WriteLine("   2. Aflsuiten");
            //        Console.Write("uw keuze: ");

            //        _keuze = Byte.Parse(Console.ReadLine());
            //        Console.Clear();
            //    }

            //    // Stap 3: Als keuze 1 (Dobbelsteen)

            //    // Stap 4: Vraag aantal ogen + opslaan

            //    // Stap 5: Werp dobbelsteen 

            //    // Stap 6: Bij meerdere dobbelstenen opslaan.

            //    // Stap 6: Als keuze 2 (Werpen)

            //    // Stap 7: Werp dobbelsteen

            //    // Stap 8: Optellen

            //    // Stap 9: Als keuze 3 (Afsluiten) 

            //} while (_keuze != 3);

            // Velden
            Byte _aantalOgen = 0;
            Byte _keuze = 0;
            Random _rdm = new Random();
            int _totaal = 0;

            //Programma
            do
            {
                // Scherm wissen
                Console.Clear();

                Console.WriteLine("Maak uw keuze uit onderstaand menu: ");

                //    Stap 1a: Toon eerste deel keuzemenu (ogen)
                Console.WriteLine("    1) Geef het aantal ogen van de dobbelsteen in.");

                //    Stap 2: Kijk of het aantal ogen is ingegeven
                //Als ja: 
                if (_aantalOgen != 0)
                {
                    // Stap 3: Toon rest van het keuzemenu(werpen, resetten)
                    Console.WriteLine("    2) Werp de dobbelsteen \n    3) Reset het totaal");
                }

                // Stap 1b: Toon eerste deel keuzemenu (afsluiten)
                Console.WriteLine("    4) Aflsuiten");
                try
                {
                    //    Stap 4: Vraag keuze +opslaan
                    Console.Write("\nGeef uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    //Als 1:
                    if (_keuze == 1)
                    {
                        // Stap 5: Vraag hoeveel ogen de dobbelsteen heeft +opslaan
                        Console.Write("Geef het aantal ogen dat u voor de dobbelsteen wilt:");
                        _aantalOgen = Byte.Parse(Console.ReadLine());
                        _aantalOgen ++;
                        // _aantalOgen += 1;
                    }
                    //Als 2: 
                    else if (_keuze == 2)
                    {

                        // Stap 6: Toon de worp van de dobbelsteen +opslaan
                        Byte worp = Convert.ToByte(_rdm.Next(1, _aantalOgen));
                        Console.WriteLine($"Uw worp is: {worp.ToString()}");

                        //    Stap 7: Toon het totaal van alle worpen tezamen 
                        _totaal += worp;
                        Console.WriteLine($"\nIn het totaal heeft u {_totaal.ToString()} gegooid.");

                        Console.Write("\nDruk op enter om verder te gaan of terug te keren naar het keuzemenu...");
                        Console.ReadKey();
                    }

                    //Als 3:
                    else if (_keuze == 3)
                    {
                        _totaal = 0;
                        // Stap 8: reset het resultaat
                        Console.WriteLine("\nUw totaal is gereset.");
                        Console.Write("\nDruk op enter om verder te gaan of terug te keren naar het keuzemenu...");
                        Console.ReadKey();
                    }
                

                    //Als 4:
                    else if (_keuze == 4)
                    {
                    // Stap 9: Toon de afsluittekst
                    Console.WriteLine("\nTot de volgende keer!");
                    Console.Write("Druk op enter om af te sluiten...");
                    Console.ReadKey();

                    }
                    // In elk ander geval
                     else
                    {
                        Console.Write("U gaf geen correcte invoer\n\nDruk op enter om terug te keren...");
                    }
                }
                catch
                {
                    // Scherm wissen
                    Console.Clear();

                    // Foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om naar het hoofdmenu te gaan.");
                    Console.ReadKey();
                }
                //    Stap 10: keer terug naar stap 1

            }
            while (_keuze != 4);

        }
    }
}
