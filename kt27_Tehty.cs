using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
/*
KT1
Kysy käyttäjältä onko ohjelmointi kivaa (k/e)

    Tulosta vastauksen perusteella että hyvä homma (jos vastaus oli k tai K)
    tai aika paha (jos vastaus oli e tai E) ja tulosta ERROR jos vastaus oli jotain 
    muuta
Lue käyttäjän vastaus char tyyppiseen muuttujaan


*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            char nappain;
            Console.WriteLine("Onko ohjelmointi kivaa? k/e ");
            nappain = Console.ReadKey().KeyChar;

            if (nappain == 'k' || nappain == 'K')
            {
                Console.WriteLine("\nhyvä homma");
            }
            else if (nappain == 'e' || nappain == 'E')
            {
                Console.WriteLine("\nAika paha");              
            }
            else 
            {
                Console.WriteLine("\nError!!!");
            }
                
            

       
        }
    }
}
