using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2._2
{
    internal class Program
    {
        /*
        Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest 
        dodatnia, ujemna, czy też równa zero.
        */
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbę całkowitą: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
                Console.WriteLine("liczba {0} jest dodatnia.", a);
            else if (a < 0)
                Console.WriteLine("liczba {0} jest ujemna.", a);
            else
                Console.WriteLine("liczba {0} jest równa zero.", a);
            Console.ReadKey(true); //pauza
        }
    }
}
