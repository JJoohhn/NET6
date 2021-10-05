using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class TempCalcs
    {
        public static void PrintAndConvertTemp()
        {
            Console.WriteLine("zadej teplotu (F):");
            var input_string = Console.ReadLine();
            var input_double = double.Parse(input_string);
            var c = ConvertFtoC(input_double);
            Console.WriteLine($"Teplota v (C):{c}");
        }

        /// <summary>
        /// Konertuje stupně
        /// </summary>
        /// <param name="f">jmeno f</param>
        /// <returns></returns>
        static double ConvertFtoC(double f)
        {
            return Math.Round(((f - 32) / 1.8), 2);
        }
        
    }
}
