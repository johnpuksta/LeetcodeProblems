using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class Search2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            List<int> AllVals = new List<int>();
            for (int i = 0; i < matrix.Length; i++)
            {
                AllVals.AddRange(matrix[i]);
            }
            if(AllVals.Contains(target)){
                return true;
            }
            return false;
        }
    }
}