using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину первого катета:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            double perimeter = a + b + c;

            Console.WriteLine("Периметр прямоугольного треугольника: " + perimeter);
        }
    }
}