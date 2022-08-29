/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Batch1_DET_2022
{
        internal class RadiusAndDiameter
        {
            double radius;
            double diameter;
            public double Radius { get; set; }
            public double Diameter { get; set; }
            double getArea()
            {
                return Math.PI * Radius * Radius;
            }
            double getDiameter()
            {
                return Radius * 2;
            }
            public static void Main()
            {
            RadiusAndDiameter radiusanddia = new RadiusAndDiameter
            { Radius = 40, Diameter = 45 };
                double radius = radiusanddia.getArea();
                Console.WriteLine($"the radius is {radius}");
                double diameter = radiusanddia.getDiameter();
                Console.WriteLine($"the diameter is{diameter}");
            }
        }
    }*/