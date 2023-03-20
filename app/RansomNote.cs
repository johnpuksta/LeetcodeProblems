using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine) {
            Dictionary<char, int> DictMag = new();
            foreach(char c in magazine){
                if(DictMag.ContainsKey(c)){
                    DictMag[c] += 1;
                }
                if(!DictMag.ContainsKey(c)){
                    DictMag.Add(c, 1);
                }
            }
            Dictionary<char, int> DictRN = new();
            foreach(char c in ransomNote){
                if(DictRN.ContainsKey(c)){
                    DictRN[c] += 1;
                }
                if(!DictRN.ContainsKey(c)){
                    DictRN.Add(c, 1);
                }
            }
            foreach(var item in DictRN){
                if(!DictMag.ContainsKey(item.Key)){
                    return false;
                }
                if(item.Value > DictMag[item.Key]){
                    return false;
                }
            }
            return true;
        }
    }
}