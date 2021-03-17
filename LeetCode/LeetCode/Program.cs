using System;
using System.Text.RegularExpressions;
namespace LeetCode{
    class Program {
        static void Main(string[] args) {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };
            Program program = new Program();
            program.Rotate(matrix);
            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 3; j++){
                    Console.Write(matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
        public void Rotate(int[][] matrix)
        {
            int matrixSize = matrix.Length;
            int[][] transposed = new int[matrixSize][];
            for (int j = 0; j < matrixSize; j++)
            {
                int[] transposedRow = new int[matrixSize];
                for (int i = 0; i < matrixSize; i++)
                {
                    transposedRow[matrixSize - i - 1] = matrix[i][j];
                }
                transposed[j] = transposedRow;
            }
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i][j] = transposed[i][j];
                }
            }
        }
    }
}

