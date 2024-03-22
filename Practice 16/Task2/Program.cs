using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Потерял весь мир, забыл себя, я тону в омуте", 1);
            myDictionary.Add("Глаза как у ребёнка, и я забываю голос твой", 2);
            myDictionary.Add("Как снег февральским утром, я весь покрытый холодом", 3);

            Console.WriteLine($"Значение элемента:{myDictionary["Глаза как у ребёнка, и я забываю голос твой"]}");
            Console.WriteLine($"Количество:{myDictionary.Count}");

            Console.ReadLine();
        }
    }
}