using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Afronden_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 13/10/2026
            // Project: Afronden

            // Velden
            float _floatvar = 0f;
            Double _doublevar = 0;
            Decimal _decimalvar = 0m;

            // Programma

            // Stap 1: Bereken 0.1 + 0.2 in de 3 typen variabel
            _floatvar = 0.1f + 0.2f;
            _doublevar = 0.1 + 0.2;
            _decimalvar = 0.1m + 0.2m;

            // Stap 2: Toon de resultaten
            Console.WriteLine($"float: {_floatvar.ToString()}");
            Console.WriteLine($"double: {_doublevar.ToString()}");
            Console.WriteLine($"decimal: {_decimalvar.ToString()}");

            Console.WriteLine("\nDruk op enter om verder te gaan");
            Console.ReadKey();

            // Stap 3: Ga na of float exact 0.3 weergeeft

            if (_floatvar == 0.3)
            {
                //  Als ja
                //      Stap 4: Toon “exact 0.3”
                Console.WriteLine("float: Exact 0.3");
            }
            else
            {
                //  Als nee
                //      Stap 5: Toon ”niet 0.3”
                Console.WriteLine("float: Niet 0.3");
            }

            // Stap 6: Ga na of double exact 0.3 weergeeft

            if (_decimalvar == 0.3M)
            {
                //  Als ja
                //      Stap 7: Toon “exact 0.3”  
                Console.WriteLine("Double: Exact 0.3");
            }
            else
            {
                // Als nee
                //      Stap 8: Toon ”niet 0.3”
                Console.WriteLine("Double: Niet 0.3");
            }

            // Stap 9: Ga na of decimal exact 0.3 weergeeft
            if (_decimalvar == 0.3m)
            {
                //  Als ja
                //      Stap 10: Toon “exact 0.3”
                Console.WriteLine("decimal: Exact 0.3");
            }
            else
            {
                //  Als nee
                //      Stap 11: Toon ”niet 0.3”
                Console.WriteLine("Decimal: Niet 0.3" );
            }

            Console.WriteLine("\nDruk op enter om verder te gaan.");
            Console.ReadKey();
        }
    }
}
