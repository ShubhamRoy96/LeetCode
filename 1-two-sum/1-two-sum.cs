public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dataDict = new Dictionary<int, int>();
        var result = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            if(dataDict.ContainsKey(nums[i]))
            {
                result[0] = dataDict[nums[i]];
                result[1] = i;
                break;
            }
            else   
            {
                if(!dataDict.ContainsKey(target - nums[i]))
                {
                    dataDict.Add(target - nums[i], i);                    
                }
            }
        }
        
        return result;
    }
}