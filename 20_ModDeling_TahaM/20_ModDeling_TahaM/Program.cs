using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ModDeling_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 12/11/2026
            // Project: ModDeling

            // Velden
            const double _deler = 7;
            const double _deeltal = 29;

            // Programma
            Console.WriteLine($"De deling: {(_deeltal / _deler).ToString()}");
            Console.WriteLine($"De modulaire deling: {(_deeltal % _deler).ToString()}");
            Console.WriteLine($"7 gaat {(Convert.ToInt32(_deeltal / _deler)).ToString()}");
            Console.WriteLine($"De rest is dan: {(_deeltal % _deler).ToString()}");
        }
    }
}
