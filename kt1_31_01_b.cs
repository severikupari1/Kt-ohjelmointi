using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

/*
KT1
tulosta do-while-silmukassa luvut 
a) 1-8 allekkain yhden välein
b) 20-0 allekkain 4 välein eli 20, 16, 12, ...

*/

namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20, miinustaja = 4;

            do
            {
                Console.WriteLine("{0} ", i);
                i = i - miinustaja;

            }
            while (i >= 0);                       
        }

    }
}

