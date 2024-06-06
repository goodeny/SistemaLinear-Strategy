using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLinear
{
    public interface IMatrixDecomposition
    {
        void Decompose(double[,] A, double[] b, out double[,] L, out double[,] U, out double[] x);
    }
}
