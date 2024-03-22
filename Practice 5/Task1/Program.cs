using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите значение x: ");
                double x = double.Parse(Console.ReadLine());
                double y = (2 * x / Math.Sin(x)) - 4 *x ;
                Console.WriteLine($"Значение выражения: {y}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("деления на ноль");
            }

            Console.WriteLine();

            try
            {
                Console.Write("Введите значение x: ");
                double x = double.Parse(Console.ReadLine());
                double y = 1 / Math.Pow(Math.Tan(x - 1), 2);
                Console.WriteLine($"Значение выражения: {y}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("деления на ноль");
            }

            Console.ReadLine();
        }
    }

}