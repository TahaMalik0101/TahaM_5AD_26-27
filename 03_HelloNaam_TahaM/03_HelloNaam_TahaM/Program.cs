using System;

namespace _03_HelloNaam_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 22/09/2026
            // Project: Hallo, Naam

            // Velden
            String naamGebruiker = null;
            String _bewerking = null;
            // Programma

            // Stap 1: Tekst weergeven en naam vragen + opslaan
            Console.Write("Geef uw naam: ");
            naamGebruiker = Console.ReadLine();

            // Stap 2: De juiste tekst maken
            //_bewerking = String.Format("hallo {0}", _naamGebruiker);
            _bewerking = $"Hallo {naamGebruiker}";

            // Scherm wissen
            Console.Clear();

            // Stap 3: Toon de tekst in de juiste vorm
            Console.WriteLine(_bewerking);

        }
    }
}
