public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var numSet = new HashSet<int>();
        var containsDuplicate = false;
        foreach(var num in nums)
        {
            if(!numSet.Add(num))
            {
                containsDuplicate = true;
                break;
            }
        }
        return containsDuplicate;
    }
}