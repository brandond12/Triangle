﻿using System;
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
            Triangle t = new Triangle();
            int result = t.squareNum(2);
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void SquareRootAInt()
        {
            Triangle t = new Triangle();
            double result = t.squareRootNum(4);
            Assert.AreEqual(result, 2);
        }
    }
}
