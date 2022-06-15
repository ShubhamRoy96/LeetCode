public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var elementTracker = new Dictionary<int, int>();
        var prioQ = new PriorityQueue<int, int>();
        var output = new int[k];
        
        foreach(var num in nums)
        {
            if(elementTracker.ContainsKey(num))
            {
                elementTracker[num] += 1;
            }
            else
                elementTracker.Add(num, 1);
        }
        
        foreach(var element in elementTracker)
        {
            prioQ.Enqueue(element.Key, Int32.MaxValue - element.Value);
        }
        
        for(int i = 0; i < k; i++)
        {
            output[i] = prioQ.Dequeue();
        }
        
        return output;
    }
}