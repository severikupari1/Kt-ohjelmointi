using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*



    * KT1
Kysy käyttäjältä minkä luvun (1-10) kymmenen kertotaulu tulostetaan. Tulosta
se for-silmukalla

1 * 3 = 3
2 * 3 = 6
...
10 * 3 = 30


for (alustus; ehto; kasvatus/vähennys)
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, kertoja;

            Console.WriteLine("Annappa luku 1-10 niin tapahtuu taikoja");
            kertoja = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {                
                Console.WriteLine("{0}", i * kertoja);
            }

        }
    }
}

