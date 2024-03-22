using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);

          
            double sideA = triangle.SideA;
            double sideB = triangle.SideB;
            double sideC = triangle.SideC;

           
            double area = triangle.CalculateArea();

            
            double perimeter = triangle.CalculatePerimeter();

         
            Point medianIntersection = triangle.CalculateMedianIntersection();


            Console.WriteLine($"Стороны треугольников {sideA}, {sideB}, {sideC}") ;
            Console.WriteLine("Площадь: {0}", area);
            Console.WriteLine("Пириметр: {0}", perimeter);
            Console.WriteLine("точки пересечения медиан: ({0}, {1})", medianIntersection.X, medianIntersection.Y);

            Console.ReadLine();
        }
    }
}
