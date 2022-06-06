public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var i = 0;
        var j = 0;
        var result = new int[2];
        for(i = 0; i < nums.Length; i++)
        {
            for(j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }
        }
        
        return result;
    }
}