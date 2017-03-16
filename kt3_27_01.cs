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
            double lampotila;
            Console.WriteLine("Anna lämpötila! ");
            lampotila = double.Parse(Console.ReadLine());

            if (lampotila > 39)
            {
                Console.WriteLine("Liian kuuma");
            }
            else if (lampotila >= 11 && lampotila <= 39)
            {
                Console.WriteLine("Lämmintä");
            }
            else if (lampotila >= 0 && lampotila <= 10)
            {
                Console.WriteLine("Haaleaa");
            }
            else if (lampotila >= -30 && lampotila <= -1)
            {
                Console.WriteLine("Pakkasta");
            }
            else Console.WriteLine("Liian Kylmää");
        }

    }
}

