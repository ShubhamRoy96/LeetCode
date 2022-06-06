public class Solution {
    public bool IsAnagram(string s, string t) {
        var firstStrArr = s.ToArray();
        Array.Sort(firstStrArr);        
        var firstStrSorted = new string(firstStrArr);
        var secondStrArr = t.ToArray();
        Array.Sort(secondStrArr);        
        var secondStrSorted = new string(secondStrArr);
        return firstStrSorted == secondStrSorted;
    }
}