﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E01UlazIzlaz
    {



        public static void Izvedi ()
        {
            Console.WriteLine("Pozdrav svijetu!");

            Console.Write("Ovo je u liniji");
            Console.WriteLine("Ovo je u istoj liniji ali nakon ispisa ode u novu liniju");

            Console.WriteLine("1. red\n2. red \tnakon taba");

            Console.WriteLine(1);
            Console.WriteLine(true);
            Console.WriteLine(4.6);


            int i;
            Console.Write("Unesi cijeli broj: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine(" Unio si {0}",i );




            Console.Write( "Unesi ime grada: ");

            string grad = Console.ReadLine();
             
            Console.WriteLine("Unio si" + grad);












        }

    




    }
}
