﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._2
{
    internal class Program
    {
        /*
        Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych 
        zadanych jako argumenty tej funkcji. Napisz program wykorzystujący funkcję max.
        */
        
        //funkcja wyznacza maksimum z jej argumentów
        static double max(double x, double y)
        {
            if (x > y) return x;
            else return y;
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine("Max z 3 i 8 to {0}", max(3, 8));
            Console.WriteLine("Max z 8 i 3 to {0}", max(8, 3));
            Console.WriteLine("Max z 3 i 3 to {0}", max(3, 3));
            Console.ReadKey(true); //pauza
        }
    }
}
