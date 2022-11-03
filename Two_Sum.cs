namespace leetcode1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] pick_nums = new int[2];
            int[] pick_nums_index = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                pick_nums[0] = nums[i];
                pick_nums_index[0] = i;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j != i)
                    {
                        int sum = nums[i] + nums[j];
                        if (sum == target)
                        {
                            pick_nums[1] = nums[j];
                            pick_nums_index[1] = j;
                            break;
                        }
                    }
                }
                if (pick_nums[0] + pick_nums[1] == target)
                {
                    break;
                }
            }
            return pick_nums_index;
        }
        //public static void Main()
        //{
            //Solution sol = new();
        //    int[] input1 = { 2, 7, 11, 15 };
        //    int aNumber = 9;
        //    System.Console.Write("[{0}]", string.Join(", ", sol.TwoSum(input1, aNumber)));
        //}
    }
        
}