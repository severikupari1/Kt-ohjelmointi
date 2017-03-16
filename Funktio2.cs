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

        static double Kysydouble()
        {
            Console.WriteLine("Annappa liukuluku");
            return double.Parse(Console.ReadLine());
        }


  

        static void varinvaihto()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main()
        {
            double luku1,luku2;
            varinvaihto();

            luku1 = Kysydouble();
            luku2 = Kysydouble();

            Console.WriteLine("lukujen summa on {0}", luku1 + luku2);

        }
    }
}

