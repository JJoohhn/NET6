using System;
using System.Collections.Generic;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            //List<int> list_intu = new List<int>();
            //List<Person> people = new List<Person>();
            //var p1 = new Person("Adam", "Smith", 44);
            //var p2 = new Person("Jane", "Doe", 54);
            //var p3 = new Person("Jan", "Novák", 34);
            //var p4 = new Person("Marie", "Dolejší", 24);

            //people.Add(p1);
            //people.Add(p2);
            //people.Add(p3);
            //people.Add(p4);

            //string file = "people.txt"; // Bude se ukládat vedle exe souboru

            //foreach (var p in people)
            //{
            //    var personAsString = $"{p.FirstName};{p.LastName};{p.Age}{Environment.NewLine}";//Environment - nový rádek v daném operačním systému

            //    File.AppendAllText(file, personAsString);
            //}


            //Console.WriteLine($"ulozeno do souboru {file}");

            PreciCelySoubor("people.txt");

        

           

        }

        public static string PreciCelySoubor(string soubor)
        {
            string obsah = "";
            //StreamReader sr = new StreamReader(soubor);
            using (StreamReader sr = new StreamReader(soubor))
            {
                obsah = sr.ReadToEnd();
            }
            //sr.Close();
            Console.WriteLine(obsah);
            return obsah;
        }
        static void PersonActions()
        {
            Person p1 = new Person("Adam", "Smith", 30);


            Person alice = new Person();
            alice.FirstName = "Alice";
            alice.LastName = "Smith";
            alice.Age = 36;

            Console.WriteLine("osoba 1:  {0}", p1);



        }

        

    }
}
