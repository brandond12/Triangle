using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleTDD
{
    public class Triangle
    {
        public int squareNum(int input)
        {
            int output = 0;
            output = input * input;
            return output;
        }

        public double squareRootNum(int input)
        {
            double output = 0;
            output = Math.Sqrt(input);
            return output;
        }
    }
}
