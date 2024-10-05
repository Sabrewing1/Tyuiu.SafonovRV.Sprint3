using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SafonovRV.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            do
            {
                sumSeries = sumSeries + Math.Pow((1 / (Math.Sin(startValue))), 3);
                startValue++;
            } while (startValue <= stopValue);
                return Math.Round(sumSeries, 2);
        }
    }
}
