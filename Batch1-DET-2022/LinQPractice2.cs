using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LinQPractice2
    {
        public static void Main()
        {
            List<string> words = new List<string> { "Basket", "Blueberry", "chimpanze", "abacus", "banana", "apple", "cheese" };

            var wordGroup = from w in words
                            group w by w[0] into g
                            select new { firstletter = g.Key, Words = g
                            };
            foreach (var item in wordGroup)
            {
                Console.WriteLine("Words starts with " +
                    "letter'{0}':", 
                    item.firstletter);

                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }
            }
            
        }
    }
}
