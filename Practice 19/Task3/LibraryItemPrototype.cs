using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class LibraryItemPrototype : ICloneable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<string> Genres { get; set; }

        public LibraryItemPrototype()
        {
            Genres = new List<string>();
        }

        public void AddGenre(string genre)
        {
            Genres.Add(genre);
        }

        public void RemoveGenre(string genre)
        {
            Genres.Remove(genre);
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public abstract void PrintInfo();

    }
}
