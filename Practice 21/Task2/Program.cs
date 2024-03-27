using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {

        public static double Solution1(int a)
        {
            return (Math.Pow(((1 + a + Math.Pow(a,2)) / 2 * a *Math.Pow(a,2)) + 2 - ((1 - a + Math.Pow(a,2))/2 * a * Math.Pow(a,2)), -1)) * 5 - 2 * Math.Pow(a,2);

        }

        public static double Solution2(int a)
        {
            return (4 - Math.Pow(a,2))/2;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите a:");
            int a = int.Parse(Console.ReadLine());
            
            Task[] tasks = new Task[2];


            tasks[0] = Task.Run(() =>
            {
                Console.WriteLine($"Задача 1 запущена c параметром A{a}");
                double answer = Solution1(a);
                Thread.Sleep(2000);
                Console.WriteLine($"Задача 1 завершена c результатом:{answer}");
            });


            tasks[1] = Task.Run(() =>
            {
                Console.WriteLine($"Задача 1 запущена c параметрами A:{a}");
                double answer = Solution2(a);
                Thread.Sleep(3000);
                Console.WriteLine($"Задача 1 завершена c результатом:{answer}");
            });


            Task.WaitAll(tasks);
            Console.WriteLine("Все задачи завершены");


            Task.WaitAny(tasks);
            Console.WriteLine("Хотя бы одна задача завершена");
        }
    }

}
