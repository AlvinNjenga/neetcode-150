public class Solution {
    public int MaxProfit(int[] prices) {
       var profit = 0;
	
		var left = 0;
		var right = 1;
		
		while (right < prices.Length)
		{
			if (prices[right] > prices[left])
			{
				var tempProfit = prices[right] - prices[left];
				profit = Math.Max(profit, tempProfit);
			} 
			else
			{
				left = right;
			}
			right++;
		}
		
		return profit;
    }
}