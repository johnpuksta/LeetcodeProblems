using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class IsValidString
    {
        public bool IsValid(string s) {
            Stack<char> charSt = new();
            foreach(char i in s){
                if(i == '{' || i == '(' || i == '['){
                    charSt.Push(i);
                    continue;
                }
                if(charSt.Count() == 0){
                    return false;
                }
                char t = charSt.Pop();
                if(t == '{' && i != '}'){
                    return false;
                }
                if(t == '(' && i != ')'){
                    return false;
                }
                if(t == '[' && i != ']'){
                    return false;
                }
            }
            if(charSt.Count == 0){
                return true;
            }
            return false;
        }
    }
}