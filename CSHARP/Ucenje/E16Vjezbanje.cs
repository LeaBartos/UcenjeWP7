using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E16Vjezbanje
    {

        public static void Izvedi()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Dobrodošli u vježbanje srijedom");
            Console.ResetColor();
            Izbornik();
            Console.WriteLine("Doviđenja!");
        }

        private static void Izbornik()
        {
            Console.WriteLine();
            Console.WriteLine("1. Za uneseni broj provjeri da li je parni ili ne?");
            Console.WriteLine("0. Izlaz iz aplikacije");
            OdabirOpcijeIzbornika();
        }

        private static void OdabirOpcijeIzbornika()
        {
            switch (E14Metode.UcitajBroj("Odaberi opciju izbornika"))
            {
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;
                case 0:
                    break;
            }
        }

        private static void ParnostBroja()
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("-- Program za uneseni broj ispisuje da li je paran ili ne. --");
            Console.WriteLine("-------------------------------------------------------------");
            int broj = E14Metode.UcitajBroj("Unesi cijeli broj za provjeru", 1, 100);
            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj {0} je paran",broj);
            }
            else
            {
                Console.WriteLine("Broj {0} je neparan", broj);
            }
            Console.WriteLine("-- Kraj programa provjere parnosti broja --");
        }
    }
}
