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
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            string firstNumber = $"{a:N2}";
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            string secondNumber = $"{b:N2}";
            double c = b / a;
            string answer = $"{c:N2}";


            Console.WriteLine($"{secondNumber} / {firstNumber} ={answer}");
            Console.ReadLine();
        }
    }
}