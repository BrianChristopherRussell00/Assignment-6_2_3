using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Assignment_6_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4};
            int[] result = Solution.productExceptSelf(nums, nums.Length);

            foreach (int val in result)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();



        }
    }
}
