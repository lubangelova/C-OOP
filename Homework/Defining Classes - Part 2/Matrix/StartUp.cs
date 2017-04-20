using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var firstMatrix = new Matrix<int>(5,5);
            var secondMatrix = new Matrix<int>(5, 5);

            firstMatrix.FillMatrix();
            secondMatrix.FillMatrix();
            Console.WriteLine(firstMatrix.ToString());
            Console.WriteLine(secondMatrix.ToString());
            var sumMatrix = new Matrix<int>(firstMatrix.Rows, firstMatrix.Cols);
            var productMatrix = new Matrix<int>(firstMatrix.Rows, secondMatrix.Cols);
            sumMatrix = firstMatrix + secondMatrix;
            productMatrix = firstMatrix * secondMatrix;
            Console.WriteLine(sumMatrix.ToString());
            Console.WriteLine(productMatrix.ToString());
            
        }
    }
}
