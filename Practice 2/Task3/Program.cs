using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер масти(1-4): ");
            int m = int.Parse(Console.ReadLine());
            if (1 <= m && m <= 4)
            {
                switch(m)
                {
                    case 1:
                        Console.WriteLine("Масть — Пики");
                        break;
                    case 2:
                        Console.WriteLine("Масть — Трефы");
                        break;
                    case 3:
                        Console.WriteLine("Масть — Бубны");
                        break;
                    case 4:
                        Console.WriteLine("Масть — Черви");
                        break;
                    default:
                        Console.WriteLine("Неверная масть");
                        break;
                }
            }

        }
    }
}
