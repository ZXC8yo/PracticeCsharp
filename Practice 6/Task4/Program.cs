using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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

            Console.Write("Введите номер стоки = ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Введите номер столбца = ");
            int column = int.Parse(Console.ReadLine());

            int k = row - 1;
            int s = column - 1;

            int rowSum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                rowSum += array[k, i];
            }

            int colSum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                colSum += array[i, s];
            }

            int max = Math.Max(rowSum, colSum);

            Console.WriteLine($"Сумма строки - {rowSum}. Сумма столбца - {colSum}");
            Console.WriteLine("Максимальное число: " + max);
        }
    }
}
