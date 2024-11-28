using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KirichokEV.Sprint3.Task1.V10.Lib
{
    public class DataService : ISprint3Task1V10
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 1;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + (Math.Pow (1 / (startValue + Math.Pow (value, startValue)), startValue));
                startValue++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
