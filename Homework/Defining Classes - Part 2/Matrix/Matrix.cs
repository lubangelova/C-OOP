using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T>
        where T:struct, IComparable
    {
        private int cols;
        private int rows;
        private T [,] matrix;

        public Matrix(int inputRows, int inputCols)
        {
            this.Rows = inputRows;
            this.Cols = inputCols;
            this.matrix = new T[this.Rows, this.Cols];
        }

        public int Cols
        {
            get
            {
                    return this.cols;
            }

            private set
            {
                if (value>0 && value<int.MaxValue)
                {
                    this.cols = value;
                }
                else
                {
                    throw new ArgumentException($"Cols must be between 0 and {int.MaxValue}");
                }
            }
                
         }
      
        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value > 0 && value < int.MaxValue)
                {
                    this.rows = value;
                }
                else
                {
                    throw new ArgumentException($"Rows must be between 0 and {int.MaxValue}");
                }
            }

        }
        public T this[int inputRows, int inputCols]
        {
            get
            {
                if (inputRows<0 || inputRows> this.Rows)
                {
                    throw new ArgumentException($"Rows must be between 0 and { this.Rows-1}");
                }
                else if (inputCols<0 || inputCols>this.Cols)
                {
                    throw new ArgumentException($"Cols must be between 0 and { this.Cols - 1}");
                }
                else
                {
                    return this.matrix[inputRows, inputCols];
                }
                
            }

            set
            {
                if (inputRows < 0 || inputRows > this.Rows)
                {
                    throw new ArgumentException($"Rows must be between 0 and { this.Rows - 1}");
                }
                else if (inputCols < 0 || inputCols > this.Rows)
                {
                    throw new ArgumentException($"Cols must be between 0 and { this.Rows - 1}");
                }
                else
                {
                    this.matrix[inputRows, inputCols] = value;
                }
               
            }

            
        }
        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    result.Append(this.matrix[i, j] + " ");
                }
                result.AppendLine();
            }
            return result.ToString();
        }

        public static Matrix <T> operator + (Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var resultMatrix = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows == secondMatrix.rows && firstMatrix.cols == secondMatrix.cols)
            {
                for (int i = 0; i < firstMatrix.rows; i++)
                {
                    for (int j = 0; j < firstMatrix.cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] + (dynamic)secondMatrix[i, j];
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrixes are with diferent sizes");
            }
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var resultMatrix = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows == secondMatrix.rows && firstMatrix.cols == secondMatrix.cols)
            {
                for (int i = 0; i < firstMatrix.rows; i++)
                {
                    for (int j = 0; j < firstMatrix.cols; j++)
                    {
                        resultMatrix[i, j] = (dynamic)firstMatrix[i, j] - (dynamic)secondMatrix[i, j];
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("The matrixes are with diferent sizes");
            }
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            var resultMatrix = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows == secondMatrix.cols)
            {
                for (int i = 0; i < resultMatrix.rows; i++)
                {
                    for (int j = 0; j < resultMatrix.cols; j++)
                    {
                        for (int k = 0; k < resultMatrix.cols; k++)
                        {
                            resultMatrix[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                        }
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new ArgumentException("Rows of first matrix and colsof second matrix must be equal");
            }
        }

        public void FillMatrix()
        {
            var generator = new Random();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    this.matrix[i, j] = (dynamic)generator.Next(-100,100);
                }
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool result = true;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool result = true;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
