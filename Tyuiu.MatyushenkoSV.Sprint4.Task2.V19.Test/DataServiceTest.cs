using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint4.Task2.V19.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint4.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 5, 6, 7, 8, 9, 4, 5, 6, 7, 8, 9, 4, 5 };

            int res = ds.Calculate(numsArray);

            int wait = 47;

            Assert.AreEqual(wait, res);
        }
    }
}