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
    }
}
