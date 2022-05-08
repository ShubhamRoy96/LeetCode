public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dictNums = new Dictionary<int,int>();
        foreach(var num in nums)
        {
            if(dictNums.ContainsKey(num))
            {
                return true;
            }
            else
            {                
                dictNums.Add(num,1);
            }
        }
        return false;
    }
}