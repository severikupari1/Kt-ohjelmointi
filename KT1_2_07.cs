using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
KT1
Lue käyttäjältä merkkejä, kunnes käyttäjä syöttää enterin. Pienet kirjaimet a-z
tulostuu isona ja isot kirjaimet A-Z tulostuu pienenä. Muut merkit eivät tulostu
 
KT2
Lue do-while silmukassa käyttäjältä arvoja, kunnes käyttäjä syöttää -999. Tulosta
sen jälkeen pienin ja suurin arvo sekä lukujen keskiarvo. Lukua -999 ei oteta
näihin mukaan

KT3
Lue käyttäjältä merkkejä, kunnes käyttäjä painaa !-merkkiä. !-merkin painamisen
jälkeen tulosta kaikki merkit mitä käyttäjä syötti. Vinkki: string muuttujaan voi
plussata merkkejä

KT4
esittele vakio PII, jolle annat arvoksi 3.1415

Lue käyttäjältä ympyrän säde ja laske ympyrän piiri muuttujaan piiri

Tulosta ympyrän piiri kahden desimaalin tarkkuudella

    KT1
Lue käyttäjältä merkkejä, kunnes käyttäjä syöttää enterin. Pienet kirjaimet a-z
tulostuu isona ja isot kirjaimet A-Z tulostuu pienenä. Muut merkit eivät tulostu
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            char merkki;

            do
            {
                Console.WriteLine("Annappas merkkejä!");
                merkki = Console.ReadKey(true).KeyChar;
                if (merkki >= 'a' && merkki <= 'z')
                {
                    Console.WriteLine("{0}", char.ToUpper(merkki));
                }
                else if (merkki >= 'A' || merkki <= 'Z')
                {
                    Console.WriteLine("{0}", char.ToLower(merkki));
                }

            } while (merkki != 13);

            Console.WriteLine("Lopetus :D");

            



        }
    }
}

