using System;
using Tyuiu.MatyushenkoSV.Sprint4.Task6.V29.Lib;

namespace Tyuiu.MatyushenkoSV.Sprint4.Task6.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Матюшенко С. В. | ИИПб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array и строковые массивы                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Матюшенко Савелий Владимирович | ИИПб-26-1                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных [\"Весна\", \"Лето\", \"Осень\", \"Зима\"].       *");
            Console.WriteLine("* Подсчитайте количество элементов, длина которых больше 4.               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] seasons = { "Весна", "Лето", "Осень", "Зима" };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < seasons.Length; i++)
            {
                Console.WriteLine(seasons[i]);
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(seasons);

            Console.WriteLine("Количество элементов с длиной больше 4 = " + res);

            Console.ReadKey();
        }
    }
}