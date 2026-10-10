using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _08_Geen100_TahaM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Taha Malik
            // 08/10/2026
            // Project: Geen 100

            // Velden
            const int _honderd = 100;
            int _getal = 0;

            // Programma

            // Intro:
            Console.WriteLine("Welkom beste gebruiker.\nIn dit programma zal je een getal invullen, die ik vervolgens evalueer.");
            Console.WriteLine();
            Console.WriteLine("Druk op enter om door te gaan");

            Console.ReadKey();
            Console.Clear();
            
            // Stap 1: Vraag gebruiker om positief getal in te vullen behalve 100
            Console.Write("Geef een positief getal in, dat niet 100 is: ");
            _getal = int.Parse(Console.ReadLine()); 

            // Stap 2: Check of dit klopt

            //    Stap 3: Het getal was groter dan 100
            if (_getal < _honderd)
            {
                Console.WriteLine("Uw getal is onder de 100");
            }
            //    Stap 4: het getal is kleiner dan 100
            else if (_getal > _honderd)
            {

            }
            //    Stap 5: het getal was 100(fout)
            
            // Stap 6: Antwoord weergeven


        }
    }
}
