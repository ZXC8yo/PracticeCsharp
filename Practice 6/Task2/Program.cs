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
            int[] sequence = { 1, -2, 3, -4, 5, -6, 7, -8 };

            if (CheckAlternating(sequence))
            {
                Console.WriteLine("Последовательность является чередующейся:");
                PrintSequence(sequence);
            }
            else
            {
                int[] negativeNumbers = GetNegativeNumbers(sequence);
                Console.WriteLine("Отрицательные числа последовательности:");
                PrintSequence(negativeNumbers);
            }
        }

        static bool CheckAlternating(int[] sequence)
        {
            for (int i = 0; i < sequence.Length - 1; i++)
            {
                if ((sequence[i] >= 0 && sequence[i + 1] >= 0) || (sequence[i] < 0 && sequence[i + 1] < 0))
                {
                    return false;
                }
            }
            return true;
        }

        static int[] GetNegativeNumbers(int[] sequence)
        {
            List<int> negativeNumbers = new List<int>();
            foreach (int num in sequence)
            {
                if (num < 0)
                {
                    negativeNumbers.Add(num);
                }
            }
            return negativeNumbers.ToArray();
        }

        static void PrintSequence(int[] sequence)
        {
            foreach (int num in sequence)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
