using Tyuiu.KirichokEV.Sprint3.Task1.V10.Lib;

namespace Tyuiu.KirichokEV.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 17;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.168;

            Assert.AreEqual(wait, res);
        }
    }
}