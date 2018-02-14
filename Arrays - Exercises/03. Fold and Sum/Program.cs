using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();
            List<int> middle = new List<int>();
            //Left and Right
            for (int i = 0; i < (nums.Length/4); i++)
            {
                Left.Add(nums[i]);
            }
            Left.Reverse();
            

            for (int i = nums.Length-Left.Count; i <= nums.Length-1; i++)
            {
                Right.Add(nums[i]);
            }
            
            Right.Reverse();
            Left.AddRange(Right);
            //Middle
            for (int i = nums.Length/4; i <= (nums.Length / 4) + (nums.Length/2)-1; i++)
            {
                middle.Add(nums[i]);
            }
            List<int> sum = new List<int>();
            for (int i = 0; i < middle.Count; i++)
            {
                sum.Add(middle[i] + Left[i]);
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
