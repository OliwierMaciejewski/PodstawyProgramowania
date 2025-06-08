using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._1
{
    /*
    Zdefiniuj strukturę o nazwie Osoba posiadającą trzy pola: imie, nazwisko i rok_urodzenia. 
    Zadeklaruj zmienną typu strukturalnego o nazwie o, wczytaj do niej wszystkie wartości pól od 
    użytkownika i wypisz wszystkie pobrane wartości pól na ekranie. 
    */

    struct Osoba
    {
        public string Imie;
        public string Nazwisko;
        public int RokUrodzenia;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Osoba o;

            Console.Write("Podaj imię: ");
            o.Imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            o.Nazwisko = Console.ReadLine();

            Console.Write("Podaj rok urodzenia: ");
            o.RokUrodzenia = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} urodził się w {2} roku.",
                o.Imie, o.Nazwisko, o.RokUrodzenia);

            Console.ReadKey(true);
        }
    }
}

