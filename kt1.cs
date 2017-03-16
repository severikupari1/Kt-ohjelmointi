using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*


KT2
Esittele 10 alkioinen int taulukko ja lue siihen käyttäjältä arvot (mainissa)

Tee TulostaArvo-funktio, joka ottaa parametrikseen yhden integer arvon ja
tulostaa sen näytölle. Tulosta tämän funktion avulla taulukon alkiot allekkain

KT3
Tee funktio TestaaMerkki(...), joka ottaa parametrina yhden merkin. 
Funktio palauttaa kokonaisluvun seuraavasti:
  0  Merkki on numero 0..9
  1  Merkki on kirjain a..z tai A..Z
  2  Merkki ei ole numero eikä kirjain. 
Tulosta paluuarvoa käyttäen seuraava ilmoitus. 
Jos paluuarvo 0, niin tulosta ”Numero”
Jos paluuarvo 1, tulosta ”Kirjain”
Jos paluuarvo 2, tulosta ”Ei numero eikä kirjain”
Käytä main()-funktiossa switch-case-rakennetta.

    KT1
Tee funktio KysyNimi, jossa kysytään käyttäjältä nimi ja palautetaan se.
Tulosta nimi TulostaNimi-funktiossa
*/


namespace ConsoleApplication2
{
    class Program
    {
        static string KysyNimi()
        {
            string nimi;
            Console.WriteLine("Annappa Nimesi");
            nimi = Console.ReadLine();
            return nimi;
        }

        static void TulostaNimi(string nimi)
        {           
           Console.WriteLine(nimi);         
        }

        static void Main(string[] args)
        {
            string nimi;
            nimi = KysyNimi();
            TulostaNimi(nimi);
        }
    }
}
