using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class linQDemo2
    {
        public static void Main()
        {
            //{ // ordering
            //    int[] numbers = { 7, 9, 5 };

            //    var result = numbers.OrderBy(n => n);

            //   Console.WriteLine("Ordered list of numbers:");
            //    foreach (int number in result)
            //        Console.WriteLine(number);





            //Descending

            //string[] names = { "Kishor", "Ramu", "Susan" };

            //var result = names.OrderByDescending(n => n);

            //Console.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Console.WriteLine(name);





            //reverse

            // char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

            // var result = characters.Reverse();

            //Console.WriteLine("Characters in reverse order:");
            // foreach (char character in result)
            // Console.WriteLine(character);






            //Thenby

            //string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
            //              "Athens", "Beijing", "Seoul" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Debug.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Debug.WriteLine(capital);




            //ThenBydesending

            //   var dates = new DateTime[] {
            //new DateTime(2015, 3, 1),
            //new DateTime(2014, 7, 1),
            //new DateTime(2013, 5, 1),
            //new DateTime(2015, 1, 1),
            //new DateTime(2015, 7, 1) };


            //   var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            //   Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            //   foreach (DateTime dt in result)
            //       Console.WriteLine(dt.ToString("yyyy/MM/dd"));





            ////Skip
            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.Skip(4);

            //Console.WriteLine("Skips the first 4 words:");
            //foreach (string word in result)
            //   Console.WriteLine(word);





            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.SkipWhile(w => w.Length == 3);

            //Console.WriteLine("Skips words while the condition is met:");
            //foreach (string word in result)
            //    Console.WriteLine(word);






            // //Take
            // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // var result = numbers.Take(5);

            //Console.WriteLine("Takes the first 5 numbers only:");
            // foreach (int number in result)
            //     Console.WriteLine(number);






            ////takewhile
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 0, 2, 10 };

            //var result = numbers.TakeWhile(n => n <= 8);

            //Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            //foreach (int number in result)
            //    Console.WriteLine(number);





            ////aggregate simple
            //var numbers = new int[] { 1, 2, 3, 4, 5 };

            //var result = numbers.Aggregate((a, b) => a * b);

            //Console.WriteLine("Aggregated numbers by multiplication:");
            //Console.WriteLine(result);





            ////Average
            //int[] numbers = { 10, 10, 11, 11,88 };

            //var result = numbers.Average();

            //Console.WriteLine("Average is:");
            //Console.WriteLine(result);





            ////Count
            //string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" ,"Kishor"};

            //var result = names.Count();

            //Console.WriteLine("Counting names gives:");
            //Console.WriteLine(result);





            ////max
            //int[] numbers = { 2, 8, 5, 6, 1 };

            //var result = numbers.Max();

            //Console.WriteLine("Highest number is:");
            //Console.WriteLine(result);



            ////min
            //int[] numbers = { 6, 9, 3, 7, 5 };

            //var result = numbers.Min();

            //Console.WriteLine("Lowest number is:");
            //Console.WriteLine(result);



            //sum

            int[] numbers = { 10, 10, 10 };

            var result = numbers.Sum();

          
            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);

        }

    }
}
