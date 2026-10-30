using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _17_MathFuncties_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 30/10/2026
            // Project: Math Functions 

            // Velden
            Byte _keuze = 0;

            // Programma

      
            //Stap 1: intro
            Console.Write("30/10/2026\n\nWelkom op mijn wiskunde programma\nDruk op enter om te starten...");
            Console.ReadKey();
            do
            {
                //Stap 2:  Toon menu(grootste of kleinste, teken en abs, afronden, macht, Vierkantswortel, Inhoud cilinder, afsluiten)
                Console.WriteLine("Keuzemenu");
                Console.WriteLine("     1. Minimum of maximum");
                Console.WriteLine("     2. Bepaal teken of absolute waarde");
                Console.WriteLine("     3. Getal afronden");
                Console.WriteLine("     4. Getal in machtsverheffing");
                Console.WriteLine("     5. Vierkantswortel van getal");
                Console.WriteLine("     6. Inhoud van cilinder bereken");
                Console.WriteLine("     7. Aflsuiten");

                try
                {
                    //Stap 3: Vraag keuze +opslaan
                    Console.Write("Uw keuze: ");
                    _keuze = Byte.Parse(Console.ReadLine());

                    // Stap 4
                    Console.Clear();

                    //Als 1: grootste of kleinste
                    if (_keuze == 1)
                    {
                        //Stap 5: Vraag 2 getallen + opslaan

                        //Stap 6: toon menu(kleinst, grootste )

                        //Stap 7: geef het juiste antwoord 

                    }

                    //Als 2: teken en absolute waarde
                    else if (_keuze == 2)
                    {
                        //Stap 8: vraag getal +opslaan

                        //Stap 9: Toon positief of negatief

                        //Stap 10: Toon absolute waarde 

                    }

                    //Als 3: Afronden
                    else if ( _keuze == 3)
                    {
                        //Stap 11: Vraag een kommagetal van minstens 3 cijfers na de komma

                        //Stap 12: Ga na of er 3 cijfers zijn na de komma

                        //Stap 13: Toon het getal afgerond na de komma

                        //Stap 14 : toon het getal afgerond naar dichtstbijzijnde natuurlijk getal

                        //Stap 15: Toon het getal met het 2de cijfer na de komma afgerond naar boven 

                    }

                    //Als 4: Macht
                    else if (_keuze == 4)
                    {
                        //Stap 16: Vraag een getal + opslaan

                        //Stap 17: Bereken de 2de, 3de en 4de macht

                        //Stap 18: Toon resultaat

                    }

                    //Als 5: Vierkantswortel
                    else if (_keuze == 5)
                    {
                        //Stap 19: Vraag een getal + opslaan

                        //Stap 20: Bereken de vierkantswortel + afronden

                        //Stap 21: Toon resultaat

                    }

                    //Als 6: Inhoud cilinder
                    else if (_keuze == 6)
                    {
                        //Stap 22: Vraag straal van het bodemvlak + opslaan

                        //Stap 23: Vraag hoogte van de cilinder + opslaan

                        //Stap 24: maak de berekening voor inhoud en omtrek, rond af tot 2 cijfers na de komma +toon resultaat 

                    }

                    //Als 7 : Aflsuiten
                    else if (_keuze == 7)
                    {
                        //Stap 25: Toon afsluittekst 
                        Console.WriteLine("Tot een volgende keer, druk op enter om te sluiten...");
                    }

                    else
                    {

                    }

                }

                //Stap 26: Als keuze niet 7 is: ga terug naar stap 2
                catch
                {
                    Console.Clear();
                    Console.Write("U gaf geen correct invoer, druk op enter o mterug te keren naar het keuzemenu");
                    Console.ReadKey();
                }

            } while (_keuze != 7);
        }
    }
}
