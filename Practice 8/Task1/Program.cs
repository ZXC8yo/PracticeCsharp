using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста, в котором мы ищем слова с четным количеством букв и слова с нечетным количеством цифр 123 435 98";

            Console.WriteLine("Слова с четным количеством букв:");
            foreach (Match match in Regex.Matches(text, @"\b\w{2,}(?=\W|$)"))
            {
                if (match.Value.Length % 2 == 0)
                {
                    Console.WriteLine(match.Value);
                }
            }

            Console.WriteLine("Слова с нечетным количеством цифр:");
            foreach (Match match in Regex.Matches(text, @"\b\w*\d\w*(?=\W|$)"))
            {
                if (match.Value.Count(char.IsDigit) % 2 == 1)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
