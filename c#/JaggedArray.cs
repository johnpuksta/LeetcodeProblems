using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class JaggedArray
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c) {
            int m = mat.Length;
            int n = mat[0].Length;
            if (m * n != r * c)
            {
                return mat;
            }
            List<int> allVals = new List<int>();
            int[][] retArr = new int[r][];
            for (int j = 0; j < r; j++){
                retArr[j] = new int[c];
            }
            for (int i = 0; i < m; i++){
                allVals.AddRange(mat[i]);
            }
            var allVals2 = allVals.ToArray();
            for (int p = 0; p < r; p++){
                var start = p*c;
                var end = start + c;
                retArr[p] = allVals2[start..end];
            }
            return retArr;
        }
    }
}
/*          Program.cs
            int[] nums1 = new int[] { 7, 2, 4, 1 };
            int[][] array2D = new int[1][];
            array2D[0] = new int[4];
            array2D[0][0] = 1;
            array2D[0][1] = 2;
            array2D[0][2] = 3;
            array2D[0][3] = 4;
            int c = 2;
            int r = 2;
            JaggedArray testClass = new JaggedArray();
            var res = testClass.MatrixReshape(array2D,c,r);
*/