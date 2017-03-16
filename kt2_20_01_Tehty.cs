using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*


KT2
Kysy käyttäjältä mikä on hänen tilin saldo. Kysy lisäksi paljonko
on tässä kuussa tuloja ja paljonko on menoja ja
tulosta tieto paljonko tilin saldo on sen jälkeen kun tulot
lisätään ja menot vähennetään. 

*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int tilinsaldo, menot, tulot;
            Console.WriteLine("Mikä on tilinsaldosi ");
            tilinsaldo = int.Parse(Console.ReadLine());
            Console.WriteLine("Paljonko sinulla on tuloja ");
            tulot = int.Parse(Console.ReadLine());
            Console.WriteLine("paljonko sinulla on menoja ");
            menot = int.Parse(Console.ReadLine());

            Console.WriteLine("Tilinsaldosi {0}", tilinsaldo + tulot - menot);
            
                       
        }
    }
}

