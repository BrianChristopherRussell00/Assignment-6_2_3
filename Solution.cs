using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_2_3
{
    public class Solution
    {
        public static int[] productExceptSelf(int[] nums, int n)
        {
            int c = 0;
            int prod = 1;
            int[] res = new int[n];

            // Calculate product of all non-zero elements and count zeros
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == 0)
                    c++;
                else
                    prod *= nums[i];
            }

            // Generate the result array
            for (int i = 0; i < n; i++)
            {
                if (c > 1)
                    res[i] = 0;
                else if (c == 1)
                {
                    if (nums[i] == 0)
                        res[i] = prod;
                    else
                        res[i] = 0;
                }
                else
                {
                    res[i] = prod / nums[i];
                }
            }

            return res;
        }
    }
}
