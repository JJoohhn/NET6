using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Adam", "Smith");
            p1.Age = 30;

            Person alice = new Person();
            alice.FirstName = "Alice";
            alice.LastName = "Smith";
            alice.Age = 36;

            Console.WriteLine("osoba 1:  {0}", p1);

           

        }

      

    }
}
