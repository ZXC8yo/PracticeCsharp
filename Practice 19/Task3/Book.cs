using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Book :LibraryItemPrototype
    {
        public override void PrintInfo()
        {
            Console.WriteLine("Детали книги:");
            Console.WriteLine("Название: " + Title);
            Console.WriteLine("Автор: " + Author);
            Console.WriteLine("Дата публикации: " + PublicationDate.ToShortDateString());
            Console.WriteLine("Жанры: ");
            foreach (var genre in Genres)
            {
                Console.WriteLine("- " + genre);
            }
        }
    }
}
