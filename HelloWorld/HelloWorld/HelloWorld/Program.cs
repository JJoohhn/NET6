using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Dataset;
using Dataset.Model;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //nacti klienty z XML
            var clients = Data.LoadFromXML();

            //var result = clients.GroupBy(client => client.Age);

            //Client nejstarsi = clients.OrderByDescending(c => c.Age()).First();
            //Console.WriteLine($"Nejstarší klient: {nejstarsi.FirstName} {nejstarsi.LastName}, věk: {nejstarsi.Age});
            //Client nejmladsi = clients.OrderBy(c => c.Age()).First();
            //Console.WriteLine($"Nejmladší klient: {nejmladsi.FirstName} {nejmladsi.LastName}, věk: {nejmladsi.Age}");

            Client nejbohatsi = clients.OrderBy(c => c.).First();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"město: {item.Key} - počet lidí : {item.Count()}");
            //}

            ////pocet klientu
            
            //Console.WriteLine(clients.Count());

            //var result = clients.Where(c => c.Age() > 50);

            //var result = clients.Select(client => client.FirstName);
            
                //console.writeline("co je");
                //int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

                ///// z "numebers" zjistěte:
                ///// 1. počet prvků v poli
                ///// 2. největší hodnotu
                ///// 3. nejmenší hodnotu
                ///// 4. průměr
                ///// 5. kolik obsahuje pole kladných čísel
                ///// 6. kolik obsahuje pole záporných čísel
                ///// 7. sumu všech hodnot
                ///// 8. sumu kladných hodnot
                //var sum = numbers.sum();
                //console.writeline("sum: {0}", sum);
                //var maximalnihodnota = numbers
                //    .max();
                //console.writeline("max: {0}", maximalnihodnota);
                //var minimalnihodnota = numbers
                //    .min();
                //console.writeline("min: {0}", minimalnihodnota);


                //console.readline();


                ////// projection / restrikce / filtrovani - where

                /// 9. všechna čísla větší než -500
                /// 10. všechna kladná sudá čísla
                /// 11. čísla v rozstahu -400 až 400


                //foreach (var item in ordered)
                //{
                //    console.writeline(item);
                //}
            




            //int[] numbers = { 1, 2, 3, 4, 20, 256, -45 };

            //var result = numbers.where(number => number > 20);

            //foreach (var item in result)
            //{
            //    console.writeline(item);
            //}








            //person p1 = new person();

            //p1.homeaddress.city = "brno";


            //var people = loadpeople("people.txt");

            //foreach (var p in people)
            //{
            //    console.writeline(p);
            //}






        }
        static List<Person> LoadPeople(string file)
        {
            List<Person> people = new List<Person>();
            string[] lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                //FirstName;LastName;Age

                var items = line.Split(';');

                var first_name = items[0];
                var last_name = items[1];
                var age = int.Parse(items[2]);

                var p = new Person(first_name, last_name, age);
                people.Add(p);
            }
            return people;
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
            //alice.Age = 36;

            Console.WriteLine("osoba 1:  {0}", p1);



        }

        

    }
}
