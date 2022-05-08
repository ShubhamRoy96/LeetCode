public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var hash = new HashSet<int>(nums);
        var resultArr = new List<int>();
        var count = nums.Length;
        for(int i = 1; i <= nums.Length; i++)
        {
            if(hash.Add(i))
            {
                resultArr.Add(i);
            }
        }
        return resultArr;
    }
}