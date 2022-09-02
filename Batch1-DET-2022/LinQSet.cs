using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinQSet
    {
        public static void Main()
        {

            ////Distinct
            //int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9,9,9,9,9,9,9,9,9 };

            //var result = numbers.Distinct();

            //Console.WriteLine("Distinct removes duplicate elements:");
            //foreach (int number in result)
            //    Console.WriteLine(number);




            ////Except
            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Except(numbers2);

            //   Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            //foreach (int number in result)
            //    Console.WriteLine(number);




            ////Intersect

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Intersect(numbers2);

            //Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            //foreach (int number in result)
            //  Console.WriteLine(number);





            //union

            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Console.WriteLine(number);

        }
    }
}
