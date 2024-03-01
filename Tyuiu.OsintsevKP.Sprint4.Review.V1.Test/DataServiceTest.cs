using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OsintsevKP.Sprint4.Review.V1.Lib;

namespace Tyuiu.OsintsevKP.Sprint4.Review.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {


            int rows = 3; int columns = 3;
            int[,] mtrx = new int[rows, columns]; string str = "135792468";
            DataService ds = new DataService();
            int res = ds.Calculate(rows, columns, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
