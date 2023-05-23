using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class MaxSubArrayClass
    {
        /*public int MaxSubArray(int[] nums) {
            int retVal = -100001;
            int sum = 0;
            for (int i = 1; i <= nums.Length; i++)
            {
                for (int j = 0; j <= nums.Length - i; j++){
                    var segment = new ArraySegment<int>(nums, j, i);
                    sum = segment.Sum();
                    if(sum > retVal){
                        retVal = sum;
                    }
                }
            }
            return retVal;
        }
        */
        public int MaxSubArray(int[] nums)
        {
            int retVal= -100001;
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if(sum > retVal){
                    retVal = sum;
                }
                if(sum < 0){
                    sum = 0;
                }
            }
            return retVal;
            }
    }
}
