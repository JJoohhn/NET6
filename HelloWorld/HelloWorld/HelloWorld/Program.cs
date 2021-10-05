using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            RokNarozeni();
            
            

        }

        static void RokNarozeni()
        {
            Console.WriteLine("napiš rok narození: ");
            int rok = int.Parse(Console.ReadLine());
            if (rok <= 1964 && rok >= 1946)
                Console.WriteLine("Baby Boomerss");
            if (rok <= 1980 && rok >= 1965)
                Console.WriteLine("Generation X");
            if (rok <= 1996 && rok >= 1981)
                Console.WriteLine("Millenials");
            if (rok <= 2012 && rok >= 1997)
                Console.WriteLine("Generation Z");
            if (rok >= 2013)
                Console.WriteLine("Baby Boomerss");

        }


    }
}
