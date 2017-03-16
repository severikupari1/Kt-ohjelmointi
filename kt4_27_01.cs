using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

KT3
Tee ohjelma, joka pyytää käyttäjää antamaan lampotila -nimiseen
muuttujaan jonkin mielivaltainen lämpötilan arvon (mieti minkätyyppinen muuttuja...).
Ohjelma tulostaa sitten seuraavasti,
kun lämpötila on:
> 39	Liian kuuma
11..39	Lämmintä
0..10	Haaleaa
-30..-1	Pakkasta
< -30	Liian kylmää
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 3;
            int lukulooppi = 0;

            while (luku < 19)
            {
                Console.WriteLine(luku);
                lukulooppi++;
                luku = luku + lukulooppi;
            }
        }

    }
}

