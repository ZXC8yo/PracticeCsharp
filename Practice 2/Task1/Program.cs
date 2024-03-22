using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            if (0.1 <= x && x <= 1.5)
            {
                Console.WriteLine($"Функция у = {Math.Log10(Math.Pow(Math.E, x) + 4) - 2 * x}");
            }
            if (x > 1.5)
            {
                Console.WriteLine($"Функция у = {Math.Pow(x, 2) - 1}");
            }
        }
    }
}