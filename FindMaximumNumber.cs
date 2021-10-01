using System;
using System.Collections.Generic;
using System.Text;

namespace Day13
{
    class FindMaximumNumber 
    {
        static int printMaxNum(int num)
        {
            // hashed array to store
            // count of digits
            int[] count = new int[10];

            // Converting given number
            // to string
            String str = num.ToString();

            // Updating the count array
            for (int i = 0; i < str.Length; i++)
                count[str[i] - '0']++;

            // result is to store the
            // final number
            int result = 0, multiplier = 1;

            // Traversing the count array
            // to calculate the maximum number
            for (int i = 0; i <= 9; i++)
            {
                while (count[i] > 0)
                {
                    result = result + (i * multiplier);
                    count[i]--;
                    multiplier = multiplier * 10;
                }
            }

            // return the result
            return result;
        }
    }
}

