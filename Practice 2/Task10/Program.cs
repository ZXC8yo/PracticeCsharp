using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            bool isDistinct = (firstDigit != secondDigit) && (firstDigit != thirdDigit) && (secondDigit != thirdDigit);

            Console.WriteLine("Цифры числа различны: " + isDistinct);
        }
    }
}