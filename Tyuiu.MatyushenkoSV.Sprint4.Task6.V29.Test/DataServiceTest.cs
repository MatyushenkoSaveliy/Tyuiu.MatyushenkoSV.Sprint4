using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MatyushenkoSV.Sprint4.Task6.V29.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint4.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] seasons = { "Весна", "Лето", "Осень", "Зима" };

            int res = ds.Calculate(seasons);

            int wait = 2;

            Assert.AreEqual(wait, res);
        }
    }
}