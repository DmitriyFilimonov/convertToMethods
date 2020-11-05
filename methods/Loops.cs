using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    public static class Loops
    {
        public static double Power(int a, int b)
        {
            int counter = Math.Abs(b);

            double result = 1;

            for (int i = 0; i < counter; i++)
            {
                result *= a;
            }

            if (b >= 0)
            {
                return result;
            }
            else
            {
                return (1 / result);
            }
        }

        public static int[] GetAllDividedBy(int a)
        {
            if (a < 1)
            {
                throw new Exception("parameter must be int between 1 and 1000");
            }
            
            int resultArrayLength = 0;


            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    resultArrayLength++;
                }
            }

            int[] result = new int[resultArrayLength];

            resultArrayLength = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    result[resultArrayLength] = i;
                    resultArrayLength++;

                }
            }

            return result;
        }

        public static int GetQuantityOfSqrs(int a)
        {
            int quantity = 0;

            for (int i = 1; i < a; i++)
            {
                if (i*i<a)
                {
                    quantity++;
                }
            }

            return quantity;
        }

        public static double GetHighestDividerFor(int input)
        {
            double lowestPartition = 2;

            double highestDivider;

            while ((input / lowestPartition) % 1 != 0)
            {
                lowestPartition++;
            }

            highestDivider = input / lowestPartition;

            if (highestDivider == input)
            {
                return 1;
            }
            else
            {
                return highestDivider;
            }
        }

        public static int GetSumOfDividedBySevenBetween(int a, int b)
        {
            int sum = 0;
            int ifBMoreThanA;

            if (a > b)
            {
                ifBMoreThanA = a;
                a = b;
                b = ifBMoreThanA;
            }

            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }

        public static int GetFibonacciNumberFromOne(int n)
        {
            
            if (n > 0)
            {
                int a = 0;
                int b = 1;
                for (int i = 0; i < n; i++)
                {
                    b = a + b;
                    a = b - a;
                }

                return a;
            }
            else
            {
                throw new Exception("'n' can not be lower than 1");
            }
        }

        public static int GetMaximalDividerByEuclid(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b) a = a % b;
                else b = b % a;
            }

            return a + b;
        }

        public static double GetCubeRootByBisectionFor(int n)
        {
            double current = 0;
            double left = 0;
            double right = n;

            while (current * current * current != n)
            {
                current = (left + right) / 2;

                if (current * current * current > n)
                {
                    right = current;
                }
                else
                {
                    left = current;
                }
            }

            return current;
        }

        public static int GetQuantityOfOddDigits (int input)
        {
            int n = 0;

            while (input != 0)
            {
                if (input % 2 == 1)
                {
                    n++;
                }

                input /= 10;
            }

            return n;
        }

        public static double Reflect (int argument)
        {
            int quantityOfDigits = 0;

            double reflectedArgument = 0;
            int bufferForDigutsCounter = argument;

            while (bufferForDigutsCounter != 0)
            {
                quantityOfDigits++;
                bufferForDigutsCounter /=  10;
            }

            while (argument != 0)
            {
                
                reflectedArgument += ((argument % 10) * Loops.Power(10, quantityOfDigits - 1));
                argument /= 10;
                quantityOfDigits--;
            }

            return reflectedArgument;
        }

        public static int DoIndescribableMath(int a)//Выведите количество чисел от 1 до N, сумма четных цифр которых больше суммы нечетных.



        {
            int iCurrent;

            int digit;

            int iCurrentSumEven = 0;
            int iCurrentSumOdd = 0;

            int result = 0;

            for (int i = 1; i <= a; i++)
            {
                iCurrent = i;

                iCurrentSumEven = 0;
                iCurrentSumOdd = 0;

                while (iCurrent != 0)
                {
                    digit = iCurrent % 10;

                    if (digit % 2 == 0)
                    {
                        iCurrentSumEven += digit;
                    }
                    else
                    {
                        iCurrentSumOdd += digit;
                    }

                    iCurrent /= 10;
                }

                if (iCurrentSumEven > iCurrentSumOdd)
                {
                    result++;
                }
            }

            return result;
        }

        public static bool FindIdenticalDigits (int a, int b)
        {
            bool result = false;

            do
            {
                int c = b;

                do
                {
                    if ((a % 10) == (c % 10))
                    {
                        result = true;
                    }
                    else
                    {
                        c /= 10;
                    }
                } while ((result == false) && (c != 0));

                a /= 10;

            } while ((result == false) && (a != 0));

            return result;
        }

    }
}
