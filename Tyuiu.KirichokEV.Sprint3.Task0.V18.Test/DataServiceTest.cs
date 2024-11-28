using Tyuiu.KirichokEV.Sprint3.Task0.V18.Lib;

namespace Tyuiu.KirichokEV.Sprint3.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 6;
            int startValue = 1;
            int stopValue = 1;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);

            double wait = 2.583;

            Assert.AreEqual(wait, res);
        }
    }
}