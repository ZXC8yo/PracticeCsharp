using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;


namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            triangle.PerimeterCalculated += perimeter =>
            {
                Console.WriteLine($"Периметр:{perimeter}");
            };

            triangle.AreaCalculated += area =>
            {
                Console.WriteLine($"Площадь:{area}");
            };

            triangle.SidePrinted += side =>
            {
                Console.WriteLine($"Сторона:{side}");
            };

            double sideTriangle = 5.0;

            triangle.CalculatePerimeter(sideTriangle);
            triangle.CalculateArea(sideTriangle);
            triangle.PrintSide(sideTriangle);

            Console.ReadKey();
        }
    }
}