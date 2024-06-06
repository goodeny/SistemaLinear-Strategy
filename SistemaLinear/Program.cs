using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLinear
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double[,] A = MatrixGenerator.Generate3x3Matrix();
            double[] b = MatrixGenerator.Generate3x1Matrix();

            //Console.WriteLine("Matrix A:");
            //PrintMatrix(A);
            //Console.WriteLine("Matrix b:");
            //PrintVector(b);

            IMatrixDecomposition luDecomposition = new LUDecomposition();
            MatrixSolver solver = new MatrixSolver(luDecomposition);

            solver.Solve(A, b);
            Console.ReadKey();
        }

        private static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        private static void PrintVector(double[] vector)
        {
            foreach (var value in vector)
            {
                Console.Write(value + "\t");
            }
            Console.WriteLine();
        }
    }
}