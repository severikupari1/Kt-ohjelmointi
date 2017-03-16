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

KT3
Lue käyttäjältä 7 kappaletta arvosanoja do-while-silmukassa. Tulosta lopuksi
kuinka monta hylättyä eli arvosanaa 0 annettiin

KT4
Lue käyttäjältä kaksi kokonaislukua ja operaatio (char)
joka lukujen välillä tehdään. Sen jälkeen tulosta koko
laskutoimitus vastauksineen. Mahdolliset operaatiot ovat +, -, *, /

KT5
Lue käyttäjältä arvoja kunnes käyttäjä syöttää -1. Tulosta sen jälkeen lukujen 
summa. -1 ei saa ottaa summan laskentaan mukaan. Käytä do-while-silmukkaa
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, lkm = 1, laskuri = 0;

            do
            {
                Console.WriteLine("Annappas {0}. arvosana", lkm);
                i = int.Parse(Console.ReadLine());
                lkm++;
                if (i == 0) laskuri++;
            }

            while (lkm < 8);
            Console.WriteLine("Hylättyjä on {0} kappaletta", laskuri);
        }

    }
}

