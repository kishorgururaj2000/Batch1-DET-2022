﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LearnLinQ
    {



        private static void Main()
        {
            //the three parts of linq 

            //1.Data source

            List<int> numbers = new List<int>();
            numbers.Add(110);
            numbers.Add(100);
            numbers.Add(105);
            numbers.Add(102);
            //2.Query creation.sql type
            //var numQuery = from num in numbers           // select num from numbers
            //               select num;

            //var numQuery = (from num in numbers  // select num from numbers
            //                select num).ToList();



            //var numQuery = from num in numbers           // select num from numbers
            //               where num>102
            //               select num;
            //lamda exp

            // var numQuery = numbers.Select(x => x);

            var numQuery = numbers.Where(x => x > 102);

            // 3. Query execution
            numbers.Add(200);
            numbers.Add(202);

            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num);
            }
            Console.ReadLine();
        }








    }
}
