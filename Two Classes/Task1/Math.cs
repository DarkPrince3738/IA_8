using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    static class Math
    {
        public const double PI = 3.14;
        public const double E = 1.67;
        public static int MyFavoriteNumber = 7;

        public static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        public static int Min(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;

        }

        public static int Min(int[] a)
        {
            int k = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (k > a[i])
                {
                    k = a[i];
                }
            }
            return k;
        }
    }
}
