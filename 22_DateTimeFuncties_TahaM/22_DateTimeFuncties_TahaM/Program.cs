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

            // Dag van de week
            Console.WriteLine($"Dag van de week: {_datum.DayOfWeek.ToString()}\n");
            int uitkomst = Convert.ToInt32(_datum.DayOfWeek);
            Console.WriteLine($"{uitkomst.ToString()} \n");

            // Toevoegen/aftrekken van jaren, maanden, dagen, uren...
            _datum = _datum.AddYears(1).AddDays(4).AddHours(2);
            Console.WriteLine($"Het uur binnen een jaar, 4 dagen en 2 uur: {_datum.ToString()} \n");

            _datum = _datum.AddYears(-1).AddDays(-4).AddHours(-2);
            Console.WriteLine($"Het uur binnen een jaar, 4 dagen en 2 uur: {_datum.ToString()} \n");

            // De verschillende ToString mogelijkheden
            Console.WriteLine("Hier zijn de vercshillende ToString opties: ");
            Console.WriteLine($"De normale ToString: {_datum.ToString()} \n");
            Console.WriteLine($"De Long Date: {_datum.ToLongDateString()} \n");
            Console.WriteLine($"De Long Time: {_datum.ToLongTimeString()} \n");
            Console.WriteLine($"De Short Date: {_datum.ToShortDateString()} \n");
            Console.WriteLine($"De Short Time: {_datum.ToShortTimeString()} \n");

            // Rekenen met datums: 
            DateTime datum2 = DateTime.Now.AddYears(3);

            // Rechtstreeks rekenen met datums gaat niet!
            //_datum = datum2 - _datum;

            // Je moet een variabele gebriuken van het datatype TimeSpan
            TimeSpan verschil = datum2 - _datum;
            Console.WriteLine($"{verschil.ToString()} \n");
        }
    }
}
