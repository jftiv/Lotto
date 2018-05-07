using System;
using System.Collections.Generic;
using System.Text;

namespace LottoGame
{
    public static class NumChecker
    {
        public static int CorrectNums(int[] a, int[] b)
        {
            int numRight = 0;
            for (int i = 0; i < 6; i++)
            {
                if (a[i] == b[0] || a[i] == b[1] || a[i] == b[2] || a[i] == b[3] || a[i] == b[4] || a[i] == b[5])
                {
                    numRight += 1;
                }
            }
            return numRight;
        }

    }
}
