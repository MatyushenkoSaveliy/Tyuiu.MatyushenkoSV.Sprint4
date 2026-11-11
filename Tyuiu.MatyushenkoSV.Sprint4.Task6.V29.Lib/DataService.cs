using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MatyushenkoSV.Sprint4.Task6.V29.Lib
{
    public class DataService : ISprint4Task6V29
    {
        public int Calculate(string[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > 4)
                {
                    count++;
                }
            }

            return count;
        }
    }
}