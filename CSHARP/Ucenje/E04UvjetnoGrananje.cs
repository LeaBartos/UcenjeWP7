using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E04UvjetnoGrananje
    {

        ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
    {
        internal class E04UvjetnoGrananjeIf
        {

            public static void Izvedi()
            {
               

                int broj = 7; 

            

                bool uvjet = broj == 7;

                
                if (uvjet)
                {
                    Console.WriteLine("Broj ima vrijednost 7");
                }


                
                if (broj == 7)
                {
                    Console.WriteLine("ponovo je jednako 7");
                }

                
                if (broj == 7)
                    Console.WriteLine("I bez {} je jednako");
                


                if (broj == 7)
                {
                    Console.WriteLine("I opet je 7 ali uz inače");
                }
                else
                {
                    Console.WriteLine("Broj NIJE 7");
                }


                
                if (broj == 6)
                {
                    Console.WriteLine("Sad je 6");
                }
                else if (broj == 7)
                {
                    Console.WriteLine("Sad je 7");
                }
                else 
                {
                    Console.WriteLine("broj nije niti 6 niti 7");
                }


                

                

                

                broj = 1;
                int temp = 2;

                if (broj != 1 & temp < 0) 
                {
                    Console.WriteLine("Hladno je");
                }

                if (broj != 1 && temp < 0) 
                {
                    Console.WriteLine("Hladno je");
                }

                

                if (broj > 0 | temp > 0) 
                {
                    Console.WriteLine("Toplo je");
                }

                if (broj > 0 || temp > 0) 
                {
                    Console.WriteLine("Toplo je");
                }


                
                if (!(broj > 1 || temp > 0))
                {
                    Console.WriteLine("Ovo je kompliciran izraz");
                }

                

                if (broj > 0)
                {
                    if (temp == 0)
                    {
                        Console.WriteLine("Ugnježđeno");
                    }
                }


                

                if (broj > 0)
                {
                    int t = 8; 
                }

                


                string grad = "Osijek";

                if (grad == "Osijek")
                {
                    Console.WriteLine("Super");
                }
                else
                {
                    Console.WriteLine("Nije Super");
                }

                
                

                Console.WriteLine(grad == "Osijek" ? "Super" : "Nije Super");


            }



        }
    }







}
}
