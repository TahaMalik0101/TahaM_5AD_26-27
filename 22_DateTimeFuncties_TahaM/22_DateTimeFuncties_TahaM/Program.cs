using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_DateTimeFuncties_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 12/11/2026
            // Project: DateTime Functies

            // Velden
            DateTime _datum = DateTime.MinValue;

            // Programma

            // Stap 1: Neem de datum van vandaag + toon op het scherm
            _datum = DateTime.Now;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            // Enkel de datum en niet de tijd
            _datum = DateTime.Today;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            // Stackable
            _datum = DateTime.Now.Date;
            Console.WriteLine($"De datum en tijd van vandaag: {_datum.ToString()}\n");

            // Jaar van de huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($"Het jaar van vandaag: {_datum.Year.ToString()}\n");

            // Dag van huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($"De dag van vandaag: {_datum.Day.ToString()}\n");

            // Uur van huidige datum
            _datum = DateTime.Now;
            Console.WriteLine($"Het uur van vandaag: {_datum.Hour.ToString()}\n");
        }
    }
}
