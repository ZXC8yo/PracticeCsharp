using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book()
            {
                Title = "Дюна",
                Author = "Фрэнк Герберт",
                PublicationDate = new DateTime(1965, 8, 10)
            };
            book1.AddGenre("Классика");
            book1.AddGenre("Фантастика");

            var book2 = book1.Clone() as Book;
            book2.Title = "Убить пересмешника";
            book2.Author = "Харпер Ли";
            book2.PublicationDate = new DateTime(1960, 7, 11);
            book2.RemoveGenre("Классика");
            book2.AddGenre("Литературная фантастика");

            book1.PrintInfo();
            Console.WriteLine();

            book2.PrintInfo();
        }
    }
}
