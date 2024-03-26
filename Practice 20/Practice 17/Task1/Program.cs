using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Класс, содержащий точку входа в программу.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            string filePath = @"D:\Programing\PracticeCsharp\Practice 17\Task1\bin\Debug\context.txt";

            double sum = 0;
            double difference = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                int componentCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    double component;
                    sum += Convert.ToDouble(line);
                    componentCount++;
                }
            }

            List<double> numbers = new List<double>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    numbers.Add(Convert.ToDouble(line));
                }
            }

            double answer = numbers[numbers.Count - 1] - numbers[0];
            Console.WriteLine($"Сумма компонент: {sum}");
            Console.WriteLine($"Разность первой и последней компонент: {answer}");
        }
    }
}