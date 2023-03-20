using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class BuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            var low = 99999999;
            var currProfit = 0;
            var maxProfit = 0;
            for (int i = 0; i < prices.Length; i++){
                if(prices[i] < low){
                    low = prices[i];
                }
                currProfit = prices[i] - low;
                if(currProfit > maxProfit){
                    maxProfit = currProfit;
                }
            }
            return maxProfit;
        }
    }
}