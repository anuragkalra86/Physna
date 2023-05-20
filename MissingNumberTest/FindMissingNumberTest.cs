namespace MissingNumberTest;
using Physna.MissingNumber;

[TestClass]
public class FindMissingNumberTest
{
    [TestMethod]
    public void TestExampleDiscussedDuringCall()
    {
        int[] nums = new int[] { 2, 4, 6, 3, 7, 8, 9 };
        //create a clone array of nums
        int[] numsClone = new int[nums.Length];
        nums.CopyTo(numsClone, 0);
        FindMissingNumber findMissingNumber = new FindMissingNumber();
        int missingNumber1 = findMissingNumber.ArraySortApproach(numsClone);
        int missingNumber2 = findMissingNumber.MathmaticalApproach(numsClone);
        int missingNumber3 = findMissingNumber.XORApproach(numsClone);
        Assert.AreEqual(5, missingNumber1);
        Assert.AreEqual(5, missingNumber2);
        Assert.AreEqual(5, missingNumber3);
    }

    [TestMethod]
    public void TestElementsInOrder()
    {
        int[] nums = new int[] { 1,2,3,4,6 };
        //create a clone array of nums
        int[] numsClone = new int[nums.Length];
        nums.CopyTo(numsClone, 0);
        FindMissingNumber findMissingNumber = new FindMissingNumber();
        int missingNumber1 = findMissingNumber.ArraySortApproach(numsClone);
        int missingNumber2 = findMissingNumber.MathmaticalApproach(numsClone);
        int missingNumber3 = findMissingNumber.XORApproach(numsClone);
        Assert.AreEqual(5, missingNumber1);
        Assert.AreEqual(5, missingNumber2);
        Assert.AreEqual(5, missingNumber3);
    }

    [TestMethod]
    public void TestNoMissingElement()
    {
        int[] nums = new int[] { 1,2,3,5,6,4 };
        //create a clone array of nums
        int[] numsClone = new int[nums.Length];
        nums.CopyTo(numsClone, 0);
        FindMissingNumber findMissingNumber = new FindMissingNumber();
        int missingNumber1 = findMissingNumber.ArraySortApproach(numsClone);
        int missingNumber2 = findMissingNumber.MathmaticalApproach(numsClone);
        int missingNumber3 = findMissingNumber.XORApproach(numsClone);
        Console.WriteLine($"Approach 1: Missing number is: {missingNumber1}, {missingNumber2}, {missingNumber3}");
        Assert.AreEqual(-1, missingNumber1);
        Assert.AreEqual(7, missingNumber2);
        Assert.AreEqual(7, missingNumber3);
    }

    [TestMethod]
    public void TestInputFailedBefore()
    {
        int[] nums = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,15};
        //create a clone array of nums
        int[] numsClone = new int[nums.Length];
        nums.CopyTo(numsClone, 0);
        FindMissingNumber findMissingNumber = new FindMissingNumber();
        int missingNumber1 = findMissingNumber.ArraySortApproach(numsClone);
        int missingNumber2 = findMissingNumber.MathmaticalApproach(numsClone);
        int missingNumber3 = findMissingNumber.XORApproach(numsClone);
        Console.WriteLine($"Approach 1: Missing number is: {missingNumber1}, {missingNumber2}, {missingNumber3}");
        Assert.AreEqual(14, missingNumber1);
        Assert.AreEqual(14, missingNumber2);
        Assert.AreEqual(14, missingNumber3);
    }



    [TestMethod]
    public void TestArraySortApproach()
    {
        int[] nums = new int[] { 2, 4, 6, 3, 7, 8, 9 };
        FindMissingNumber findMissingNumber = new FindMissingNumber();
        int missingNumber = findMissingNumber.ArraySortApproach(nums);
        Assert.AreEqual(5, missingNumber);
    }

    [TestMethod]
    public void TestMathmaticalApproach()
    {
        int[] nums = new int[] { 2, 4, 6, 3, 7, 8, 9 };
        FindMissingNumber findMissingNumber = new FindMissingNumber();
        int missingNumber = findMissingNumber.MathmaticalApproach(nums);
        Assert.AreEqual(5, missingNumber);
    }

    [TestMethod]
    public void TestXORApproach()
    {
        int[] nums = new int[] { 2, 4, 6, 3, 7, 8, 9 };
        FindMissingNumber findMissingNumber = new FindMissingNumber();
        int missingNumber = findMissingNumber.XORApproach(nums);
        Assert.AreEqual(5, missingNumber);
    }
}