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
            if(input < 0)
            {
                throw new NegitiveNumber();
            }
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

        public static double getHypotenuse(int a, int b)
        {
            double output = 0;
            output = Triangle.squareNum(a) + Triangle.squareNum(b);
            output = Triangle.squareRootNum((int)output);
            return output;
        }

        public static double triangleleArea(int a, int b)
        {
            double output = 0;
            output = a * b * 0.5;
            return output;
        }

        public static double findAngle(int a, int b)
        {
            double output = 0;
            output = 360 - a - b;
            return output;
        }
        
    }
}
