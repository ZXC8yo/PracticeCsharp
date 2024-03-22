using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Информатика — это наука о методах и процессах сбора, хранения, обработки, передачи, анализа и интерпретации данных. Информатика имеет широкое применение в различных областях, включая компьютерные науки, информационные технологии, телекоммуникации и другие.";

            string pattern = @"(?<=^|[.!?]\s+)\p{Lu}[^\p{Lu}]*\bИнформатика\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            int count = matches.Count;

            Console.WriteLine($"Количество предложений, начинающихся со слова \"Информатика\": {count + 1}");
        }
    }
}
