using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._2
{
    internal class Program
    {
        /*
        Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!"
        */
        static void Main(string[] args)
        {
            string imię;
            Console.WriteLine("Podaj swoje imię: ");
            imię = Console.ReadLine();
            Console.WriteLine("Witaj {0}!", imię);
            Console.ReadKey(true); //pauza
        }
    }
}
