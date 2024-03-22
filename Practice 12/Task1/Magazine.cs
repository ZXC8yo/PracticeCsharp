using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Magazine : PrintedProducts
    {
        private int circulation;
        private int price;

        public Magazine(string name , int circulation, int price) : base(name)
        {
            this.circulation = circulation;
            this.price = price;
        }

        public int Circulation
        { 
            get { return circulation; }
            set { circulation = value; }

        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }




        public virtual int GetPrice()
        {
            return circulation * price;
        }
    }
}
