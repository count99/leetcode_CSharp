public class Solution {
    
    public int[] RunningSum(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                continue;
            }
            else
            {
                nums[i] = nums[i] + nums[i - 1];
            }
            
        }
        return nums;
    }
    
    public static void Main()
    {
        Solution first = new Solution();
        int[] test = { 3,1,2,10,1 };
        int[] answer = first.RunningSum(test);
        foreach (var i in answer)
        {
            Console.WriteLine(i);
        }
    }
}