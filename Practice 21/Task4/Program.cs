using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 10;


            Parallel.For(A, B + 1, i =>
            {
                if (i == 0)
                {
                    Console.WriteLine("На ноль делить нельзя");
                    i += 1;
                }
                double result = MyFunction(i);
                Console.WriteLine("Значение функции для {0}: {1}", i, result);
            });
        }

        private static double MyFunction(int x)
        {

            return x * Math.Sin(x);
        }
    }
}
