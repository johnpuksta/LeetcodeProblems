using System.Numerics;
namespace app
{
    public class PlusOne {
        public int[] PlusOneFunction(int[] digits) {
            List<int> retArr = new List<int>();
            string numStr = "";
            foreach(int i in digits){
                numStr += string.Format("{0}",i);
            }
            BigInteger num = BigInteger.Parse(numStr);
            BigInteger newNum = num + 1;
            string numStr2 = BigInteger.Parse(newNum.ToString()).ToString();
            foreach(int j in numStr2){
                int t = j - '0';
                retArr.Add(t);
            }
            return retArr.ToArray();
        }
    }
}
/*
            int[] testarr = new int[]{9,8,7,6,5,4,3,2,1,0};
            var sol = new PlusOne();
            sol.PlusOneFunction(testarr);
*/