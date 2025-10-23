﻿using Tyuiu.ZakharovaVI.Sprint3.Task7.V11.Lib;

namespace Tyuiu.ZakharovaVI.Sprint3.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 20.36;
            valueWaitArray[1] = 15.42;
            valueWaitArray[2] = 10.99;
            valueWaitArray[3] = 7.43;
            valueWaitArray[4] = 4.33;
            valueWaitArray[5] = 1;
            valueWaitArray[6] = 0;
            valueWaitArray[7] = -8.87;
            valueWaitArray[8] = -13.03;
            valueWaitArray[9] = -16.53;
            valueWaitArray[10] = -19.6;

            double[] res;
            //res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            //CollectionAssert.AreEqual(valueWaitArray, res);

            Console.WriteLine("Expected: " + string.Join(",", valueWaitArray));
            Console.WriteLine("Actual: " + string.Join(", ", res));


            CollectionAssert.AreEqual(valueWaitArray, res);

            //Console.WriteLine("Expected: " + string.Join(", ", expectedCollection));
            //Console.WriteLine("Actual: " + string.Join(", ", actualCollection));
        }
    }
}
