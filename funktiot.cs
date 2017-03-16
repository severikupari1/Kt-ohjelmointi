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
        static void omafunktio()
        {
            Console.WriteLine("Omafunktiossa");
        }

        static void Main()
        {
            omafunktio();
            Console.WriteLine("Mainissa");
            omafunktio();

        }
    }
}

