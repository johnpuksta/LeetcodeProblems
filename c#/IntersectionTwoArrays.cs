using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class IntersectionTwoArrays
    {
        public int[] Intersect(int[] nums1, int[] nums2) {
            var retArr = new List<int>();
            for (int i = 0; i < nums1.Length; i++){
                bool containVal = nums2.Contains(nums1[i]);
                if(containVal){
                    var index = Array.IndexOf(nums2, nums1[i]);
                    nums2[index] = -1;
                    retArr.Add(nums1[i]);
                }
            }
            return retArr.ToArray();
        }
    }
}