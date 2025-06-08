using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7._3
{
    internal class Program
    {
        /*
        Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca 
        obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola. 
        */
        
        //funkcja oblicza pole koła dla zadanego argumentu
        static double PoleKola(double r)
        {
            return Math.PI * r * r;
        }

        //testujemy naszą funkcję
        static void Main(string[] args)
        {
            Console.WriteLine("Dla r=1,5 Pole={0}", PoleKola(1.5));
            Console.ReadKey(true); //pauza
        }
    }
}
