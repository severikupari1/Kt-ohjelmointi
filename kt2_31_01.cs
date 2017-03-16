using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*


KT2
Lue käyttäjältä kokonnaisluku. Luvun on oltava väliltä -4...20. Jos ei
ollut niin tulosta virheilmoitus ja kysy luku uudestaan (toimittava myös
jos käyttäjä syöttää vieläkin luvun väärin).

Tulosta lopuksi luku ja luvun vastaluku näytölle

    -4 -3 -2 -1 0 1 2 3 4 5 6
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int laskuri;

            do
            {
                Console.WriteLine("Annappa kokonaisluku väliltä -4 - +20");
                laskuri = int.Parse(Console.ReadLine());
            }

            while (laskuri < -4 || laskuri > 20);

            Console.WriteLine("Annoit luvuksi {0}", laskuri);
            Console.WriteLine("Luvun vastaluku on {0}", -laskuri);

            

        }

    }
}

