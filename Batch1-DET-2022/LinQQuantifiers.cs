using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinQQuantifiers
    {
        public static void Main()
        {
            // All
            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

            //var result = names.All(n => n.StartsWith("B"));

            //Console.WriteLine("Does all of the names start with the letter 'B':");
            //Console.WriteLine(result);




            //Any

            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);





            //    //Contains
            //    int[] numbers = { 1, 3, 5, 7, 9 };

            //    var result = numbers.Contains(5);

            //    Console.WriteLine("sequence contains the value 5:");
            //    Console.WriteLine(result);
            //}

        }
    }
}