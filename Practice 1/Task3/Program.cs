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
            Console.Write("Введите X:=");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Pow(x, 2) - (Math.Sqrt(Math.Abs(1 - Math.Pow(Math.Sin(x), 2)))) / (Math.Cos(x) * 2 * Math.PI / 3) * Math.Pow(Math.E, 4 * Math.Sqrt(x));
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}