using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class A
    {
        public int b { get; set; }
        public int a { get; set; }

        public A(int a, int b)
        {
            this.b = b;
            this.a = a;
        }

        public double Kalculation(int a, int b)
        {
            double answer = a * Math.Sqrt(b) - Math.Sin(a);

            return answer;
        }

        public double Cubing(int a, int b)
        {
            double answer = Math.Pow(a * b, 3);
            return answer;
        }
    }
}
