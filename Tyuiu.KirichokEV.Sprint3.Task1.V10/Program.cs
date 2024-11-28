using Tyuiu.KirichokEV.Sprint3.Task1.V10.Lib;

namespace Tyuiu.KirichokEV.Sprint3.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Киричoк Е. В.| РППб-24-1";

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                         *");
            Console.WriteLine("* Тема: Оператор цикла while                                                        *");
            Console.WriteLine("* Задание #1                                                                        *");
            Console.WriteLine("* Вариант #10                                                                       *");
            Console.WriteLine("* Выполнила: Киричок Елиавета Викторовна | РППб-24-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать прогарммму используя цикла while, которая вычисляет сумму ряда           *");
            Console.WriteLine("* по формуле, при Х=5                                                               *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 17;

            Console.WriteLine("Переменная Х = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Произведение ряда =" + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
