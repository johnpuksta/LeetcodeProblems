using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows) {
            IList<IList<int>> retList = new List<IList<int>>();
            List<int> tempList = new List<int>(1){1};
            retList.Add(tempList);
            if(numRows == 1){
                return retList;
            }
            if(numRows == 2){
                tempList = new List<int>(2) { 1, 1 };
                retList.Add(tempList);
                return retList;
            }
            tempList = new List<int>(2) { 1, 1 };
            retList.Add(tempList);
            int refVal1 = 0;
            int refVal2 = 0;
            for (int i = 3; i <= numRows; i++){
                tempList = new List<int>(i);
                tempList.Add(1);
                for (int j = 1; j < i-1; j ++){
                    refVal1 = retList.ElementAt(i-2).ElementAt(j-1);
                    refVal2 = retList.ElementAt(i-2).ElementAt(j);
                    tempList.Add(refVal1 + refVal2);
                }
                tempList.Add(1);
                retList.Add(tempList);
            }
            return retList;
        }
    }
}