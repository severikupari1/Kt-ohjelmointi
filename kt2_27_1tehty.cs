using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
/*
KT1
Kysy käyttäjältä onko ohjelmointi kivaa (k/e)

    Tulosta vastauksen perusteella että hyvä homma (jos vastaus oli k tai K)
    tai aika paha (jos vastaus oli e tai E) ja tulosta ERROR jos vastaus oli jotain 
    muuta
Lue käyttäjän vastaus char tyyppiseen muuttujaan

    KT2
Muuten sama kuin yllä mutta lue käyttäjältä vastaus nimiseen string muuttujaan 
joko kyllä tai ei (tai KYLLÄ/EI)
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            string vastaus;
            Console.WriteLine("Onko ohjelmointi kivaa");
            vastaus = Console.ReadLine();
            
            if (vastaus == "kyllä" || vastaus == "KYLLÄ")
            {
                Console.WriteLine("Hyvä homma! ");
            }                         
            else if (vastaus == "ei" || vastaus == "EI")
            {
                Console.WriteLine("Aika paha! ");
            }
            else
            {
                Console.WriteLine("Error!! ");
            }
        }
    }
}
