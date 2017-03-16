using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Tee KysyArvo funtio, jossa luetaan käyttäjältä yksi kokonaisluku ja palautetaan se.
tee myös funtio LaskeSumma, joka ottaa parametrikseen kolme kokonaislukua ja 
palauttaa niiden summan. tee myös Tulsota-funktio joka ottaa parametrikseen
kyseiset kolme kokonaislukua ja summan tulostaa koko laskutomituksen

    Eli lue näiden funtioiden avulla käyttäjältä kolme koknaislukua, laske niiden
    summa ja tulosta koko laskuotoimitus vastauksineen

    1 + 2 +3 = 6
*/

namespace kotitehtavat
{
    class Program
    {

        static int KysyArvo()
        {
            Console.WriteLine("Annappa luku");
            return int.Parse(Console.ReadLine());
        }    

        static int LaskeSumma(int luku1, int luku2, int luku3)
        {

            return luku1 + luku2 + luku3;
        }

        static void Tulosta(int luku1, int luku2, int luku3, int summa)
        {
            Console.WriteLine("{0} + {1} + {2} = {3}", luku1, luku2, luku3, summa);
        }

        static void varinvaihto()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main()
        {
            varinvaihto();
            int luku1,luku2,luku3, summa;
            luku1 = KysyArvo();
            luku2 = KysyArvo();
            luku3 = KysyArvo();
            summa = LaskeSumma(luku1, luku2, luku3);
            Tulosta(luku1, luku2,luku3,summa);


        }
    }
}

