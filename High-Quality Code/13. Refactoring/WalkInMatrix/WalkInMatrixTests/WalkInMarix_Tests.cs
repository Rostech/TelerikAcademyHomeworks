using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WalkInMatrix;
using System.Text;

namespace WalkInMatrixTests
{
    [TestClass]
    public class WalkInMarix_Tests
    {
        [TestMethod]
        public void WalkInMatrixShouldWorkPropperlyWithWidthOf2()
        {
            StringBuilder strB = new StringBuilder();
            strB.Append("  1  4");
            strB.Append("\n");
            strB.Append("  3  2");
            strB.Append("\n");

            Matrix matrix = new Matrix(2);
            matrix.WalkInTheMatrix();

            Assert.AreEqual(strB.ToString(), matrix.ToString());
        }

        [TestMethod]
        public void WalkInMatrixShouldWorkPropperlyWithWidthOf6()
        {
            StringBuilder strB = new StringBuilder();

            strB.Append("  1 16 17 18 19 20\n");
            strB.Append(" 15  2 27 28 29 21\n");
            strB.Append(" 14 31  3 26 30 22\n");
            strB.Append(" 13 36 32  4 25 23\n");
            strB.Append(" 12 35 34 33  5 24\n");
            strB.Append(" 11 10  9  8  7  6\n");

            Matrix matrix = new Matrix(6);
            matrix.WalkInTheMatrix();

            Assert.AreEqual(strB.ToString(), matrix.ToString());
        }

        [TestMethod]
        public void WalkInMatrixShouldWorkPropperlyWithWidthOf8()
        {
            StringBuilder strB = new StringBuilder();

            strB.Append("  1 22 23 24 25 26 27 28\n");
            strB.Append(" 21  2 39 40 41 42 43 29\n");
            strB.Append(" 20 50  3 38 48 49 44 30\n");
            strB.Append(" 19 61 51  4 37 47 45 31\n");
            strB.Append(" 18 60 62 52  5 36 46 32\n");
            strB.Append(" 17 59 64 63 53  6 35 33\n");
            strB.Append(" 16 58 57 56 55 54  7 34\n");
            strB.Append(" 15 14 13 12 11 10  9  8\n");

            Matrix matrix = new Matrix(8);
            matrix.WalkInTheMatrix();

            Assert.AreEqual(strB.ToString(), matrix.ToString());
        }
    }
}
