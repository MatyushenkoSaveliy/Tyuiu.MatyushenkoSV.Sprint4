using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint4.Task7.V13.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint4.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int rows = 3;
            int columns = 3;
            string str = "159357246";

            int res = ds.Calculate(rows, columns, str);

            int wait = 3;
             
            Assert.AreEqual(wait, res);
        }
    }
}