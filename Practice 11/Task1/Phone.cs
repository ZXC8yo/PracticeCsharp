using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Phone
    {
        private string name;
        private int k;

        public Phone(string name, int k)
        {
            this.name = name;
            this.k = k;
        }

        public int K
        {
            get { return k; }
            set { k = value; }
        }

        public double CalculaeCash()
        {
            return 40 * Math.Log10(k);
        }


        public void DisplayFields()
        {
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Количество функций: {k}");
        }
    }
}