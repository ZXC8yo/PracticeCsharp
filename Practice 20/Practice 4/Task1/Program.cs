using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        /// <summary>
        /// Выполняет функцию на входном числе.
        /// </summary>
        /// <param name="x">Входное число.</param>
        /// <returns>Результат функции.</returns>
        static double Function(double x)
        {
            if (x % 2 == 0)
            {
                return x / 2;
            }
            else
            {
                return x = 0;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine($"Итоговое число {Function(x)}");
        }
    }
}