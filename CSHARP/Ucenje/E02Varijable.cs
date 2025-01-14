using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E02Varijable
    {


        public static void Izvedi()
        {

            // Console.WriteLine("E02");


            int cijeliBroj = 1;
            bool logickaVrijednost = true;
            float decimalniBroj = 4.5f;
            double velikidecimalniBroj2 = 3.14;
            decimal decimalnibroj2 = 3.4m;
            char znak = '@';
            string nizZnakova = "abcdef";



            Console.WriteLine("Znak je broj {0}", (int)znak);

            cijeliBroj = int.MaxValue;
            Console.WriteLine(cijeliBroj);
            Console.WriteLine(cijeliBroj + 1);













        }



    }
}
