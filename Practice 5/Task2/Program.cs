﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите x: ");
                double x = double.Parse(Console.ReadLine());
                double result;

                if (x > -4 && x <= -1)
                {
                    if (x == 5)
                    {
                        throw new Exception("Выход за диапазон");
                    }

                    result = x / 2 * x + 2;
                }
                else if (x > -1)
                {
                    result = x + 3;
                }
                else
                {
                    throw new Exception("Выход за диапазон");
                }

                Console.WriteLine($"Значение функции f: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деления на ноль");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}