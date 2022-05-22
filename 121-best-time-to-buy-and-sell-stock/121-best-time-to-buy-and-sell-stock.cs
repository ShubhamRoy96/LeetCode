public class Solution {
    public int MaxProfit(int[] prices) {
        int? min = null;
        var maxProfit = 0;
        for(int index = 0; index < prices.Length - 1; index++)
        {
            var max = 0;
            if(prices[index] >= prices[index + 1])
            {
                if(min == null || prices[index + 1] < min)
                {
                    min = prices[index + 1];
                }
            }
            else
            {
                max = prices[index + 1];
                if(min == null || prices[index + 1] < min)
                {
                    min = prices[index];
                }
            }           
            
            maxProfit = maxProfit < max - (int)min ? max - (int)min : maxProfit;
        }
        return maxProfit;
    }
}