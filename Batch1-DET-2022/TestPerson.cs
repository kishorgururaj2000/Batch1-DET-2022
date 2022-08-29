using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class TestPerson
    {
        public static void Main()
        {
            try
            {
                Person t = new Person("Kishor", "BG", "kishor.bg@gmail.com", new DateOnly(2000, 12, 12));
                int byear = t.BirthYear();
                if (byear < 1900 || byear > 2022)
                {
                    throw new InvalidBirthYearException("ENTER VALID BIRTH YEAR");
                }
                string r = t.GetSunSign();
                string s = t.ChineseZodiac();
                string w = t.IsAdult();
                string b = t.BDayStatus();
                string u = t.DefaultUsername();
                string n = t.GetInfo();
                Console.WriteLine($"NAME = {n}");
                Console.WriteLine($"Sun Sign = {r}");
                Console.WriteLine($"Chinese Zodiac = {s}");
                Console.WriteLine($"Age Status = {w}");
                Console.WriteLine($"Birthday Status = {b}");
                Console.WriteLine($"Default Username = {u}");
            }
            catch (InvalidBirthYearException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }

    [Serializable]
    internal class InvalidBirthYearException : Exception
    {
        public InvalidBirthYearException()
        {
        }

        public InvalidBirthYearException(string? message) : base(message)
        {
        }

        public InvalidBirthYearException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidBirthYearException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

