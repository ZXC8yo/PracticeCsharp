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
            Console.Write("Введите текст ");
            string s = Console.ReadLine();
            Console.Write("Сколько букв в слове ");
            double n = double.Parse(Console.ReadLine());

            string[] mas = s.Split(' ');

            foreach (var S in mas) 
            {
                if (n >= S.Length)
                {
                    Console.WriteLine(S);
                }               
                
            }
        }
    }
}
