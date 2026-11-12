using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21_ToonDatum_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 12/11/2026
            // Project: Toon Datum

            // Velden
            DateTime _datum = default(DateTime);
            DateTime _datum2 = DateTime.MinValue;
            DateTime _datum3 = DateTime.Now;
            bool _herhalen = true;

            // Programma
            while (_herhalen)
            {
                Console.Clear();
                Console.WriteLine($"De default DateTime: {_datum.ToString()}");
                Console.WriteLine($"het minimum DateTime: {_datum2.ToString()}");
                Console.WriteLine($"De huidige DateTime: {DateTime.Now}");
                Thread.Sleep(1000);
            }

        }
    }
}
