using MyClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    internal class UnitTest1
    {
        public class UnitTest1ICar
        {
            [TestMethod]
            public void TestGetPrice()
            {
                Bmw b = new Bmw();
                int execpted = 1300000;
                int actual = b.GetPrice("M3");
                Assert.AreEqual(execpted, actual);

            }
        }
    }
}