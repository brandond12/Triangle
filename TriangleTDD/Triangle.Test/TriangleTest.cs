using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTDD;

namespace TriangleClass.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void SquareAInt()
        {
            int result = Triangle.squareNum(2);
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void SquareRootAInt()
        {
            double result = Triangle.squareRootNum(4);
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void GetHypotenuse()
        {
            double result = Triangle.getHypotenuse(3, 4);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TriangleArea()
        {
            double result = Triangle.triangleleArea(3, 4);
            Assert.AreEqual(result, 6);
        }

        [TestMethod]
        public void FindAngle()
        {
            double result = Triangle.findAngle(100, 200);
            Assert.AreEqual(result, 60);
        }
    }
}
