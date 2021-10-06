using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class DruhyDen
    {
        //Console.WriteLine("Zadávej čísla: ");
        //int cislo = int.Parse(Console.ReadLine());

        //int soucet = 0;
        //int [] sumahodnot = new int[cislo];

        //for (int i = 0; i <= sumahodnot.Length; i++)
        //{
        //    soucet = soucet + i;
        //}


        //Console.WriteLine("Součet je: {0}", soucet);



        //while (cislo % 2 !=0)
        //{
        //    Console.WriteLine("Zadávej čísla: ");
        //    double cislo = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Cislo je liche {0}", cislo);

        //}


        //array - ple cisel
        //int[] numbers = new[] { 10, 11, 12, 13, 20, 67 };

        //// klasicky for s indexem - vim kolikrat se opakuje
        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    var num = numbers[i];
        //    Console.WriteLine("Na indexu {0} je hodnota {1}", i, num);
        //}

        //// foreach - iterace pres kolekci prvku (pole)
        //foreach (int number in numbers)
        //{
        //    Console.WriteLine("ted se zpracovavam cislo {0}", number);
        //}

        ////while cyklus
        //int counter = 0;
        //while (counter < 5)
        //{
        //    counter = counter++;
        //}


        //var daynumber = 5;
        //var dayname = GetDayName(daynumber);
        //Console.WriteLine($"{daynumber}. den je {dayname}");

        //RokNarozeni();





        //        try
        //            {
        //                var number = int.Parse(Console.ReadLine());
        //    }
        //            catch(FormatException ex)
        //            {
        //                Console.WriteLine("Nemohu převést řetězec na číslo");
        //            }
        //            catch (Exception ex)// Jakákoli obecná výjmka
        //{
        //    Console.WriteLine("ex.Message");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.ToString()); // Vypíše mimo jíné i ve hlášce číslo řádku chyby
        //}



        //var tupleResult = MyTryParse("150.0");
        //tupleResult.Item2



        //            static (bool, int) MyTryParse(string input)
        //{
        //    return (true, 10);
        //}
        //-------------------------------------------------------------


        //// tuple - združuje více věcí


        //-----------------------------------------------------------

        //int num = 0;
        //bool success = int.TryParse(Console.ReadLine(), out num);

        //if (success)
        //{
        //    num //
        //            }
        //else
        //{

        //}
        //-----------------------------------------------------------
        //            //var point = new Point(10, 20);
        //            //var point2 = new Point(11, 21);
        //            //Console.WriteLine(point);
        //            //Console.WriteLine(point2);

        //static string GetDayName(int day)
        //        {
        //            switch (day)
        //            {
        //                case 1:
        //                    return "pondeli";
        //                    break;
        //                case 2:
        //                    return "úterý";
        //                    break;
        //                case 3:
        //                    return "středa";
        //                    break;
        //                case 4:
        //                    return "čtvrtek";
        //                    break;
        //                case 5:
        //                    return "pátek";
        //                    break;
        //                case 6:
        //                    return "sobota";
        //                    break;
        //                case 7:
        //                    return "neděle";
        //                    break;
        //                default:
        //                    return "neznám";
        //                    break;



        //            }
        //        }


        //        static void RokNarozeni()
        //        {
        //            Console.WriteLine("napiš rok narození: ");
        //            int rok = int.Parse(Console.ReadLine());
        //            if (rok <= 1964 && rok >= 1946)
        //                Console.WriteLine("Baby Boomerss");
        //            if (rok <= 1980 && rok >= 1965)
        //                Console.WriteLine("Generation X");
        //            if (rok <= 1996 && rok >= 1981)
        //                Console.WriteLine("Millenials");
        //            if (rok <= 2012 && rok >= 1997)
        //                Console.WriteLine("Generation Z");
        //            if (rok >= 2013)
        //                Console.WriteLine("Baby Boomerss");

        //        }
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

        //PreciCelySoubor("people.txt");

    }
}
