// See https://aka.ms/new-console-template for more information
using Physna.MissingNumber;

int[] nums = new int[] { 2, 4, 6, 3, 7, 8, 9 };
//int[] nums = new int[] { 2, 3, 4, 5};
//int[] nums = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,15};
//create a clone array of nums
int[] numsClone = new int[nums.Length];
nums.CopyTo(numsClone, 0);
FindMissingNumber findMissingNumber = new FindMissingNumber();
int missingNumber1 = findMissingNumber.ArraySortApproach(numsClone);
Console.WriteLine($"Approach 1: Missing number is: {missingNumber1}");

int missingNumber2 = findMissingNumber.MathmaticalApproach(nums);
Console.WriteLine($"Approach 2: Missing number is: {missingNumber2}");

int missingNumber3 = findMissingNumber.XORApproach(nums);
Console.WriteLine($"Approach 3: Missing number is: {missingNumber3}");
