using System;
using System.Collections.Generic;
using System.Text;

namespace CodeForFunApllication
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum.sumMultiple();

            Spiral sp = new Spiral();

            int m = 5, n = 4, start = 1;
            int[,] mat = new int[m, n];

            Console.WriteLine("\nInitial matrix:");
            mat = Spiral.initMatrix(m, n, start);
            Spiral.displayMatrix(mat, m, n);

            Console.WriteLine("\nUnwrapped matrix:");
            Spiral.unwrapMatrix(mat, m, n);

            Console.WriteLine();

            Console.WriteLine("\nSpiral Matrix:");
            mat = CodeForFunApllication.Spiral.spiralMatrix(m, n, start);
            Spiral.displayMatrix(mat, m, n);

            Console.WriteLine("\nUnwrapped matrix:");
            Spiral.unwrapMatrix(mat, m, n);
        }        
    }
}