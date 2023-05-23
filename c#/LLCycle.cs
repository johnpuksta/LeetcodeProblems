using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app
{
    public class LLCycle
    {
        public bool HasCycle(ListNode head) {
            if(head == null){
                return false;
            }
            ListNode tortoise = head;
            ListNode hare = head;
            while(hare != null && hare.next != null){
                tortoise = tortoise.next;
                hare = hare.next.next;
                if(tortoise == hare){
                    return true;
                }
            }
            return false;
        }
    }
    public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int x) {
          val = x;
          next = null;
      }
  }
}

 
