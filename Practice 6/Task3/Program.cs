using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            Console.Write("Поиск чисел меньше заданного h: ");
            int H = int.Parse(Console.ReadLine());

            Console.Write("Введите значение столбца k: ");
            int column = int.Parse(Console.ReadLine());
            int k = column - 1;

            int countLessThanH = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < H)
                    {
                        countLessThanH++;
                    }
                }
            }

            int countOddElements = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, k] % 2 != 0)
                {
                    countOddElements++;
                }
            }

            Console.WriteLine("Количество чисел, меньших " + H + ": " + countLessThanH);
            Console.WriteLine("Количество нечетных элементов в " + column + "-м столбце: " + countOddElements);
        }
    }
}