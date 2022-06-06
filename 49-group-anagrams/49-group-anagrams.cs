public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var tempDict = new Dictionary<string,List<string>>();
        var results = new List<IList<string>>();
        foreach(var anagram in strs)
        {
            var tempStrArr = anagram.ToArray();
            Array.Sort(tempStrArr);
            var sortedStrArr = new string(tempStrArr);
            if(tempDict.ContainsKey(sortedStrArr))
            {
                tempDict[sortedStrArr].Add(anagram);
            }
            else
            {
                tempDict.Add(sortedStrArr, new List<string>{anagram});
            }
        }
        foreach(var anagramList in tempDict)
        {
            results.Add(anagramList.Value);
        }
        return results;
    }
}