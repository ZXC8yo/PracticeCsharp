using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class B : A
    {
        private int d;

        public int DValue { get; set; }

        public B(int a, int b, int d) : base(a, b)
        {
            DValue = d;
        }

        public B(int a, int b, int d, int c2) : base(a, b)
        {
            DValue = d;
            C2 = c2;
        }
        public int C2
        {
            get
            {
                return AValue + BValue + DValue;
            }
            set
            {
                do
                {
                    value++;
                    Console.WriteLine($"числo:{value}");
                }
                while (value > 0 && value < 50);
            }   
        }
    }
}