
using Batch1_DET_2022;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2022
{
    internal class Programm
    {
        //class MyClass
        //{
        //    enum Grade { Pass = 60, Distinction = 85 };
        //    /// <summary>
        //    /// method that returns Grade based on the mark
        //    /// </summary>
        //    /// <param name="mark">mark as the input</param>
        //    /// <returns></returns>
        //    public static string GetGrade(int mark) //IN parameter
        //    {
        //        if (mark >= (int)Grade.Distinction)
        //            return "Distinction";
        //        else if (mark >= (int)Grade.Pass)
        //            return "PASS";
        //        else
        //            return "FAIL";
        //    }
        //    public static void Main()
        //    {
        //        try
        //        {
        //            Empp m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
        //                                                                                                // Console.WriteLine(m.Print());

        //            Empp m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
        //            // Console.WriteLine(m1.Print());  //base class ref can point to derived object

        //            Empp e1 = new Empp(1, "Jiyana", new DateOnly(2020, 1, 5));
        //            //Console.WriteLine(e1.Print());

        //            Console.WriteLine("enter empid b.w 1001 - 25000");
        //            int id = Convert.ToInt32(Console.ReadLine());
        //            if (id < 1001 || id > 25000)
        //                throw new InvalidEmpIDException("Entered empid is not in the range...");

        //            Console.WriteLine("enter emp name");
        //            string name = Console.ReadLine();

        //            Console.WriteLine("enter doj");
        //            DateOnly doj = DateOnly.Parse(Console.ReadLine());

        //            Empp e2 = new(id, name, doj);


        //            List<Empp> list = new List<Empp>();
        //            list.Add(m);
        //            list.Add(m1);
        //            list.Add(e1);
        //            foreach (Empp x in list)
        //                Console.WriteLine(x.Print());
        //        }
        //        catch (InvalidEmpIDException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        catch (Exception e)
        //        { }
        //    }
        //}
        //public static void Main()
        //{
        //    CompanyManager m = new CompanyManager { Name = "Balaji", Surname = "R", Phone = "9848445445" };
        //    Company company = new Company
        //    {
        //        Name = "SSL",Address = "Global City",Phone = "865835868",Website = "SONATA-SOFTWARE.COM ",Manager = m
        //    };

        //    Console.WriteLine(company.Print());
        //}

        public static void Main()
        {
            //Circ c = new Circ { Radius = 4 };
            //Sphere s = new Sphere { Radius = 4 };

            //Console.WriteLine(c.Area());
            //Console.WriteLine(s.Area());

            List<Animal> sound = new List<Animal>();
            sound.Add(new Dog());
          

            foreach (Animal a in sound)
                Console.WriteLine(a.Sound());


        }

    }

}

