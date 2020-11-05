using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    static public class Arrays2D
    {
        

        static public int[,] Fill2dArrayOfInt(int[,] argument)
        {
            Random r = new Random();
            int[,] generatedArray = new int[argument.GetLength(0), argument.GetLength(1)];

            for (int i = 0; i < generatedArray.GetLength(0); i++)
            {
                for (int j = 0; j < generatedArray.GetLength(1); j++)
                {
                    generatedArray[i, j] = r.Next(0, 10);
                }
            }

            Array.Copy(generatedArray, argument, generatedArray.Length);

            return argument;
        }

        static public int[] GetIndexOfMaximal(int[,] a)
        {
            int maximal = a[0, 0];
            int iOfMaximal = 0;
            int jOfMaximal = 0;
            int[] result = new int[2];

            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] > maximal)
                    {
                        maximal = a[i, j];
                        iOfMaximal = i;
                        jOfMaximal = j;
                    }
                }
            }

            result[0] = iOfMaximal;
            result[1] = jOfMaximal;

            return (result);
        }

        static public int[] GetIndexOfMinimal(int[,] a)
        {
            int minimal = a[0, 0];
            int iOfMinimal = 0;
            int jOfMinimal = 0;
            int[] result = new int[2];

            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] < minimal)
                    {
                        minimal = a[i, j];
                        iOfMinimal = i;
                        jOfMinimal = j;
                    }
                }
            }

            result[0] = iOfMinimal;
            result[1] = jOfMinimal;

            return (result);
        }

        static public int GetMaximal(int[,] a)
        {
            int maximal = a[0, 0];

            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] > maximal)
                    {
                        maximal = a[i, j];
                    }
                }
            }

            return maximal;
        }

        static public int GetMinimal(int[,] a)
        {
            int minimal = a[0, 0];

            for (int i = 0; i < a.GetLength(1); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] < minimal)
                    {
                        minimal = a[i, j];
                    }
                }
            }

            return minimal;
        }

        static public int GetNumberOfPeaks(int[,] a)
        {

            int result = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (
                        ((i - 1 < 0) || (a[i, j] > a[i - 1, j]))
                        &&
                        ((j + 1 >= a.GetLength(1)) || (a[i, j] > a[i, j + 1]))
                        &&
                        ((i + 1 >= a.GetLength(0)) || (a[i, j] > a[i + 1, j]))
                        &&
                        ((j - 1 < 0) || (a[i, j] > a[i, j - 1]))
                       )
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        
        static public int[,] Transpose(int[,] a)
        {
            int[,] transposedA = new int[a.GetLength(1), a.GetLength(0)];

            for (int i = 0; i < transposedA.GetLength(0); i++)
            {
                for (int j = 0; j < transposedA.GetLength(1); j++)
                {
                    int buffer = a[j, i];
                    transposedA[i, j] = buffer;
                }
            }

            return transposedA;
        }
    }
}
