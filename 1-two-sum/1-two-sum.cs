public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var i = 0;
        var j = 0;
        for(i = 0; i < nums.Length; i++)
        {
            for(j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                    return new int[]{i,j};
            }
        }
        
        return null;
    }
}