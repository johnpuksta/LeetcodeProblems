using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateFunction(int[] nums)
        {
            var t = nums.OrderByDescending(s => s).ToArray();
            for (int i = 0; i < nums.Length - 1; i++){
                if(t[i] == t[i+1]){
                    return true;
                }
            }
            return false;
        }
    }
}