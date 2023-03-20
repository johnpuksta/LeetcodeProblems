using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target) {
            int[] retArr = new int[] {0,0};
            var sum = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                for (int j = 0; j <= nums.Length - 1; j++)
                {
                    sum = nums[i] + nums[j];
                    if(sum == target && i != j){
                        retArr[0] = i;
                        retArr[1] = j;
                        return retArr;
                    }
                }
            }
            return retArr;
        }

    }
}