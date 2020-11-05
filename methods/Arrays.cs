using System;
using System.Collections.Generic;
using System.Text;

namespace methods
{
    public static class Arrays
    {
        public static int GetIndexOfMinimal(int[] a)
        {
            int minimal = 0;
            int indexOfMinimal = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < minimal)
                {
                    minimal = a[i];
                    indexOfMinimal = i;
                }
            }

            return indexOfMinimal;
        }

        public static int GetIndexOfMaximal(int[] a)
        {
            int maximal = 0;
            int indexOfMaximal = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maximal)
                {
                    maximal = a[i];
                    indexOfMaximal = i;
                }
            }

            return indexOfMaximal;
        }

        public static int GetMinimalElement(int[] a)
        {
            int minimal = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < minimal)
                {
                    minimal = a[i];
                }
            }

            return minimal;
        }

        public static int GetMaximalElement(int[] a)

        {
            int maximal = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maximal)
                {
                    maximal = a[i];
                }
            }

            return maximal;
        }

        public static int GetQuantityOfOddElements(int[] a)
        {
            int quantityOdd = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    quantityOdd++;
                }
            }

            return quantityOdd;
        }

        public static int[] Reverse(int[] a)
        {
            int buffer = 0;

            for (int i = 0; i < a.Length / 2; i++)
            {
                buffer = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = buffer;
            }

            return a;
        }

        public static int GetSumOfElementsWithOddIndexes(int[] a)
        {
            int sumOdd = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sumOdd += a[i];
                }
            }

            return sumOdd;
        }

        public static int[] SwapHalves(int[] a)
        {
            int buffer = 0;

            for (int i = 0; i < a.Length / 2; i++)
            {
                buffer = a[i];
                a[i] = a[(a.Length + 1) / 2 + i];
                a[(a.Length + 1) / 2 + i] = buffer;

            }

            return a;
        }

        public static int[] DoAscendingSort(int[] a)
        {
            int buffer = 0;

            for (int i = 1; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        buffer = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = buffer;
                    }
                }
            }

            return a;
        }

        public static int[] DoDescendingSort(int[] a)
        {
            int buffer = 0;

            for (int i = 0; i < a.Length - 1; i++)
            {

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        buffer = a[i];
                        a[i] = a[j];
                        a[j] = buffer;
                    }
                }
            }

            return a;
        }

    }
}
