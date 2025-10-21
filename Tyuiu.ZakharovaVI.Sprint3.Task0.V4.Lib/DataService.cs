
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZakharovaVI.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double sumseries = 1;
            int i;
            for (i = startValue;  i <= stopValue; i++)
            {
                sumseries *= (Math.Sin(0.1) + i);
            }
            return Math.Round(sumseries, 3);
        }
    }
}
