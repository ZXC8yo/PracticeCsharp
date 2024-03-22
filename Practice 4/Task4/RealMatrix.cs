using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class RealMatrix
    {
        private int rows;
        private int columns;
        private int[,] data;


        public int Rows { get; set; }

        public int Columns { get; set; }

        public int[,] Data {  get; set; }

        public RealMatrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Data = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get { return Data[row, column]; }
            set { Data[row, column] = value; }
        }
        public  void ShiftColumns(int[,] matrix, int shiftAmount)
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                for (int i = 0; i < columns; i++)
                {
                    int[] column = new int[rows];
                    for (int j = 0; j < rows; j++)
                    {
                        column[j] = matrix[j, i];
                    }

                    int[] shiftedColumn = new int[rows];
                    for (int j = 0; j < rows; j++)
                    {
                        int newIndex = (j + shiftAmount) % rows;
                        shiftedColumn[newIndex] = column[j];
                    }

                    for (int j = 0; j < rows; j++)
                    {
                        matrix[j, i] = shiftedColumn[j];
                    }
                }
            }

            public  void PrintMatrix(int[,] matrix)
            {
                int rows = matrix.GetLength(0);
                int columns = matrix.GetLength(1);

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }

