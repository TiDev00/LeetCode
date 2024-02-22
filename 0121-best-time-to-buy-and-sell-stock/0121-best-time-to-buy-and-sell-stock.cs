public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = 0;
        int sell = 1;
        int maxProfit = 0;
        while(sell < prices.Length){
            if(prices[buy] < prices[sell]){
                maxProfit = Math.Max(maxProfit, (prices[sell] - prices[buy]));
            }
            else{
                buy = sell;
            }
            sell++;
        }
        return maxProfit;
    }
}