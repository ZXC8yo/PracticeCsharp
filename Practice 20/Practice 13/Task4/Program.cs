using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /// <summary>
    /// Класс, содержащий точку входа в программу.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Делегат для генерации случайных чисел.
        /// </summary>
        /// <returns>Случайное целое число.</returns>
        public delegate int RandomDelegate();

        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            RandomDelegate[] delegates = new RandomDelegate[5];

            Random random = new Random();

            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => random.Next(0, 100);
            }

            int average = GetAverage(delegates);
            Console.WriteLine("Среднее арифметическое: " + average);
        }

        /// <summary>
        /// Вычисляет среднее арифметическое значение, полученное при вызове делегатов.
        /// </summary>
        /// <param name="delegates">Массив делегатов для генерации случайных чисел.</param>
        /// <returns>Среднее арифметическое полученных чисел.</returns>
        public static int GetAverage(RandomDelegate[] delegates)
        {
            int sum = 0;
            foreach (RandomDelegate del in delegates)
            {
                sum += del();
            }
            return sum / delegates.Length;
        }
    }
}