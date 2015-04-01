using System;
using NUnit.Framework;

namespace SpiralMatrix
{
    class Class
    {
        int[,] initMatr;
        int[,] spiralMatr;

        int[] unwrappedInitMatr;
        int[] unwrappedSpiralMatr;

        int sum;

        [SetUp]
        public void Init()
        {
            sum = sumMultiple();

            int m = 5, n = 4, start = 1;
            initMatr = initMatrix(m, n, start);
            spiralMatr = spiralMatrix(m, n, start);

            unwrappedInitMatr = unwrapMatrix(initMatr, m, n);
            unwrappedSpiralMatr = unwrapMatrix(spiralMatr, m, n);
        }

        [Test]
        public void CheckInitMatr()
        {
            int[,] matrix = new int[,] {
                       {1,2,3,4},
                       {5,6,7,8},
                       {9,10,11,12},
                       {13,14,15,16},
                       {17,18,19,20}
                   };

            CollectionAssert.AreEqual(matrix, initMatr);
        }

        [Test]
        public void CheckSpiralMatr()
        {
            int[,] matrix = new int[,] {
                       {1,2,3,4},
                       {5,6,7,8},
                       {9,10,11,12},
                       {13,14,15,16},
                       {17,18,19,20}
                   };

            CollectionAssert.AreEqual(matrix, initMatr);
        }

        [Test]
        public void CheckUnwrappedInitMatr()
        {
            int[] matrix = new int[] { 1, 2, 3, 4, 8, 12, 16, 20, 19, 18, 17, 13, 9, 5, 6, 7, 11, 15, 14, 10 };

            CollectionAssert.AreEqual(matrix, unwrappedInitMatr);
        }

        [Test]
        public void CheckUnwrappedSpiralMatr()
        {
            int[] matrix = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            CollectionAssert.AreEqual(matrix, unwrappedSpiralMatr);
        }

        [Test]
        public void CheckSum()
        {
            int sumA = 233168;

            Assert.AreEqual(sumA, sum);
        }

        static public int sumMultiple()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum: " + sum);

            return sum;
        }

        static public int[,] spiralMatrix(int m, int n, int start)
        {
            int x = 0, y = 0, size = m, size2 = n;
            int[,] mat = new int[m, n];

            while (size > 0)
            {
                for (int i = y; i < y + size - 1; i++)
                {
                    mat[x, i] = start++;
                }

                for (int j = x + 1; j <= x + size2 - 1; j++)
                {
                    mat[j, y + size2 - 1] = start++;
                }

                for (int i = y + size - 2; i >= y; i--)
                {
                    mat[x + size - 1, i] = start++;
                }

                for (int i = x + size - 2; i >= x + 1; i--)
                {
                    mat[i, y] = start++;
                }

                x = x + 1;
                y = y + 1;
                size = size - 2;
                size2 = size2 - 2;
            }
            return mat;
        }

        private static int[,] initMatrix(int m, int n, int start)
        {
            int[,] mat = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = start;
                    start += 1;
                }
            }
            return mat;
        }

        private static int[] unwrapMatrix(int[,] mat, int m, int n)
        {
            int[] unwrMat = new int[m * n];

            int x = 0, y = 0, size = m, size2 = n;

            int c = 0;
            while (size > 0)
            {
                for (int i = y; i < y + size - 1; i++)
                {
                    Console.Write("{0} ", mat[x, i]);
                    unwrMat[c] = mat[x, i];
                    c++;
                }

                for (int j = x + 1; j <= x + size2 - 1; j++)
                {
                    Console.Write("{0} ", mat[j, y + size2 - 1]);
                    unwrMat[c] = mat[j, y + size2 - 1];
                    c++;
                }

                for (int i = y + size - 2; i >= y; i--)
                {
                    Console.Write("{0} ", mat[x + size - 1, i]);
                    unwrMat[c] = mat[x + size - 1, i];
                    c++;
                }

                for (int i = x + size - 2; i >= x + 1; i--)
                {
                    Console.Write("{0} ", mat[i, y]);
                    unwrMat[c] = mat[i, y];
                    c++;
                }

                x = x + 1;
                y = y + 1;
                size = size - 2;
                size2 = size2 - 2;
            }

            return unwrMat;
        }
    }
}