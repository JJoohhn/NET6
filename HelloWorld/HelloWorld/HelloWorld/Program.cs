using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            int b = 30;

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("{0},{1}", a, b);

           
            //Hello();
            //Console.ReadLine();

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
