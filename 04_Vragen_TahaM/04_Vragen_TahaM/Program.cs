using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Vragen_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 29/09/2026
            // Project: Vragen

            // Velden
            string _kleur = null, _dag = null, _seizoen = null;

            // Programma
            Console.ForegroundColor = ConsoleColor.Magenta;

            // Stap 1: Vraag om een kleur te kiezen
            Console.Write("Tik je favoriete kleur in: ");

            // Stap 2: sla het op een in aangemaakte variabel
            _kleur = Console.ReadLine();

            // Stap 3: Weergeef hun keuze
            Console.WriteLine($"Je favoriete kleur is {_kleur}.");

            Console.WriteLine("\nDruk op enter om door te gaan");
            Console.ReadKey();
            Console.Clear();

            // Stap 4: Vraag naar een favoriete dag van de week
            Console.Write("Tik je favoriete dag van de week in: ");

            // Stap 5: Sla het op in een aangemaakte variabel
           _dag = Console.ReadLine();

            // Stap 6: Weergeef hun keuze
            Console.WriteLine($"Je favoriete dag van de week is {_dag}.");

            Console.WriteLine("\nDruk op enter om door te gaan");
            Console.ReadKey();
            Console.Clear();

            // Stap 7: Vraag hun favoriete seizoen
            Console.Write("Tik als laatsts je favoriete seizoen in: ");

            // Stap 8: Sla het op in een aangemaakte variabel
            _seizoen = Console.ReadLine();

            // Stap 9: Weergeef hun keuze
            Console.WriteLine($"Je favoriete seizoen van het jaar is {_seizoen}.");
            Console.WriteLine();
            Console.WriteLine("Druk nu nog eens op enter om ze op een rij te zien!");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"Je favorieten zijn {_kleur}, {_dag} en {_seizoen}.");
            Console.WriteLine("\nTot ziens, gebruiker!");
        }
    }
}
