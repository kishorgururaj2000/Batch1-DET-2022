using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinQPractice
    //{
    //    public static void Main()
    //    {
    //        //string[] numbers = { "John","Peter","Jacob","Harry","Jackson" };

    //        //var result = numbers.MaxBy;

    //        //Console.WriteLine("Highest number is:");
    //        //Console.WriteLine(result);



    //        //string[] words1 = { "believe", "relief", "receipt", "field" };
    //        //foreach  (string word in words1());
    //        // {
    //        //    var result =  words1[0].Length();
    //        //    Console.WriteLine(result);

    //        //}

    //        //reverse

    //        // char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

    //        // var result = characters.Reverse();

    //        //Console.WriteLine("Characters in reverse order:");
    //        // foreach (char character in result)
    //        // Console.WriteLine(character);


    {
        static void Main()
        {
            Ques1();
        }
        static void Ques1()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };
            var result = from name in names
                         where name.Contains('o')
                         select name;
            Console.WriteLine("The names in the list that contain 'o' are: ");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }

            var result1 = names.OrderByDescending(c => c.Length);
            var result2 = result1.First();
            Console.WriteLine("The name with maximum number of charater lenght is: ");
            Console.WriteLine(result2);


        }



    }
}
