using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону a = " );
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите сторону c = ");
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c && Math.Pow(a,2) == Math.Pow(c, 2) + Math.Pow(b, 2)) 
            {
                Console.WriteLine($"Треугольник прямоугольный");
            }
            if (c > b && c > a && Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine($"Треугольник прямоугольный");
            }
            if (b > a && b > c && Math.Pow(a, 2) == Math.Pow(c, 2) + Math.Pow(b, 2))
            {
                Console.WriteLine($"Треугольник прямоугольный");
            }
        }
    }
}
