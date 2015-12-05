using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleTDD
{
    public class Triangle
    {
        public static int squareNum(int input)
        {
            int output = 0;
            output = input * input;
            return output;
        }

        public static double squareRootNum(int input)
        {
            double output = 0;
            output = Math.Sqrt(input);
            return output;
        }

        public double getHypotenuse(int a, int b)
        {
            double output = 0;
            output = Triangle.squareNum(a) + Triangle.squareNum(b);
            output = Triangle.squareRootNum((int)output);
            return output;
        }
    }
}
