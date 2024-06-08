using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLinear
{
    public class MatrixGenerator
    {
        public static double[,] Generate3x3Matrix()
        {
            Random rand = new Random();
            double[,] matrix = new double[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = rand.NextDouble() * 10;
                }
            }
            return matrix;
        }



        public static double[] Generate3x1Matrix()
        {
            Random rand = new Random();
            double[] matrix = new double[3];
            for (int i = 0; i < 3; i++)
            {
                matrix[i] = rand.NextDouble() * 10;
            }
            return matrix;
        }
        public static double[,] Generate3x3SymmetricPositiveDefiniteMatrix()
        {
            // Gera uma matriz 3x3 simétrica positiva definida
            double[,] matrix = new double[3, 3];
            matrix[0, 0] = 4;
            matrix[0, 1] = 1;
            matrix[0, 2] = -1;
            matrix[1, 0] = 1;
            matrix[1, 1] = 5;
            matrix[1, 2] = 3;
            matrix[2, 0] = -1;
            matrix[2, 1] = 3;
            matrix[2, 2] = 5;
            return matrix;
        }
        public static double[] Generate3x1Vector()
        {
            // Gera um vetor 3x1
            Random rand = new Random();
            double[] vector = new double[3];
            for (int i = 0; i < 3; i++)
            {
                vector[i] = rand.NextDouble() * 10;
            }
            return vector;
        }
    }
}
