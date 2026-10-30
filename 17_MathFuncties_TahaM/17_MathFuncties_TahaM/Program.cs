using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            Console.Clear();

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
                        bool herhalen = true;
                        do
                        {
                            Console.Clear();

                            try
                            {
                                //Stap 5: Vraag 2 getallen + opslaan
                                Console.Write("Geef een willekeurige eerste getal: ");
                                int getal1 = int.Parse(Console.ReadLine());

                                Console.Write("Geef een willekeurige tweede getal: ");
                                int getal2 = int.Parse(Console.ReadLine());

                                Console.Clear();

                                //Stap 6: toon menu(kleinst, grootste )
                                Console.WriteLine("Keuzemenu");
                                Console.WriteLine("     1. Kleinste van de twee aanduiden");
                                Console.WriteLine("     2. Grootste van de twee aanduiden");
                                try
                                {

                                    Console.Write("Uw keuze: ");
                                    Byte keuzeKG = Byte.Parse(Console.ReadLine());
                                    Console.Clear();

                                    //Stap 7: geef het juiste antwoord 
                                    if (keuzeKG == 1)
                                    {
                                        //Console.Clear(); -> ipv telkens clear in if... voor if 1x lear
                                        Console.WriteLine($"De kleinste van de twee getallen ({getal1.ToString()}/{getal2.ToString()}) is: {Math.Min(getal1, getal2).ToString()}");
                                    }
                                    else if (keuzeKG == 2)
                                    {
                                        Console.WriteLine($"De grootste van de twee getallen ({getal1.ToString()}/{getal2.ToString()}) is: {Math.Max(getal1, getal2).ToString()}");
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.Write("Je gaf geen correcte invoer, druk op enter om opnieuw te proberen");
                                        //Console.ReadKey(); -> ipv telkens readkey in if... Buiten if 1x readkey
                                    }
                                    Console.ReadKey();

                                    // Herhalen stoppen
                                    herhalen = false;
                                }
                                catch
                                {
                                    Console.Clear();

                                    Console.WriteLine("U gaf geen correcte getal in.");
                                    Console.Write("Druk op enter om terug te keren naar het menu...");
                                    Console.ReadKey();
                                }
                            }
                            catch
                            {
                                Console.Clear();

                                Console.Write("U gaf geen getal in\nDruk op enter om terug te keren naar het menu...");
                                Console.ReadKey();
                            }

                        } while (herhalen);
                    }

                    //Als 2: teken en absolute waarde
                    else if (_keuze == 2)
                    {
                        bool herhalen = true;
                        do
                        {
                            Console.Clear();

                            try
                            {
                                //Stap 8: vraag getal + opslaan
                                Console.Write("Geef een willekeurige getal: ");
                                int getal = int.Parse(Console.ReadLine());
                                Console.Write("Druk op enter om naar het mneu te gaan...");

                                Console.ReadKey();
                                Console.Clear();

                                // Toon menu
                                Console.WriteLine("Keuzemenu");
                                Console.WriteLine("     1. Geef weer of het getal positief of negatief is");
                                Console.WriteLine("     2. Geef de absolute waarde");

                                byte keuzeA = Byte.Parse(Console.ReadLine());
                                Console.Clear();

                                //Stap 9: Toon positief of negatief
                                if (keuzeA == 1)
                                {
                                    // Kijk of het positief is 
                                    if (Math.Sign(getal) == 1)
                                    {
                                        Console.WriteLine("Uw getalis positief");
                                    }

                                    // Kijk of het getal negatief is 
                                    else if (Math.Sign(getal) == -1)
                                    {
                                        Console.WriteLine("Uw getal was negatief");
                                    }

                                    // Kijk of het getal 0 is
                                    else
                                    {
                                        Console.WriteLine("Uw getal was 0");
                                    }

                                    Console.ReadKey();

                                }

                                //Stap 10: Toon absolute waarde 
                                else if (keuzeA == 2)
                                {
                                    Console.WriteLine($"De absulute waarde van de getal ({getal}) is: {Math.Abs(getal).ToString()}");
                                }

                                // Foute invoer
                                else
                                {
                                    Console.Write("Je gaf geen correcte invoer, druk op enter om terug te keren naar het menu...");
                                }

                                Console.ReadKey();

                                // Lussen stoppen
                                herhalen = false;

                            }

                            catch
                            {
                                Console.Clear();

                                Console.Write("U gaf geen getal in\nDruk op enter om terug te keren naar het menu");
                                Console.ReadKey();
                            }

                        } while (herhalen);
                    }

                    //Als 3: Afronden
                    else if (_keuze == 3)
                    {
                        bool herhalen = true;
                        do
                        {
                            Console.Clear();

                            try
                            {
                                //Stap 11: Vraag een kommagetal van minstens 3 cijfers na de komma
                                Console.Write("Geef een willekeurige getal met minstens 3 cijfers na de komma: ");
                                double getal = double.Parse(Console.ReadLine().Replace(".", ","));
                                Console.Write("Druk op enter om naar het mneu te gaan...");

                                Console.ReadKey();
                                Console.Clear();

                                //Stap 12: Ga na of er 3 cijfers zijn na de komma
                                if (getal.ToString().IndexOf(".") != -1 && (getal.ToString().Length - getal.ToString().IndexOf(".") > 3))
                                {
                                    //Stap 13: Toon het getal afgerond tot 2 cijfers na de komma
                                    Console.WriteLine($"Het afgeronde getal tot op 2 cijfers na de kommma is: {Math.Round(getal, 2)}");

                                    //Stap 14 : toon het getal afgerond naar dichtstbijzijnde natuurlijk getal
                                    Console.WriteLine($"Het afgeronde getal is: {Math.Round(getal)}");

                                    //Stap 15: Toon het getal met het 2de cijfer na de komma afgerond naar boven 
                                    Console.WriteLine($"Het getal afgerond naar boven 2 cijfers na de komma is: {Math.Ceiling(Math.Round(getal, 2))}");
                                }
                                else
                                {
                                    // Foutmelding
                                    Console.WriteLine("U gaf geen getal in met minstens 3 cijfers na de komma");
                                }

                                Console.Write("\nDruk op enter om terug te keren naar het menu...");
                                Console.ReadKey();

                                // Lussen stoppen
                                herhalen = false;
                            }
                            catch
                            {
                                Console.Clear();

                                Console.Write("U gaf geen getal in\nDruk op enter om terug te keren naar het menu");
                                Console.ReadKey();
                            }

                        } while (herhalen);
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
