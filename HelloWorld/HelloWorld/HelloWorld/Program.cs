using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            PorovnaniCisel(6549, 5000);
            

           
            //int a = 20;
            //int b = 30;

            //Console.WriteLine("a: {0}, b: {1}", a, b);

            //int c = a;
            //a = b;
            //b = c;

            //Console.WriteLine("a: {0}, b: {1}", a, b);

           
            //Hello();
            //Console.ReadLine();

        }
        
        static void PorovnaniCisel (int a, int b)
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
            Console.WriteLine("Hello {0}", jmeno);
            
        }


    }
}
