/*
*******Below is the copied text from yesterday call****
Problem statemen:
You are given an array of distinct integers that contains continuos numbers, except one number is missing.
One number is missing.
Your task is to write a function find_missing_number(nums) that takes the array as input and returns the missing number.

Example:
nums = [2, 4, 6, 3, 7, 8, 9] // range is from 2 to 9
The missing number is: 5

5 + 4 + 3 + 2 + 1
(n * (n+1)) / 2
*/
/*
Not doing any input validation.
*/
namespace Physna.MissingNumber
{
    public class FindMissingNumber
    {
        /// <summary>
        /// This was the first approach that I had mentioned during our call
        /// This takes O(nlogn) time complexity (because of sorting)
        /// </summary>
        public int ArraySortApproach(int[] nums)
        {
            Array.Sort(nums);
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if(nums[i + 1] != nums[i] + 1)
                {
                    return nums[i] + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// This is the second approach that you suggested. Using n(n+1)/2 formula or general n/2 * {2a + (n-1)d} formula
        /// However this is an issue with this approach which we didn't notice during call. We don't know what is the first term in 
        ///the series. For the example you had given during call: [2, 4, 6, 3, 7, 8, 9], the range is from 2 to 9
        /// So we cannot use the Math formula directly. We need to find the first term in the series. I think we can find it 2 ways:
        /// 1. Sort the array and find the first term
        /// 2. Find the minimum number in the array
        /// I will implement the 2nd approach as I already used Array.Sort in <see cref="ArraySortApproach"/> method
        /// This would have taken O(1) time complexity if we had the first term in the series. But since we need to find 
        /// the first term (we cannot assume it to be 1), the complexity is O(n)
        /// </summary>
        public int MathmaticalApproach(int[] nums)
        {
            int min = int.MaxValue;
            foreach(int current in nums)
            {
                if(current < min)
                {
                    min = current;
                }
            }
            int actualSum = 0;
            foreach(int current in nums)
            {
                actualSum += current;
            }
            int expectedLength = nums.Length + 1;
            int expectedSum = ( expectedLength * (2 * min + (expectedLength - 1)) ) / 2;
            return expectedSum - actualSum;
        }

        /// <summary>
        /// Third approach using XOR
        /// Time complexity is O(n)
        /// </summary>
        public int XORApproach(int[] nums)
        {
            //Using explaination from: https://stackoverflow.com/questions/18335587/finding-the-number-missing-in-the-sequence
            int min = int.MaxValue;
            int actualXOR = 0;
            foreach(int current in nums)
            {
                if(current < min)
                {
                    min = current;
                }
                actualXOR ^= current;
            }
            int totalXOR = 0;
            //we could have just calculated the sum using the mathematical formula and then XOR'd it. But trying this approach for sake of it
            for(int i = 0; i <= nums.Length; i++)
            {
                totalXOR ^= (min + i);
            }
            return actualXOR ^ totalXOR;
        }
    }
}