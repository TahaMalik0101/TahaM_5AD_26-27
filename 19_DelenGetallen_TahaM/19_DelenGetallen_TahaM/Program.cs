using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_DelenGetallen_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 12/11/2026
            // Project: Delen

            // Velden
            int intDeler = 5, intDeeltal = 3;
            double doubleDeler = 5, doubleDeeltal = 3;
            decimal decimalDeler = 5M, decimalDeeltal = 3M;

            // Programma

            Console.WriteLine("Normale deling met / ; ");
            //Console.WriteLine($"Met int deler en deeltal {(intDeeltal/intDeler).ToString()}");
            double uitkomst = intDeeltal / intDeler;
            Console.WriteLine($"Met int deler en deeltal {uitkomst.ToString()}");

            Console.WriteLine($"Met int deler en double deeltal {(doubleDeeltal / intDeler).ToString()}");
            Console.WriteLine($"Met int deler en decimal deeltal {(decimalDeeltal / intDeler).ToString()}");

            Console.WriteLine();

            Console.WriteLine($"Met double deler en int deeltal {(intDeeltal / doubleDeler).ToString()}");
            Console.WriteLine($"Met double deler en double deeltal {(doubleDeeltal / doubleDeler).ToString()}");
            //Dit kan niet --> Console.WriteLine($"Met double deler en decimal deeltal {(doubleDeeltal / decimalDeler).ToString()}");

            Console.WriteLine();

            Console.WriteLine($"Met decimal deler en int deeltal {(intDeeltal / decimalDeler).ToString()}");
            // Dit kan niet --> Console.WriteLine($"Met 
            Console.WriteLine($"Met decimal deler en decinal deeltal {(decimalDeler / decimalDeeltal).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"Met getal als deler en int deeltal {(intDeeltal / 7).ToString()}");
            Console.WriteLine($"Met getal als deler en double deeltal {(doubleDeeltal / 7).ToString()}");

            Console.WriteLine();
            Console.WriteLine($"Met int als deler en getal deeltal {(3 / intDeler).ToString()}");
            Console.WriteLine($"Met double als deler en getal deeltal {(3 / doubleDeler).ToString()}");

        }
    }
}
