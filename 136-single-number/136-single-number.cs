public class Solution {
    public int SingleNumber(int[] nums) {
        int xor = nums[0];
        for(int counter = 1; counter < nums.Length; counter++)
        {
            xor ^= nums[counter];
        }
        return xor;
    }
}