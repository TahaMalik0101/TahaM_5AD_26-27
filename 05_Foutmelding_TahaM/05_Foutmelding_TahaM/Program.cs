using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Foutmelding_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 01/10/2026
            // Project: Foutmelding 

            // Velden
            int _getal = 0;

            // Programma

            // Stap 1: vraag een natuurlijk getal
            try
            {
                Console.Write("Geef een natuurlijk getal: ");
                // Stap 2: Zet getal om naar juiste datatype
                _getal = int.Parse(Console.ReadLine());

                Console.Clear();

                // Stap 3: Foutmelding tonen OF bevestiging tonen
                Console.WriteLine($"U Fag volgende getal in: {_getal.ToString()}");
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Er ging iets fout. ");
            }



        }
    }
}
