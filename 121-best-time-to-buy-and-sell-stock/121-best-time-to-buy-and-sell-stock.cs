public class Solution {
    public int MaxProfit(int[] prices) {
        var min = prices[0];
        var maxProfit = 0;
        for(int index = 0; index < prices.Length; index++)
        {
            min = Math.Min(min, prices[index]);
            var profit = prices[index] - min;
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;
    }
}