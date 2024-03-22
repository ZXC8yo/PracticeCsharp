using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealMatrix matrix = new RealMatrix(3, 3);

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;
            matrix[2, 0] = 7;
            matrix[2, 1] = 8;
            matrix[2, 2] = 9;

            Console.WriteLine("Исходная матрица: ");
            matrix.PrintMatrix(matrix.Data);

            matrix.ShiftColumns(matrix.Data, 1);
            matrix.PrintMatrix(matrix.Data);


        }
    }
}
