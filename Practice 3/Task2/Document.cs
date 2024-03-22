using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Document
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public  void ShowDocument()
        {
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Время: {Date}");
        }
    }
}
