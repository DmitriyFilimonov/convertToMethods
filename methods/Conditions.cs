using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace methods
{
    public static class Conditions
    {
        public static double DoSomeMath(double a, double b)
        {

            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }

        public static int GetQuarterOfPoint (double x, double y)
        {
            if ((x > 0) && (y > 0))
            {
                return 1;
            }
            else if ((x < 0) && (y > 0))
            {
                return 2;
            }
            else if ((x < 0) && (y < 0))
            {
                return 3;
            }
            else if ((x > 0) && (y < 0))
            {
                return 4;
            }
            else
            {
                throw new Exception("точка находится в начале координат или на одной из осей");
            }
        }

        public static double[] SortByValue(double a, double b, double c)
        {
            double[] result = new double[3];
            
            if ((a < b) && (a < c))
            {
                if (b < c)
                {
                    result[0] = a;
                    result[1] = b;
                    result[2] = c;
                }
                else
                {
                    result[0] = a;
                    result[1] = c;
                    result[2] = b;
                }
            }
            else if ((b < a) && (b < c))
            {
                if (a < c)
                {
                    result[0] = b;
                    result[1] = a;
                    result[2] = c;
                }
                else
                {
                    result[0] = b;
                    result[1] = c;
                    result[2] = a;
                }
            }
            else
            {
                if (a < b)
                {
                    result[0] = c;
                    result[1] = a;
                    result[2] = b;
                }
                else
                {
                    result[0] = c;
                    result[1] = b;
                    result[2] = a;
                }
            }

            return result;
        }

        public static double[] SolveSqrEquation (double a, double b, double c)
        {
            double d = b * b - 4 * a * c;

            if (d > 0)
            {
                double[] result = new double[2];
                result[0] = (-b + Math.Sqrt(d)) / (2 * a);
                result[1] = (-b - Math.Sqrt(d)) / (2 * a);
                return result;
            }
            else if (d == 0)
            {
                double[] result = new double[1];
                result[0] = -b / 2 * a;
                return result;
            }
            else
            {
                throw new Exception ("no roots");
            }
        }

        /*public static string ConvertNumberToString (int twoDigit)
        {
               switch (twoDigit)
                    { 
                    case 10:
                        return ("десять");
                    
                    case 11:
                        return ("одиннадцать");
                    
                    case 12:
                        return ("двенадцать");
                    
                    case 13:
                        return ("тринадцать");
                    
                    case 14:
                        return ("четырнадцать");
                    
                    case 15:
                        return ("пятьнадцать");
                    
                    case 16:
                        return ("шестнадцать");
                    
                    case 17:
                        return ("семнадцать");
                    
                    case 18:
                        return ("восемнадцать");
                    
                    case 19:
                        return ("девятнадцать");

                }

                switch (twoDigit / 10)
                {
                    case 2:
                        return ("двадцать");

                    case 3:
                        return ("тридцать");

                    case 4:
                        return ("сорок");

                    case 5:
                        return ("пятьдесят");

                    case 6:
                        return ("шестьдесят");

                    case 7:
                        return ("семьдесят");

                    case 8:
                        return ("восемьдесят");

                    case 9:
                        return ("девяносто");

                }
                switch (twoDigit % 10)
                {
                    case 1:
                        return (" один");

                    case 2:
                        return (" два");

                    case 3:
                        return (" три");

                    case 4:
                        return (" четыре");

                    case 5:
                        return (" пять");

                    case 6:
                        return (" шесть");

                    case 7:
                        return (" семь");

                    case 8:
                        return (" восемь");

                    case 9:
                        return (" девять");

                }
            }
        }*/


    }
}
