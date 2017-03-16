using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
KT1
esittele kaksi int muuttujaa ja lue niihin käyttäjältä arvot.
 * 
Tulosta lopuksi lukujen summa ja erotus laskutoimituksineen eli jos käyttäjä syötti 
10 ja 12 niin tulostuu
 
10 + 12 = 22
10 - 12 = -2
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int luku1, luku2;

            Console.Write("annappa luku ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("annappa toinen luku ");
            luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", luku1, luku2, luku1 + luku2);
            Console.WriteLine("{0} - {1} = {2}", luku1, luku2, luku1 - luku2);
        }
    }
}
