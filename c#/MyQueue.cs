using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class MyQueue {

        public MyQueue() {

        }
        Stack<int> stk = new();
        Stack<int> tempstk = new();
        public void Push(int x) {
            stk.Push(x);
        }
        
        public int Pop() {
            List<int> ts = stk.ToList();
            var ret = ts.Last();
            ts.Remove(ts.Last());
            tempstk.Clear();
            ts.Reverse();
            foreach(int i in ts){
                tempstk.Push(i);
            }
            stk = tempstk;
            return ret;
        }
        
        public int Peek() {
            List<int> ts = stk.ToList();
            return ts.Last();
        }
        
        public bool Empty() {
            var count = stk.Count();
            if(count == 0){
                return true;
            }
            return false;
        }
    }
}