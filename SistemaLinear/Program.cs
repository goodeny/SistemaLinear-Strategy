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
            Console.WriteLine("");
            Console.WriteLine("Escolha o método de decomposição:");
            Console.WriteLine("1 - LU");
            Console.WriteLine("2 - Gauss");
            Console.WriteLine("3 - Cholesky");
            int escolha = int.Parse(Console.ReadLine());
            IStrategy decomposition;
            
                switch (escolha)
                {
                    case 1:
                        decomposition = new LUDecomposition();
                        break;
                    case 2:
                        decomposition = new GaussDecomposition();
                        break;
                    case 3:
                        A = MatrixGenerator.Generate3x3SymmetricPositiveDefiniteMatrix();
                        decomposition = new CholeskyDecomposition();
                        break;
                    default:
                        Console.WriteLine("Escolha inválida.");
                        decomposition = null;
                        break;
                }
                Context solver = new Context(decomposition);
                solver.ExecuteStrategy(A, b);
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