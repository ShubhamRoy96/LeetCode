public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hashNums = new HashSet<int>();
        foreach(var num in nums)
        {
            if(!hashNums.Add(num))
                return true;
        }
        return false;
    }
}