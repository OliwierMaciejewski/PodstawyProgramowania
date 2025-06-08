using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8._2
{
    internal class Program
    {
        /*
        Napisz funkcję, która wyznacza n-ty wyraz ciągu Fibonacciego zadany przez argument 
        wywołania funkcji wartości liczby naturalnej. Utwórz wersję rekurencyjną tej funkcji. 
        Napisz program testowy wykorzystujący napisaną funkcję.
        */
       
        //definicja funkcji rekurencyjnej
        static long Fib(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        //przykładowe użycie funkcji rekurencyjnej
        static void Main(string[] args)
        {
            Console.Write("Podaj n: ");
            long n = Convert.ToInt64(Console.ReadLine());

            if (n < 0)
                Console.WriteLine("Błędny parametr!");
            else
                Console.WriteLine($"Fib({n}) = {Fib(n)}");

            Console.ReadKey(true);
        }
    }
}
