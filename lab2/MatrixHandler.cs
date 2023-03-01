using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    /// <summary>
    /// <c>MatrixHandler</c> class works only with data of <typeparamref name="int"/> type
    /// </summary>
    public class MatrixHandler
    {
        private int defaultMinNumber = 0;
        private int defaultMaxNumber = 10;

        private int[,] matrix = new int[8, 8];
        public int[,] Matrix { get { return matrix; } }


        public MatrixHandler()
        {
            FillMatrix(defaultMinNumber, defaultMaxNumber);
        }

        public MatrixHandler(int minNumber, int maxNumber)
        {
            FillMatrix(minNumber, maxNumber);
        }

        /// <summary>
        /// Fills matrix with random numbers from <c>minNumber</c> to <c>maxNumber</c>
        /// </summary>
        public void FillMatrix(int minNumber, int maxNumber)
        {
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    matrix[i, y] = random.Next(minNumber, maxNumber);
                }
            }
        }

        /// <summary>
        /// Fills the entire matrix with one number
        /// </summary>
        public void FillMatrix(int num)
        {
            // I don't want to duplicate the code
            FillMatrix(num, num);
        }

        /// <summary>
        /// Shows the matrix in the console
        /// </summary>
        public void ShowMatrix()
        {
            int i = 0;

            Console.WriteLine($"Matrix:");
            foreach (int element in matrix)
            {
                Console.Write($"{element}\t");
                i++;

                if (i == matrix.GetLength(0))
                {
                    Console.Write("\n");
                    i = 0;
                }
            }
        }

        /// <summary>
        /// Finds an element in the matrix that has the same row and column indexes
        /// </summary>
        /// <returns>Founded elements in list <c>List</c> of <typeparamref name="int"/></returns>
        public List<int> SameRowColumnElement()
        {
            List<int> elements = new List<int>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (i == y)
                    {
                        elements.Add(matrix[i, y]);
                    }
                    
                }
            }

            return elements;
        }

        /// <summary>
        /// Sums all elements in a row of a matrix that have at least one negative number
        /// </summary>
        public int SumAtLeastNegative()
        {
            bool founded = false;

            int sum = 0;
            int temp = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    int num = matrix[i, y];
                    temp += num;

                    if (num < 0) founded = true;
                }
                if (founded) sum += temp;
                temp = 0;
            }

            return sum;
        }


    }
}
