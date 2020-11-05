using System;

namespace methods
{
    static public class Variables
    {
        static public double SolveExpression(int a, int b)
        {
            double result;

            if (a - b == 0)
            {
                throw new Exception("A can not be equal to B");
            }
            else
            {
                result = (5 * a + b * b) / (b - a);
            }
            return result;
        }

        static public int[] GetPartitionAndModulo(int a, int b)
        {
            int[] result;
            result = new int[2];

            result[0] = a / b;
            result[1] = a % b;

            return result;
        }

        static public double SolveLinearEquation(double a = 0, double b = 0, double c = 0)
        {
            double x;

            if (a == 0)
            {
                throw new Exception("A con not be 0");
            }
            else
            {
                x = (c - b) / a;
            }

            return x;
        }

        static public string GetLinearEquatiuon (double x1, double y1, double x2, double y2)
        {
            if ((x1==x2)&&(x1==y1)&&(y1==y2))
            {
                throw new Exception("Impossible to build line on these coordinates");
            }
            else if (x1 == x2)
            {
                return ($"X={Math.Round(x1, 1)}");
            }
            else if (y1 == y2)
            {
                return ($"Y={Math.Round(y1, 1)}");
            }
            else
            {
                double a = -(y1 - y2) / (x2 - x1);
                double b = -(x1 * y2 - x2 * y1) / (x2 - x1);

                if (b < 0)
                {
                    return ($"Y={Math.Round(a, 1)}X{Math.Round(b, 1)}");
                }
                else if (b > 0)
                {
                    return ($"Y={Math.Round(a, 1)}X{ Math.Round(b, 1)}");

                }
                else if (a==1)
                {
                    return ($"Y=X");
                }
                else
                {
                    return ($"Y={Math.Round(a, 1)}X");
                }
            }
        }
    }
}
