using Tyuiu.SafonovRV.Sprint3.Task0.V24.Lib;

namespace Tyuiu.SafonovRV.Sprint3.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSerios()
        {
            DataService ds= new DataService();

            int  value = 5;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 0.125;

                Assert.AreEqual(wait, res);

        }
    }
}