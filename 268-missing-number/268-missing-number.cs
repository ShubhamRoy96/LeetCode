public class Solution {
    public int MissingNumber(int[] nums) {
        int xor = 0;
        int i = 0;
        for(i = 0; i < nums.Length; i++)
        {
            xor = xor ^ i ^ nums[i];
        }
        return xor ^ i;
    }
}