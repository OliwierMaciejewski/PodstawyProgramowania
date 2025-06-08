using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._4
{
    internal class Program
    {
        /*
        Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako 
        argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr. 
        */
        
        //funkcja oblicza ilość cyfr jej argumentu
        static int IleCyfr(int liczba)
        {
            if (liczba == 0) return 1;

            int i = 0; //ilość cyfr
            while (liczba != 0) //dopóki liczba jest różna od zera
            {
                liczba /= 10;
                i++;
            }
            return i;
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine("liczba 0 ma {0} cyfrę", IleCyfr(0));
            Console.WriteLine("liczba 1234 ma {0} cyfry", IleCyfr(1234));
            Console.ReadKey(true); //pauza
        }
    }
}
