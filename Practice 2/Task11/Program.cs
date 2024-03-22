using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число A (-5 <= A <= 5):");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите целое число N (1 <= N <= 10):");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = Math.Pow(a, n);

            Console.WriteLine("Результат: {0:F4}", result);
        }
    }
}