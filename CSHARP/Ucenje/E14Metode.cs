using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Metode
    {

        // metoda je organizacijska jedinica koda koja služi određenoj svrsi
        // Cilj rada s metodama: Write once, use everywhere
        // static - označava da se metoda može pozvati na klasi
        public static void Izvedi()
        {
            Console.WriteLine("E14");
            // Metode se sastoje od dva djela:
            // 1. Tijelo metode
            // 2. Poziv metode

            // iz statične metode na klasi može samo pozvati drugu statičnu metodu, posljedično sve nađe metoda danas će biti statične

            //poziv metode
        }

        // prvo se piše tijelo metode
        /// <summary>
        /// Metoda tipa 1: Ne vraća vrijednost, ne prima vrijednost
        /// ne vraca vrijednost - void
        /// mora trenutno biti static
        /// ne pise public ili nesto drugo: radi se o nacinun pristupa;
        /// bez navodenja: vidljivo samo u ovoj klasi
        /// </summary>
        public static void Tip1()
        {
            Console.WriteLine("Ispis iz metode Tip1");

            // 2. ne vraca vrijednost, prima parametre
            // int i je parametar



            


           

        }



    }
}
