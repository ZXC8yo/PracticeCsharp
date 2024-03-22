using System;
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
            Console.Write("Введите текст: ");
            string s = Console.ReadLine();

            string[] word = s.Split(' ');
            string max = word[0];

            foreach (var T in word)
                {
                    if (max.Length < T.Length)
                    {
                        max = T;
                    }
                }

            Console.WriteLine($"{max}, {max.Length}");
        }
    }
}
