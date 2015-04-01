using System;
using NUnit.Framework;

namespace CodeForFunClassLibrary
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
            sum = Sum.sumMultiple();

            int m = 5, n = 4, start = 1;
            initMatr = Spiral.initMatrix(m, n, start);
            spiralMatr = Spiral.spiralMatrix(m, n, start);

            unwrappedInitMatr = Spiral.unwrapMatrix(initMatr, m, n);
            unwrappedSpiralMatr = Spiral.unwrapMatrix(spiralMatr, m, n);
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
                       {14,15,16,5},
                       {13,20,17,6},
                       {12,19,18,7},
                       {11,10,9,8}
                   };

            CollectionAssert.AreEqual(matrix, spiralMatr);
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
    }
}