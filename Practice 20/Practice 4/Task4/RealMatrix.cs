using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Task4
{
    /// <summary>
    /// Представляет вещественную матрицу.
    /// </summary>
    internal class RealMatrix
    {
        private int[,] data;

        /// <summary>
        /// Получает или задает количество строк в матрице.
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// Получает или задает количество столбцов в матрице.
        /// </summary>
        public int Columns { get; set; }

        /// <summary>
        /// Получает или задает двумерный массив, представляющий данные матрицы.
        /// </summary>
        public int[,] Data { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса RealMatrix с указанным количеством строк и столбцов.
        /// </summary>
        /// <param name="rows">Количество строк.</param>
        /// <param name="columns">Количество столбцов.</param>
        public RealMatrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Data = new int[rows, columns];
        }

        /// <summary>
        /// Получает или задает значение элемента матрицы по указанным индексам.
        /// </summary>
        /// <param name="row">Индекс строки.</param>
        /// <param name="column">Индекс столбца.</param>
        /// <returns>Значение элемента матрицы.</returns>
        public int this[int row, int column]
        {
            get { return Data[row, column]; }
            set { Data[row, column] = value; }
        }

        /// <summary>
        /// Сдвигает столбцы матрицы на указанное количество позиций.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        /// <param name="shiftAmount">Количество позиций для сдвига.</param>
        public void ShiftColumns(int[,] matrix, int shiftAmount)
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

        /// <summary>
        /// Выводит матрицу на консоль.
        /// </summary>
        /// <param name="matrix">Матрица.</param>
        public void PrintMatrix(int[,] matrix)
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