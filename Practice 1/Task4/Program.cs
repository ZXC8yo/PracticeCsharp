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
            Console.WriteLine("Введите радиус основания цилиндра:");
            Console.Write("r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту цилиндра:");
            Console.Write("h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double V = Math.PI * Math.Pow(r, 2) * h;
            double area = 2 * Math.PI * r * h + 2 * Math.PI * (Math.Pow(r, 2));

            Console.WriteLine("Объем цилиндра: " + V);
            Console.WriteLine("Площадь цилиндра: " + area);
            Console.ReadLine();
        }
    }
}
