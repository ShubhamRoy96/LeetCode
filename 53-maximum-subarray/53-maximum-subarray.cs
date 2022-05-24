public class Solution {
    public int MaxSubArray(int[] nums) {
        var maxSum = nums[0];
        var curSum = 0;
        foreach(var num in nums)
        {            
            if(curSum < 0)
                curSum = 0;
            curSum += num;
            maxSum = Math.Max(curSum, maxSum);
        }        
        return maxSum;
    }
}