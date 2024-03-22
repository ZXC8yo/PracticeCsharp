using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Triangle
    {
        public event Action<double> PerimeterCalculated;
        public event Action<double> AreaCalculated;
        public event Action<double> SidePrinted;
        public void CalculatePerimeter(double side)
        {
            double perimeter = 3 * side;
            PerimeterCalculated?.Invoke(perimeter);
        }

        public void CalculateArea(double side)
        {
            double area = (Math.Sqrt(3) / 4) * Math.Pow(side, 2);
            AreaCalculated?.Invoke(area);
        }

        public void PrintSide(double side)
        {
            SidePrinted?.Invoke(side);
        }
    }
}