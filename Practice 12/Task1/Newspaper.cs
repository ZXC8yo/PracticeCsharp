using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Newspaper : PrintedProducts
    {
        private int circulation;
        private int price;
        private int numberOfSheets;

        public Newspaper(string name, int circulation, int price, int numberOfSheets) : base(name)
        {
            this.circulation = circulation;
            this.price = price;
            this.numberOfSheets = numberOfSheets;
        }

        public int Circulation
        {
            get { return circulation; }
            set { circulation = value; }

        }

        public int NumberOfSheets
        {
            get { return numberOfSheets; }
            set { numberOfSheets = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        public virtual int GetPrice()
        {
          return NumberOfSheets * Circulation * Price;
        }
    }
}
