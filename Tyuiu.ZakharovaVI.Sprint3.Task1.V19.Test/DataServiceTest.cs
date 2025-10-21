﻿using Newtonsoft.Json.Linq;
using Tyuiu.ZakharovaVI.Sprint3.Task1.V19.Lib;

namespace Tyuiu.ZakharovaVI.Sprint3.Task1.V19.Test

{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 1;
            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 96.895;
            Assert.AreEqual(wait, res);
        }
    }
}
