﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._5
{
    internal class Program
    {
        /*
        Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja 
        powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb. Przetestuj działanie 
        utworzonej funkcji. 
        */
        static int CzyPierwsza(int liczba)
        {
            if (liczba < 2) return 0;
            for (int i = 2; i <= Math.Sqrt(liczba); i++)
                if (liczba % i == 0) return 0;
            return 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Czy 12 jest pierwsza: {0}", CzyPierwsza(12));
            Console.WriteLine("Czy 13 jest pierwsza: {0}", CzyPierwsza(13));
            Console.ReadKey(true);
        }
    }
}
