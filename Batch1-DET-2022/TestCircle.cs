using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class TestCircle
    {
        public static void Main()
        {
            Circle ob = new Circle(45);
            double result = ob.area();
            Console.WriteLine($"Area of Circle is ={result}");

        }
    }
}
