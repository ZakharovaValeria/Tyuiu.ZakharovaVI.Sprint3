using Tyuiu.ZakharovaVI.Sprint3.Task0.V4.Lib;

namespace Tyuiu.ZakharovaVI.Sprint3.Task0.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 6482.439;

            Assert.AreEqual(wait, res);
        }
    }
}
