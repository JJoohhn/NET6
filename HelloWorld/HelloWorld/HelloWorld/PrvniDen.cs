﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PrvniDen
    {

        //string x = "Lukas Kubicek";




        //string input = Console.ReadLine();


        //--------------------------

        //int a = 23;

        //double d = 444.5684;

        //a = (int)Math.Round(d);

        //Console.WriteLine(a);
        //--------------------------

        //Hello();
        //const int c_a = 155;
        //const int c_b = 255;

        //var a = 25698;
        //var b = 65478;

        //if (a > b)
        //    Console.WriteLine("cislo A: {0} je vetsi nez B: {1} ", a, b);
        //else if (a == c_a)
        //    return false;
        //else (a == c_b)
        //    false;

        //static bool IsGreater(int a, int b)
        //{
        //    var x = (a > b) ? a : b;

        //}
        //PorovnaniCisel(6549, 5000);



        //int a = 20;
        //int b = 30;

        //Console.WriteLine("a: {0}, b: {1}", a, b);

        //int c = a;
        //a = b;
        //b = c;

        //Console.WriteLine("a: {0}, b: {1}", a, b);


        //Hello();
        //Console.ReadLine();

        static void PorovnaniCisel(int a, int b)
        {
            if (a < b)
                Console.WriteLine("Vetsi cislo je B: {0}", b);
            else

                Console.WriteLine("Vetsi cislo je A: {0}", a);
        }
        static void Hello()
        {
            Console.Write("Zadej sve jmeno:");
            string jmeno = Console.ReadLine();
            Console.WriteLine();
            if (jmeno == "Bob")
                Console.WriteLine("Vítej zpět Bobe.");
            else if (jmeno == "Alice")
                Console.WriteLine("Vítej zpět Alice.");
            else
                Console.WriteLine("Hello {0}", jmeno);

        }
        static void PrevodTeploty()
        {
            Console.Write("Zadej stupně ve Fahrenheit:");
            double far = double.Parse(Console.ReadLine());
            double cel = far - 112;
            Console.WriteLine("Teplota v Celsia je: {0}", cel);

        }

        //Hello(name.ToLower()) -- Změna velikosti písma
        //Mat.Round (něco, počet desetinných míst)
    }
}