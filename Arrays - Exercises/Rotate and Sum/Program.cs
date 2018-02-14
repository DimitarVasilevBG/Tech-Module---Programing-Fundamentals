using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rev = int.Parse(Console.ReadLine());
            Rotate_and_Sum(nums, rev);
            

        }

        static  void Rotate_and_Sum(int[] nums, int rev)
        {
            int[] sum = new int[nums.Length];
            
            for (int i = 0; i < rev; i++)
            {
                int oldnum = nums[nums.Length - 1];
                for (int o = nums.Length-1; o > 0; o--)
                {
                    nums[o] = nums[o - 1];
                }
                nums[0] = oldnum;
                for (int c = 0; c < nums.Length; c++)
                {
                    sum[c] = sum[c] + nums[c];
                }
               
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
