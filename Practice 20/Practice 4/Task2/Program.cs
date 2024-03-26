using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        /// <summary>
        /// Вычисляет значение функции f для заданного входного значения.
        /// </summary>
        /// <param name="x">Входное значение.</param>
        /// <returns>Результат функции.</returns>
        static double f(double x)
        {
            double y;
            if (x < 0)
                y = 0;
            else if (x > 0 && x != 0)
                y = Math.Pow(x, 2) + 1;
            else
                y = 1;
            return y;
        }

        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h=");
            double h = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
        }
    }
}