using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
KT3
Lue käyttäjältä sotu, syntymävuosi ja tilin saldo. 
Ensin stringiin ja konvertoi ne sitten oikeantyyppisiin muuttujiin.
Tulosta tiedot:

Sotusi on 121288-123F
Tilisi saldo on 12,34 euroa ja olet syntynyt vuonna 1988
ja ikäsi on täten 28
*/
namespace kotitehtavat
{
    class Program
    {
        static void Main(string[] args)
        {
            string sotu, syntymavuosi, tilisaldo;

            Console.WriteLine("Annappa sotusi ");
            sotu = Console.ReadLine();
            Console.WriteLine("Annappa tilisi saldo");
            tilisaldo = Console.ReadLine();
            Console.WriteLine("Minä vuonna olet syntynyt");
            syntymavuosi = Console.ReadLine();

            double tilisaldo1;
            int syntymavuosi1;
            tilisaldo1 = double.Parse(tilisaldo);
            syntymavuosi1 = int.Parse(syntymavuosi);

            Console.WriteLine("Sotusi on {0} \nTilisi saldo on {1} euroa ja olet syntynyt vuonna {2} \nikäsi on täten {3}", sotu, tilisaldo1, syntymavuosi1, 2017 - syntymavuosi1);
        }
    }
}

