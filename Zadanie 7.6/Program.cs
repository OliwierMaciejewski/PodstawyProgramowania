using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._6
{
    internal class Program
    {
        /*
        Napisać procedurę (czyli funkcję, która nie zwraca żadnej wartości)  posiadającą trzy 
        parametry: a-długość boku kwadratu, znak1-znak będący konturem kwadratu, znak2-znak 
        będący wypełnieniem kwadratu. Procedura ma rysować na ekranie kwadrat o zadanych 
        argumentach. Przetestuj działanie utworzonej procedury.
        */
        static void RysujKwadrat(int a, char znak1, char znak2)
        {
            if (a < 1) return;

            // Pierwsza linia
            for (int i = 0; i < a; i++)
                Console.Write(znak1);
            Console.WriteLine();

            // Środek kwadratu
            for (int i = 1; i < a - 1; i++)
            {
                Console.Write(znak1);
                for (int j = 1; j < a - 1; j++)
                    Console.Write(znak2);
                if (a > 1) Console.Write(znak1);
                Console.WriteLine();
            }

            // Ostatnia linia (dla a > 1)
            if (a > 1)
            {
                for (int i = 0; i < a; i++)
                    Console.Write(znak1);
            }
        }

        static void Main(string[] args)
        {
            RysujKwadrat(6, '#', '*');
            Console.ReadKey(true);
        }
    }
}
