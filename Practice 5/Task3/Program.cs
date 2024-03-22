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
            try
            {
                double A, B, C, D;

                Console.Write("Введите значение A: ");
                A = double.Parse(Console.ReadLine());

                Console.Write("Введите значение B: ");
                B = double.Parse(Console.ReadLine());

                Console.Write("Введите значение C: ");
                C = double.Parse(Console.ReadLine());

                Console.Write("Введите значение D: ");
                D = double.Parse(Console.ReadLine());

                Swap(ref A, ref B);

                Swap(ref C, ref D);

                Swap(ref B, ref C);

                Console.WriteLine("A: " + A);
                Console.WriteLine("B: " + B);
                Console.WriteLine("C: " + C);
                Console.WriteLine("D: " + D);

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("деления на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }


        static void Swap(ref double x, ref double y)
        {
            double temp = x;
            x = y;
            y = temp;
        }

    }
}