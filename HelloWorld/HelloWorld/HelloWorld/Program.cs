using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
        
           
            Hello();
            Console.ReadLine();

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
