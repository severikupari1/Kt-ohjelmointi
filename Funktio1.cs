using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

*/

namespace kotitehtavat
{
    class Program
    {
       
        static int Palautaika()
        {       
            return 45;
        }


        static void TulostaEtunimi()
        {
            Console.WriteLine("Severi Kupari");
        }

        static void TulostaAsuinpaikka()
        {
            Console.WriteLine("Kuopio");
        }

        static void TulostaPuhelinnumero()
        {
            Console.WriteLine("040-5423317");
        }

        static void varinvaihto()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main()
        {
            int ika;
            varinvaihto();
            TulostaEtunimi();
            TulostaAsuinpaikka();
            TulostaPuhelinnumero();
            ika = Palautaika();
            Console.WriteLine("Ikasi on {0}", ika);
        }
    }
}

