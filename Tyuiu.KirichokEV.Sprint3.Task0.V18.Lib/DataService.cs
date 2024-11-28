using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KirichokEV.Sprint3.Task0.V18.Lib
{
    public class DataService : ISprint3Task0V18
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multSeries = multSeries + (Math.Pow((2 / (Math.Cos(value) + 0.5)), startValue));
                startValue++;
            }
            return Math.Round(multSeries, 3);
        }
    }
}
