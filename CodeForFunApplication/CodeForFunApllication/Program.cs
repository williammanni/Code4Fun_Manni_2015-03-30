using System;
using System.Collections.Generic;
using System.Text;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] {
                       {1,2,3,4},
                       {5,6,7,8},
                       {9,10,11,12},
                       {13,14,15,16},
                       {17,18,19,20}
                   };

            sumMultiple();

            int m = 5, n = 4, start = 1;
            int[,] mat = new int[m, n];

            Console.WriteLine("\nInitial matrix:");
            mat = initMatrix(m, n, start);
            displayMatrix(mat, m, n);

            Console.WriteLine("\nUnwrapped matrix:");
            unwrapMatrix(mat, m, n);

            Console.WriteLine();

            Console.WriteLine("\nSpiral Matrix:");
            mat = spiralMatrix(m, n, start);
            displayMatrix(mat, m, n);

            Console.WriteLine("\nUnwrapped matrix:");
            unwrapMatrix(mat, m, n);
        }

        static public void sumMultiple()
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

        private static void displayMatrix(int[,] mat, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\t{0}", mat[i, j]);
                }
                Console.WriteLine();
            }
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