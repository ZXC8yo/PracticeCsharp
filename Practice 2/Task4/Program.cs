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
            Console.WriteLine("Введите начало диапазона");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("For");
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.WriteLine("While");
            int p = a;
            while (p < b)
            {
                p++;
                if (p % 2 == 0)
                {
                    Console.WriteLine(p);
                }
            }

            Console.WriteLine("Do while");
            int o = a;
            do
            {
                
                o++;
                if (o % 2 == 0)
                {
                    Console.WriteLine(o);
                }
            }
            while ((o < b));
        }
    }
}
