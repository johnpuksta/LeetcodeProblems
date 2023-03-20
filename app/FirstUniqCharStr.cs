using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class FirstUniqCharStr
    {
        public int FirstUniqChar(string s) {
            List<char> charArr = s.ToCharArray().ToList();
            List<char> checkVals = new List<char>();
            //char firstDisticnt = '/';
            foreach(char i in s){
                charArr.Remove(i);
                if(!charArr.Contains(i) && !checkVals.Contains(i)){
                    return s.IndexOf(i);
                }
                checkVals.Add(i);
                charArr.RemoveAll(s => s == i);
            }
            return -1;
        }   
        public int FirstUniqCharEx(string s) {
            Dictionary<char, List<int>> map = new();
            for(int i=0; i < s.Length; i++)
            {
                char c = s[i];
                if(!map.ContainsKey(c))
                {
                    map.Add(c, new List<int>(new int[]{i}));
                }
                else
                {
                    map[c].Add(i);
                }
            }
            
            for(int i=0; i < s.Length; i++)
            {
                char c = s[i];
                if (map[c].Count == 1)
                {
                    return map[c][0];
                }
            }
            
            return -1;           

    }
    }
}