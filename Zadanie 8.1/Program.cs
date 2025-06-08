using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8._1
{
    internal class Program
    {
        /*
        Napisz funkcję , która oblicza wartość silni z zadanej przez argument wywołania funkcji 
        wartości liczby naturalnej. Utwórz wersję rekurencyjną tej funkcji. 
        Napisz program testowy wykorzystujący napisaną funkcję.
        */
        
        // Definicja funkcji rekurencyjnej
        static long Silnia(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Silnia(n - 1);
        }

        // Przykładowe użycie funkcji rekurencyjnej
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n=");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
                Console.WriteLine("Błędny argument!");
            else
                Console.WriteLine("{0}! = {1}", n, Silnia(n));

            Console.ReadKey(true); //pauza
        }
    }
}
