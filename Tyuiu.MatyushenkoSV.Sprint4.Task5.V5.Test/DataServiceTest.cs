using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint4.Task5.V5.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint4.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5] {
                { -5, 2, 3, -1, 0 },
                { 8, -4, 5, -2, 1 },
                { -3, 0, 7, -5, 4 },
                { 6, -1, 2, 3, -2 },
                { 1, 1, -5, -3, 5 }
            };

            int res = ds.Calculate(matrix);

            int wait = 48;

            Assert.AreEqual(wait, res);
        }
    }
}