using Tyuiu.SafonovRV.Sprint3.Task1.V16.Lib;

namespace Tyuiu.SafonovRV.Sprint3.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 16;
            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 51191.405;
            Assert.AreEqual(wait, res);

        }
    }
}