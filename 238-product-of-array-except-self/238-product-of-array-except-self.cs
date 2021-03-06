public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var prefixArr = new int[nums.Length];
        var postfixArr = new int[nums.Length];
        var result = new int[nums.Length];
        
        prefixArr[0] = 1;
        postfixArr[nums.Length - 1] = 1;
        
        for(int i = 1; i < nums.Length; i++)
        {
            prefixArr[i] = prefixArr[i - 1] * nums[i - 1];
        }
        
        for(int j = nums.Length - 2; j >= 0; j--)
        {
            postfixArr[j] = postfixArr[j + 1] * nums[j + 1];
        }
        
        for(int k = 0; k < nums.Length; k++)
        {
            result[k] = prefixArr[k] * postfixArr[k];
        }
        return result;
    }
}