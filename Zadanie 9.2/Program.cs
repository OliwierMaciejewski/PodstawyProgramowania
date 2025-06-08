using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9._2
{
    //definicja struktury
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Uczen[] uczniowie; //deklaruję zmienną typu strukturalnego
            int ilu_uczniow, ile_ocen, i, j; //zmienne pomocnicze
                                             //wczytuję liczbę uczniów
            Console.Write("Podaj liczbę uczniów w klasie: ");
            ilu_uczniow = Convert.ToInt32(Console.ReadLine());
            //przydzielam pamięć dla tablicy struktur
            uczniowie = new Uczen[ilu_uczniow];
            //wczytuję dane uczniów od użytkownika
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("Podał imię ucznia {0}: ", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podał nazwisko ucznia {0}: ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                //wczytuję liczbę ocen ucznia
                Console.Write("Ile ocen ma {0} {1}: ",
                uczniowie[i].imie, uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                //przydzialam pamiec dla tablicy ocen
                uczniowie[i].oceny = new byte[ile_ocen];
                //wczytuje oceny ucznia
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.Write("Podaj ocene numer {0}: ", j + 1);
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine(); //wypisanie pustej linii
            }
            //wypisuje dane uczniów na ekranie
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("{0}. {1} {2}: ",
                i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);
                //wypisuje oceny ucznia
                foreach (byte o in uczniowie[i].oceny)
                    Console.Write("{0}, ", o);
                Console.WriteLine(""); //przejście do nowego wiersza
            }
            Console.ReadKey(true); //pauza
        }
    }
}
