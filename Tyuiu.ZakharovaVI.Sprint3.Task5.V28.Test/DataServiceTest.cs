using Tyuiu.ZakharovaVI.Sprint3.Task5.V28.Lib;

namespace Tyuiu.ZakharovaVI.Sprint3.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 3;
            int stopValue1 = 1;
            int stopValue2 = 12;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = -349.648;
            Assert.AreEqual(wait, res);



        }
    }
}
