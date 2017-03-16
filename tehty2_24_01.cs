using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
KT1
Lue käyttäjältä kolme double arvoa eri muuttujiin. Jos lukujen
summa oli suurempi kuin 100, niin tulosta luvut allekkain. Muussa
tapauksessa tulosta luvut samalle riville kahdella välilyönnillä eroteltuna

KT2
Lue käyttäjältä kaksi kokonaislukua. Jos luvut olivat
samat, niin tulosta "Samoja olivat", muuten tulosta "Luvut olivat eri lukuja"

KT3
lue käyttäjältä arvosana väliltä 0-5 (et osaa tarkistaa, mutta syötä tuolta 
väliltä)

Jos arvosana oli suurempi tai yhtäkuin 3, niin tulosta "Hyvä". Muussa
tapauksessa tulosta "Petrattavaa"
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2;
            Console.WriteLine("Annappa luku");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Annappa toinen luku");
            luku2 = int.Parse(Console.ReadLine());

            if (luku1 == luku2)
            {
                Console.WriteLine("Samoja olivat");
            }
            else
            {
                Console.WriteLine("Luvut olivat eri lukuja");
            }
        }
    }
}
