using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class CountNSay
    {
        public string CountAndSay(int n) {
            if(n == 1){
                return "1";
            }
            string retStr = "1211";
            string tmp = "";
            int currOccurances = 1;
            int currNum = 1;
            for (int j = 2; j <= n; j++){
                for (int i = 0; i < retStr.Length - 1; i++)
                {   
                    if(retStr[i] == retStr[i+1]){
                            currOccurances += 1;
                            continue;
                        }
                    tmp += currOccurances.ToString();
                    tmp += retStr[i];
                    currNum = retStr[i];
                    currOccurances = 1;
                }
                retStr = tmp;
                tmp = "";
            }
            return retStr;
        }
    }
}