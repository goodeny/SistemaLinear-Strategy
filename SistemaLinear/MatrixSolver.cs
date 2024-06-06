using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLinear
{
    public class MatrixSolver
    {
        private IMatrixDecomposition _decompositionStrategy;

        public MatrixSolver(IMatrixDecomposition decompositionStrategy)
        {
            _decompositionStrategy = decompositionStrategy;
        }

        public void SetStrategy(IMatrixDecomposition decompositionStrategy)
        {
            _decompositionStrategy = decompositionStrategy;
        }

        public void Solve(double[,] A, double[] b)
        {
            _decompositionStrategy.Decompose(A, b, out double[,] L, out double[,] U, out double[] x);

            //Console.WriteLine("Matrix L:");
            //PrintMatrix(L);
            //Console.WriteLine("Matrix U:");
            //PrintMatrix(U);
            Console.WriteLine("Solution x:");
            PrintVector(x);
        }

        private void PrintMatrix(double[,] matrix)
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

        private void PrintVector(double[] vector)
        {
            foreach (var value in vector)
            {
                Console.Write(value + "\t");
            }
            Console.WriteLine();
        }
    }
}
