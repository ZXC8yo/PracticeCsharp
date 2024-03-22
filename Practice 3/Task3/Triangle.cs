using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }

        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }

        public  Point CalculateMedianIntersection()
        {
            double centroidX = (SideA + SideB + SideC) / 3;
            double centroidY = CalculateArea() * 2 / (SideA + SideB + SideC);
            return new Point(centroidX, centroidY);
        }


    }
}
