using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену = ");
            double price = double.Parse(Console.ReadLine());

            if (1 <= price && price <= 100)
            {
                for (double i = 0.1; i < 1; i += 0.1)
                {
                    Console.WriteLine($"{i} {i * price}");
                }
            }
        }
    }
}
