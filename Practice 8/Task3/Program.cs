using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста, в котором повторяются некоторые слова, такие как пример, текста, и, котором, повторяются.";

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            string pattern = @"\b\w+\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                string word = match.Value.ToLower();

                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            Console.WriteLine("Повторяющиеся слова в тексте:");

            foreach (KeyValuePair<string, int> pair in wordCount)
            {
                if (pair.Value > 1)
                {
                    Console.WriteLine($"{pair.Key}: {pair.Value} раз(а)");
                }
            }
        }
    }
}
