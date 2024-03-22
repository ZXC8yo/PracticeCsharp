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
            int[] mas = { 1, 5, 3, 8, 9, 6 };

            int max = -1;
            int index = -1;

            for (int i = 0; i < mas.Length; i++)

                if (max <= mas[i])
                {
                    max = mas[i];
                    index = i;
                }

            Console.WriteLine($"Большее число {max}, его индекс {index}");
        }
    }
}
